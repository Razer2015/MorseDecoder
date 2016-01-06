using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MorseCodeDecoder
{
    public partial class Input_dialog : Form
    {
        public Input_dialog()
        {
            InitializeComponent();
        }

        public String Result = "";

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Result = tBox_input.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
