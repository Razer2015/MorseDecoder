using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics;

namespace MorseCodeDecoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.pBox_preview.Image = global::MorseCodeDecoder.Properties.Resources.startup;
            btn_Stop.Enabled = false;
        }

        /// <summary>
        /// Variables
        /// </summary>
        private Processing processes;
        private Point pt;
        private Stopwatch sw = new Stopwatch();
        VideoCaptureDevice VideoDevice = null;
        ScreenCaptureStream ScreenStream = null;
        public delegate void Processing(ref Bitmap image);
        private bool check = true;
        private Boolean line_drawed = false;

        private void DrawLine(ref Bitmap image)
        {
            Point p = pt;
            // drawing horizontal line
            Graphics g = Graphics.FromImage(image);
            Pen p1 = new Pen(Color.YellowGreen, 3);
            Point ph = new Point(image.Width, p.Y);
            Point ph2 = new Point(0, p.Y);
            g.DrawLine(p1, p, ph);
            g.DrawLine(p1, p, ph2);
            // drawing vertical line
            ph = new Point(p.X, 0);
            ph2 = new Point(p.X, image.Height);
            g.DrawLine(p1, p, ph);
            g.DrawLine(p1, p, ph2);
            line_drawed = true;
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            if (processes != null)
            {
                processes(ref image);
            }
            pBox_preview.Image = image;
        }

        private void closeVideoSource()
        {
            if (VideoDevice != null)
            {
                if (VideoDevice.IsRunning)
                {
                    pBox_preview.SizeMode = PictureBoxSizeMode.Normal;
                    this.pBox_preview.Image = global::MorseCodeDecoder.Properties.Resources.startup;
                    VideoDevice.SignalToStop();
                    VideoDevice = null;
                    processes = null;
                }
            }
        }

        private void Screen_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            if (processes != null)
            {
                processes(ref image);
            }
            pBox_preview.Image = image;
        }

        private void closeScreenSource()
        {
            if (ScreenStream != null)
            {
                if (ScreenStream.IsRunning)
                {
                    pBox_preview.SizeMode = PictureBoxSizeMode.Normal;
                    this.pBox_preview.Image = global::MorseCodeDecoder.Properties.Resources.startup;
                    ScreenStream.SignalToStop();
                    ScreenStream = null;
                    processes = null;
                }
            }
        }

        /// <summary>
        /// Processing the input
        /// </summary>
        /// <param name="image"></param>
        private void GetOnOffState(ref Bitmap image)
        {
            if (line_drawed)
            {
                Rectangle rect = new Rectangle(pt.X - 3, pt.Y - 3, 6, 6);
                Bitmap img = image.Clone(rect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                UnsafeBitmap uBitmap = new UnsafeBitmap(img);
                uBitmap.LockBitmap();
                float avgBritness = 0;
                for (int x = 0; x < 6; x++)
                {
                    for (int y = 0; y < 6; y++)
                    {
                        byte red, green, blue;
                        red = uBitmap.GetPixel(x, y).red;
                        green = uBitmap.GetPixel(x, y).green;
                        blue = uBitmap.GetPixel(x, y).blue;
                        avgBritness += (299 * red + 587 * green + 114 * blue) / 1000;
                    }
                }
                avgBritness /= 36;
                uBitmap.UnlockBitmap();
                // nUD_brightness threshold for brightness value ( "On" state)
                if (avgBritness > (float)nUD_brightness.Value)
                {
                    if (check)
                    {

                        if (sw.IsRunning)
                        {
                            if (sw.ElapsedMilliseconds > nUD_char.Value && sw.ElapsedMilliseconds <= nUD_word.Value)
                            {
                                Append_morse(" ");
                            }
                            else if (sw.ElapsedMilliseconds > nUD_word.Value)
                            {
                                Append_morse("/");
                            }
                            Append_logging("Off Time : " + Convert.ToString(sw.ElapsedMilliseconds) + "ms\n");
                            sw.Reset();
                            sw.Start();
                        }
                        else
                        {
                            sw.Reset();
                            sw.Start();
                        }
                        check = false;
                    }
                }
                //"off" state
                else
                {
                    if (!check)
                    {
                        if (sw.IsRunning)
                        {
                            if (sw.ElapsedMilliseconds < nUD_dot.Value)
                            {
                                Append_morse(".");
                            }
                            else
                            {
                                Append_morse("-");
                            }
                            Append_logging("On Time : " + Convert.ToString(sw.ElapsedMilliseconds) + " ms\n");
                            sw.Reset();
                            sw.Start();
                        }
                        check = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please click the pictureBox again and set the place where from the morse code is captured.");
            }
        }

        private void pBox_preview_MouseDown(object sender, MouseEventArgs e)
        {
            if (VideoDevice != null || ScreenStream != null)
            {
                Bitmap img = (Bitmap)pBox_preview.Image;
                float stretch_X = img.Width / (float)pBox_preview.Width;
                float stretch_Y = img.Height / (float)pBox_preview.Height;
                pt = new Point((int)(e.X * stretch_X), (int)(e.Y * stretch_Y));
                processes += DrawLine;
            }
            else
            {
                if (rButton_Screen.Checked)
                {
                    // get the desktop
                    Rectangle screenArea = Rectangle.Empty;
                    ScreenCapStart sc = new ScreenCapStart();
                    if (sc.ShowDialog() == DialogResult.OK)
                    {
                        screenArea = Rectangle.Union(screenArea, sc.toreturn.Bounds);

                        // create screen capture video source
                        ScreenStream = new ScreenCaptureStream(screenArea);
                        // set NewFrame event handler
                        ScreenStream.NewFrame += new NewFrameEventHandler(Screen_NewFrame);
                        // start the video source
                        ScreenStream.Start();
                        pBox_preview.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    WebcamStart ws = new WebcamStart();
                    if (ws.ShowDialog() == DialogResult.OK)
                    {
                        string moniker = ws.toreturn;
                        if (moniker != null)
                        {
                            VideoDevice = new VideoCaptureDevice(moniker);
                            VideoDevice.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                            VideoDevice.Start();
                            pBox_preview.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
                panel4.Enabled = false;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (line_drawed)
            {
                processes += GetOnOffState;
                btn_Stop.Enabled = true;
                btn_Start.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please click the pictureBox again and set the place where from the morse code is captured.");
            }

        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            check = true;
            sw.Reset();
            sw.Stop();
            processes -= GetOnOffState;
            btn_Stop.Enabled = false;
            btn_Start.Enabled = true;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            check = true;
            sw.Reset();
            sw.Stop();
            rTB_logging.Text = "";
            rTB_morse.Text = "";
            rTB_translated.Text = "";
        }

        public void Append_morse(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(Append_morse), new object[] { value });
                return;
            }
            rTB_morse.Text += value;
        }

        public void Append_logging(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(Append_logging), new object[] { value });
                return;
            }
            rTB_logging.Text += value;
        }

        public void Append_translated(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(Append_translated), new object[] { value });
                return;
            }
            rTB_translated.Text += value;
        }

        private void MorseToString()
        {
            string morse = rTB_morse.Text;
            string temp = "";
            string result = "";
            for (int i = 0; i < morse.Length; i++)
            {
                temp += morse[i];
                if (i == morse.Length - 1 || morse[i + 1] == ' ')
                {
                    result += temp.getchar();
                    temp = "";
                    i++;
                }
                else if (i == morse.Length - 1 || morse[i + 1] == '/')
                {
                    result += temp.getchar();
                    result += " ";
                    temp = "";
                    i++;
                }
            }
            rTB_translated.Text = result;
        }

        private void rTB_morse_TextChanged(object sender, EventArgs e)
        {
            MorseToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credits cred = new Credits();
            cred.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeVideoSource();
            closeScreenSource();
        }
    }
}
