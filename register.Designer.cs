
namespace MusicPlayerApp
{
    partial class register
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
            this.picb_exitregister = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picb_exitregister)).BeginInit();
            this.SuspendLayout();
            // 
            // picb_exitregister
            // 
            this.picb_exitregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picb_exitregister.Image = global::MusicPlayerApp.Properties.Resources._8394220_log_out_exit_icon;
            this.picb_exitregister.Location = new System.Drawing.Point(1215, 1);
            this.picb_exitregister.Name = "picb_exitregister";
            this.picb_exitregister.Size = new System.Drawing.Size(45, 44);
            this.picb_exitregister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_exitregister.TabIndex = 13;
            this.picb_exitregister.TabStop = false;
            this.picb_exitregister.Click += new System.EventHandler(this.picb_exitregister_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 697);
            this.Controls.Add(this.picb_exitregister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            ((System.ComponentModel.ISupportInitialize)(this.picb_exitregister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picb_exitregister;
    }
}