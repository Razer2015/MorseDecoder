namespace MorseCodeDecoder
{
    partial class Credits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lLabel_xfilefin = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(306, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Original code where some parts are taken from By Shivam Kalra";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lLabel_xfilefin
            // 
            this.lLabel_xfilefin.AutoSize = true;
            this.lLabel_xfilefin.Location = new System.Drawing.Point(12, 9);
            this.lLabel_xfilefin.Name = "lLabel_xfilefin";
            this.lLabel_xfilefin.Size = new System.Drawing.Size(91, 13);
            this.lLabel_xfilefin.TabIndex = 3;
            this.lLabel_xfilefin.TabStop = true;
            this.lLabel_xfilefin.Text = "Coded By xfileFIN";
            this.lLabel_xfilefin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLabel_xfilefin_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(12, 64);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(292, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Battlefield 4 DICE LA camo easter egg settings By Doc Haxx";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 96);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.lLabel_xfilefin);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Credits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Credits";
            this.Load += new System.EventHandler(this.Credits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lLabel_xfilefin;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}