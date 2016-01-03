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

namespace MorseCodeDecoder
{
    public partial class WebcamStart : Form
    {
        private FilterInfoCollection videoDevices;
        public string toreturn = null;
        public WebcamStart()
        {
            InitializeComponent();
        }

        private void WebcamStart_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices != null)
            {
                foreach (FilterInfo videoDevice in videoDevices)
                {
                    comboBox1.Items.Add(videoDevice.Name);
                }
            }
            else
            {
                comboBox1.Items.Add("No Device Available");
            }
            comboBox1.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (videoDevices.Count != 0)
            {
                toreturn = videoDevices[comboBox1.SelectedIndex].MonikerString;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toreturn = null;
            this.Close();
        }

    }
}
