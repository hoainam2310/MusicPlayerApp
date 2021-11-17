
namespace MusicPlayerApp
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.p_sidemenu = new System.Windows.Forms.Panel();
            this.p_logo = new System.Windows.Forms.Panel();
            this.p_user = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p_sidemenu.SuspendLayout();
            this.p_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // p_sidemenu
            // 
            this.p_sidemenu.AutoScroll = true;
            this.p_sidemenu.BackColor = System.Drawing.Color.Black;
            this.p_sidemenu.Controls.Add(this.p_logo);
            this.p_sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_sidemenu.Location = new System.Drawing.Point(0, 0);
            this.p_sidemenu.Name = "p_sidemenu";
            this.p_sidemenu.Size = new System.Drawing.Size(250, 819);
            this.p_sidemenu.TabIndex = 0;
            // 
            // p_logo
            // 
            this.p_logo.Controls.Add(this.pictureBox1);
            this.p_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_logo.Location = new System.Drawing.Point(0, 0);
            this.p_logo.Name = "p_logo";
            this.p_logo.Size = new System.Drawing.Size(250, 125);
            this.p_logo.TabIndex = 1;
            // 
            // p_user
            // 
            this.p_user.Location = new System.Drawing.Point(247, 0);
            this.p_user.Name = "p_user";
            this.p_user.Size = new System.Drawing.Size(1151, 819);
            this.p_user.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 819);
            this.Controls.Add(this.p_user);
            this.Controls.Add(this.p_sidemenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.p_sidemenu.ResumeLayout(false);
            this.p_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_sidemenu;
        private System.Windows.Forms.Panel p_logo;
        private System.Windows.Forms.Panel p_user;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}