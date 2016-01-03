namespace MorseCodeDecoder
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rButton_WebCam = new System.Windows.Forms.RadioButton();
            this.rButton_Screen = new System.Windows.Forms.RadioButton();
            this.rTB_logging = new System.Windows.Forms.RichTextBox();
            this.pBox_preview = new System.Windows.Forms.PictureBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.rTB_translated = new System.Windows.Forms.RichTextBox();
            this.rTB_morse = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nUD_word = new System.Windows.Forms.NumericUpDown();
            this.nUD_char = new System.Windows.Forms.NumericUpDown();
            this.nUD_dot = new System.Windows.Forms.NumericUpDown();
            this.word_pause_th = new System.Windows.Forms.Label();
            this.char_pause_th = new System.Windows.Forms.Label();
            this.dot_pause_th = new System.Windows.Forms.Label();
            this.brightness_threshold = new System.Windows.Forms.Label();
            this.nUD_brightness = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_preview)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_word)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_char)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_dot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_brightness)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1309, 530);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1301, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Decode Morse Code";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.rTB_logging);
            this.panel1.Controls.Add(this.pBox_preview);
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 498);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rButton_WebCam);
            this.panel4.Controls.Add(this.rButton_Screen);
            this.panel4.Location = new System.Drawing.Point(5, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(442, 24);
            this.panel4.TabIndex = 4;
            // 
            // rButton_WebCam
            // 
            this.rButton_WebCam.AutoSize = true;
            this.rButton_WebCam.Location = new System.Drawing.Point(85, 3);
            this.rButton_WebCam.Name = "rButton_WebCam";
            this.rButton_WebCam.Size = new System.Drawing.Size(69, 17);
            this.rButton_WebCam.TabIndex = 4;
            this.rButton_WebCam.TabStop = true;
            this.rButton_WebCam.Text = "WebCam";
            this.rButton_WebCam.UseVisualStyleBackColor = true;
            // 
            // rButton_Screen
            // 
            this.rButton_Screen.AutoSize = true;
            this.rButton_Screen.Checked = true;
            this.rButton_Screen.Location = new System.Drawing.Point(3, 3);
            this.rButton_Screen.Name = "rButton_Screen";
            this.rButton_Screen.Size = new System.Drawing.Size(76, 17);
            this.rButton_Screen.TabIndex = 3;
            this.rButton_Screen.TabStop = true;
            this.rButton_Screen.Text = "PC Screen";
            this.rButton_Screen.UseVisualStyleBackColor = true;
            // 
            // rTB_logging
            // 
            this.rTB_logging.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTB_logging.Location = new System.Drawing.Point(5, 300);
            this.rTB_logging.Name = "rTB_logging";
            this.rTB_logging.Size = new System.Drawing.Size(442, 193);
            this.rTB_logging.TabIndex = 2;
            this.rTB_logging.Text = "";
            // 
            // pBox_preview
            // 
            this.pBox_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBox_preview.BackColor = System.Drawing.Color.DimGray;
            this.pBox_preview.Location = new System.Drawing.Point(5, 25);
            this.pBox_preview.Name = "pBox_preview";
            this.pBox_preview.Size = new System.Drawing.Size(442, 269);
            this.pBox_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_preview.TabIndex = 1;
            this.pBox_preview.TabStop = false;
            this.pBox_preview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBox_preview_MouseDown);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl2.Location = new System.Drawing.Point(449, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(846, 498);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(838, 472);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Output";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Clear);
            this.panel3.Controls.Add(this.btn_Stop);
            this.panel3.Controls.Add(this.btn_Start);
            this.panel3.Controls.Add(this.rTB_translated);
            this.panel3.Controls.Add(this.rTB_morse);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(832, 466);
            this.panel3.TabIndex = 0;
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Location = new System.Drawing.Point(754, 226);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Stop.Location = new System.Drawing.Point(387, 226);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 3;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Start.Location = new System.Drawing.Point(3, 226);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // rTB_translated
            // 
            this.rTB_translated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTB_translated.Location = new System.Drawing.Point(0, 255);
            this.rTB_translated.Name = "rTB_translated";
            this.rTB_translated.Size = new System.Drawing.Size(832, 211);
            this.rTB_translated.TabIndex = 1;
            this.rTB_translated.Text = "";
            // 
            // rTB_morse
            // 
            this.rTB_morse.Dock = System.Windows.Forms.DockStyle.Top;
            this.rTB_morse.Location = new System.Drawing.Point(0, 0);
            this.rTB_morse.Name = "rTB_morse";
            this.rTB_morse.Size = new System.Drawing.Size(832, 220);
            this.rTB_morse.TabIndex = 0;
            this.rTB_morse.Text = "";
            this.rTB_morse.TextChanged += new System.EventHandler(this.rTB_morse_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(838, 496);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nUD_word);
            this.panel2.Controls.Add(this.nUD_char);
            this.panel2.Controls.Add(this.nUD_dot);
            this.panel2.Controls.Add(this.word_pause_th);
            this.panel2.Controls.Add(this.char_pause_th);
            this.panel2.Controls.Add(this.dot_pause_th);
            this.panel2.Controls.Add(this.brightness_threshold);
            this.panel2.Controls.Add(this.nUD_brightness);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 108);
            this.panel2.TabIndex = 1;
            // 
            // nUD_word
            // 
            this.nUD_word.Location = new System.Drawing.Point(212, 83);
            this.nUD_word.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_word.Name = "nUD_word";
            this.nUD_word.Size = new System.Drawing.Size(120, 20);
            this.nUD_word.TabIndex = 7;
            this.nUD_word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_word.Value = new decimal(new int[] {
            464,
            0,
            0,
            0});
            // 
            // nUD_char
            // 
            this.nUD_char.Location = new System.Drawing.Point(212, 57);
            this.nUD_char.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_char.Name = "nUD_char";
            this.nUD_char.Size = new System.Drawing.Size(120, 20);
            this.nUD_char.TabIndex = 6;
            this.nUD_char.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_char.Value = new decimal(new int[] {
            245,
            0,
            0,
            0});
            // 
            // nUD_dot
            // 
            this.nUD_dot.Location = new System.Drawing.Point(212, 31);
            this.nUD_dot.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_dot.Name = "nUD_dot";
            this.nUD_dot.Size = new System.Drawing.Size(120, 20);
            this.nUD_dot.TabIndex = 5;
            this.nUD_dot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_dot.Value = new decimal(new int[] {
            215,
            0,
            0,
            0});
            // 
            // word_pause_th
            // 
            this.word_pause_th.AutoSize = true;
            this.word_pause_th.Location = new System.Drawing.Point(3, 85);
            this.word_pause_th.Name = "word_pause_th";
            this.word_pause_th.Size = new System.Drawing.Size(181, 13);
            this.word_pause_th.TabIndex = 4;
            this.word_pause_th.Text = "Word Pause Threshold (milliseconds)";
            // 
            // char_pause_th
            // 
            this.char_pause_th.AutoSize = true;
            this.char_pause_th.Location = new System.Drawing.Point(3, 59);
            this.char_pause_th.Name = "char_pause_th";
            this.char_pause_th.Size = new System.Drawing.Size(177, 13);
            this.char_pause_th.TabIndex = 3;
            this.char_pause_th.Text = "Char Pause Threshold (milliseconds)";
            // 
            // dot_pause_th
            // 
            this.dot_pause_th.AutoSize = true;
            this.dot_pause_th.Location = new System.Drawing.Point(3, 33);
            this.dot_pause_th.Name = "dot_pause_th";
            this.dot_pause_th.Size = new System.Drawing.Size(172, 13);
            this.dot_pause_th.TabIndex = 2;
            this.dot_pause_th.Text = "Dot Pause Threshold (milliseconds)";
            // 
            // brightness_threshold
            // 
            this.brightness_threshold.AutoSize = true;
            this.brightness_threshold.Location = new System.Drawing.Point(3, 7);
            this.brightness_threshold.Name = "brightness_threshold";
            this.brightness_threshold.Size = new System.Drawing.Size(106, 13);
            this.brightness_threshold.TabIndex = 1;
            this.brightness_threshold.Text = "Brightness Threshold";
            // 
            // nUD_brightness
            // 
            this.nUD_brightness.Location = new System.Drawing.Point(212, 5);
            this.nUD_brightness.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_brightness.Name = "nUD_brightness";
            this.nUD_brightness.Size = new System.Drawing.Size(120, 20);
            this.nUD_brightness.TabIndex = 0;
            this.nUD_brightness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_brightness.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1309, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Morse Code Decoder (WebCam/Screen)";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_preview)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_word)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_char)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_dot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_brightness)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nUD_word;
        private System.Windows.Forms.NumericUpDown nUD_char;
        private System.Windows.Forms.NumericUpDown nUD_dot;
        private System.Windows.Forms.Label word_pause_th;
        private System.Windows.Forms.Label char_pause_th;
        private System.Windows.Forms.Label dot_pause_th;
        private System.Windows.Forms.Label brightness_threshold;
        private System.Windows.Forms.NumericUpDown nUD_brightness;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.RichTextBox rTB_translated;
        private System.Windows.Forms.RichTextBox rTB_morse;
        private System.Windows.Forms.PictureBox pBox_preview;
        private System.Windows.Forms.RichTextBox rTB_logging;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rButton_WebCam;
        private System.Windows.Forms.RadioButton rButton_Screen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

