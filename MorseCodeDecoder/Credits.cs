using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MorseCodeDecoder
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void Credits_Load(object sender, EventArgs e)
        {
            // Add a link to the LinkLabel.
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://battlelog.battlefield.com/bf4/user/xfileFIN/";
            lLabel_xfilefin.Links.Add(link);

            // Add a link to the LinkLabel.
            LinkLabel.Link link2 = new LinkLabel.Link();
            link2.LinkData = "http://www.codeproject.com/Articles/46174/Computer-Vision-Decoding-a-Morse-Code-Flashing-LED";
            linkLabel1.Links.Add(link2);

            // Add a link to the LinkLabel.
            LinkLabel.Link link3 = new LinkLabel.Link();
            link3.LinkData = "https://www.youtube.com/watch?v=B2ave3cT0ZY";
            linkLabel2.Links.Add(link3);
        }

        private void lLabel_xfilefin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            Process.Start(e.Link.LinkData as string);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            Process.Start(e.Link.LinkData as string);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            Process.Start(e.Link.LinkData as string);
        }
    }
}
