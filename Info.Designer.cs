namespace YT_MOOSIK_v3 {
    partial class Info {
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
            this.InfoClose = new System.Windows.Forms.PictureBox();
            this.InfoTitle = new System.Windows.Forms.Label();
            this.Thumbnail = new System.Windows.Forms.PictureBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Author = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InfoClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoClose
            // 
            this.InfoClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoClose.Image = global::YT_MOOSIK_v3.Properties.Resources.close;
            this.InfoClose.Location = new System.Drawing.Point(574, -1);
            this.InfoClose.Name = "InfoClose";
            this.InfoClose.Size = new System.Drawing.Size(20, 20);
            this.InfoClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.InfoClose.TabIndex = 0;
            this.InfoClose.TabStop = false;
            this.InfoClose.Click += new System.EventHandler(this.InfoClose_Click);
            this.InfoClose.MouseEnter += new System.EventHandler(this.InfoClose_MouseEnter);
            this.InfoClose.MouseLeave += new System.EventHandler(this.InfoClose_MouseLeave);
            // 
            // InfoTitle
            // 
            this.InfoTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoTitle.AutoSize = true;
            this.InfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoTitle.Location = new System.Drawing.Point(247, 3);
            this.InfoTitle.Name = "InfoTitle";
            this.InfoTitle.Size = new System.Drawing.Size(92, 16);
            this.InfoTitle.TabIndex = 2;
            this.InfoTitle.Text = "Placeholder";
            this.InfoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Thumbnail
            // 
            this.Thumbnail.Location = new System.Drawing.Point(12, 46);
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.Size = new System.Drawing.Size(277, 133);
            this.Thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Thumbnail.TabIndex = 3;
            this.Thumbnail.TabStop = false;
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Description.Location = new System.Drawing.Point(295, 46);
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(288, 133);
            this.Description.TabIndex = 4;
            this.Description.Text = "";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(273, 19);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(41, 13);
            this.Author.TabIndex = 5;
            this.Author.Text = "Author:";
            this.Author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(595, 191);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Thumbnail);
            this.Controls.Add(this.InfoTitle);
            this.Controls.Add(this.InfoClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Info";
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.InfoClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox InfoClose;
        private System.Windows.Forms.Label InfoTitle;
        private System.Windows.Forms.PictureBox Thumbnail;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label Author;
    }
}