namespace YT_MOOSIK_v3 {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.InputURL = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.SkipButton = new System.Windows.Forms.PictureBox();
            this.PlayPause = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.CurrentThumb = new System.Windows.Forms.PictureBox();
            this.NextThumb = new System.Windows.Forms.PictureBox();
            this.PrevThumb = new System.Windows.Forms.PictureBox();
            this.DragPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkipButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentThumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextThumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrevThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // InputURL
            // 
            this.InputURL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InputURL.Location = new System.Drawing.Point(128, 95);
            this.InputURL.Name = "InputURL";
            this.InputURL.Size = new System.Drawing.Size(399, 20);
            this.InputURL.TabIndex = 0;
            this.InputURL.Text = "https://www.youtube.com/playlist?list=UU5nc_ZtjKW1htCVZVRxlQAQ&playnext=1&index=1" +
    "";
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoadButton.Location = new System.Drawing.Point(533, 95);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(106, 20);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load URL";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Youtube URL:";
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DragPanel.Controls.Add(this.pictureBox1);
            this.DragPanel.Controls.Add(this.label4);
            this.DragPanel.Controls.Add(this.Minimize);
            this.DragPanel.Controls.Add(this.Close);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.Location = new System.Drawing.Point(0, 0);
            this.DragPanel.Margin = new System.Windows.Forms.Padding(10);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(690, 25);
            this.DragPanel.TabIndex = 8;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.DragPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Much Moosik Many Wow v3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.SkipButton);
            this.panel1.Controls.Add(this.PlayPause);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 62);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Version 3";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Youtube Player";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Location = new System.Drawing.Point(45, 25);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(595, 191);
            this.InfoPanel.TabIndex = 13;
            // 
            // BackButton
            // 
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Image = global::YT_MOOSIK_v3.Properties.Resources.back_normal;
            this.BackButton.Location = new System.Drawing.Point(247, 14);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(48, 32);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 14;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // SkipButton
            // 
            this.SkipButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SkipButton.Image = global::YT_MOOSIK_v3.Properties.Resources.skip_normal;
            this.SkipButton.Location = new System.Drawing.Point(394, 14);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(48, 32);
            this.SkipButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SkipButton.TabIndex = 13;
            this.SkipButton.TabStop = false;
            this.SkipButton.Click += new System.EventHandler(this.Skip_Click);
            this.SkipButton.MouseEnter += new System.EventHandler(this.SkipButton_MouseEnter);
            this.SkipButton.MouseLeave += new System.EventHandler(this.SkipButton_MouseLeave);
            // 
            // PlayPause
            // 
            this.PlayPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayPause.Image = global::YT_MOOSIK_v3.Properties.Resources.play_normal;
            this.PlayPause.Location = new System.Drawing.Point(318, 3);
            this.PlayPause.Name = "PlayPause";
            this.PlayPause.Size = new System.Drawing.Size(55, 54);
            this.PlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayPause.TabIndex = 12;
            this.PlayPause.TabStop = false;
            this.PlayPause.Click += new System.EventHandler(this.PlayPause_Click);
            this.PlayPause.MouseEnter += new System.EventHandler(this.PlayPause_MouseEnter);
            this.PlayPause.MouseLeave += new System.EventHandler(this.PlayPause_MouseLeave);
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.BackColor = System.Drawing.Color.RoyalBlue;
            this.Logo.Image = global::YT_MOOSIK_v3.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(627, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(60, 60);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 11;
            this.Logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YT_MOOSIK_v3.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Minimize
            // 
            this.Minimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Image = global::YT_MOOSIK_v3.Properties.Resources.minimize1;
            this.Minimize.Location = new System.Drawing.Point(618, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Minimize.Size = new System.Drawing.Size(35, 25);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Minimize.TabIndex = 1;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // Close
            // 
            this.Close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Image = global::YT_MOOSIK_v3.Properties.Resources.close;
            this.Close.Location = new System.Drawing.Point(655, 0);
            this.Close.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.Close.Name = "Close";
            this.Close.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Close.Size = new System.Drawing.Size(35, 25);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Close.TabIndex = 0;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // CurrentThumb
            // 
            this.CurrentThumb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CurrentThumb.BackColor = System.Drawing.Color.Transparent;
            this.CurrentThumb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentThumb.Location = new System.Drawing.Point(270, 125);
            this.CurrentThumb.Name = "CurrentThumb";
            this.CurrentThumb.Size = new System.Drawing.Size(149, 84);
            this.CurrentThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CurrentThumb.TabIndex = 6;
            this.CurrentThumb.TabStop = false;
            this.CurrentThumb.Click += new System.EventHandler(this.CurrentThumb_Click);
            this.CurrentThumb.MouseEnter += new System.EventHandler(this.CurrentThumb_MouseEnter);
            // 
            // NextThumb
            // 
            this.NextThumb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NextThumb.BackColor = System.Drawing.Color.Transparent;
            this.NextThumb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextThumb.Location = new System.Drawing.Point(335, 133);
            this.NextThumb.Name = "NextThumb";
            this.NextThumb.Size = new System.Drawing.Size(135, 76);
            this.NextThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextThumb.TabIndex = 11;
            this.NextThumb.TabStop = false;
            this.NextThumb.Click += new System.EventHandler(this.NextThumb_Click);
            this.NextThumb.MouseEnter += new System.EventHandler(this.NextThumb_MouseEnter);
            this.NextThumb.MouseLeave += new System.EventHandler(this.NextThumb_MouseLeave);
            // 
            // PrevThumb
            // 
            this.PrevThumb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PrevThumb.BackColor = System.Drawing.Color.Transparent;
            this.PrevThumb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrevThumb.Location = new System.Drawing.Point(220, 133);
            this.PrevThumb.Name = "PrevThumb";
            this.PrevThumb.Size = new System.Drawing.Size(135, 76);
            this.PrevThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PrevThumb.TabIndex = 12;
            this.PrevThumb.TabStop = false;
            this.PrevThumb.Click += new System.EventHandler(this.PrevThumb_Click);
            this.PrevThumb.MouseEnter += new System.EventHandler(this.PrevThumb_MouseEnter);
            this.PrevThumb.MouseLeave += new System.EventHandler(this.PrevThumb_MouseLeave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(690, 277);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.CurrentThumb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.InputURL);
            this.Controls.Add(this.NextThumb);
            this.Controls.Add(this.PrevThumb);
            this.Controls.Add(this.InfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Much Moosik Many Wows v3";
            this.DragPanel.ResumeLayout(false);
            this.DragPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkipButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentThumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextThumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrevThumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputURL;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CurrentThumb;
        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox NextThumb;
        private System.Windows.Forms.PictureBox PrevThumb;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.PictureBox PlayPause;
        private System.Windows.Forms.PictureBox SkipButton;
        private System.Windows.Forms.PictureBox BackButton;
    }
}

