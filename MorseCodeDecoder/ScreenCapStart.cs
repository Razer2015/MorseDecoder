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
    public partial class ScreenCapStart : Form
    {
        private Screen[] screens;
        public Screen toreturn = null;
        public ScreenCapStart()
        {
            InitializeComponent();
        }

        private void ScreenCapStart_Load(object sender, EventArgs e)
        {
            screens = System.Windows.Forms.Screen.AllScreens;
            if (screens != null)
            {
                foreach (Screen screen in screens)
                {
                    comboBox1.Items.Add(screen.DeviceName);
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
            if (screens.Length != 0)
            {
                toreturn = screens[comboBox1.SelectedIndex];
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
