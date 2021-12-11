namespace Shoot_Out_Game_MOO_ICT
{
    partial class shootoutgame
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
            this.components = new System.ComponentModel.Container();
            this.txtAmmo = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.picb_gamename = new System.Windows.Forms.PictureBox();
            this.picb_startgame = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.picb_playagain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picb_gamename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_startgame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_playagain)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.ForeColor = System.Drawing.Color.White;
            this.txtAmmo.Location = new System.Drawing.Point(17, 16);
            this.txtAmmo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(114, 29);
            this.txtAmmo.TabIndex = 0;
            this.txtAmmo.Text = "Ammo: 0";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(491, 16);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(92, 29);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Kills: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(857, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health: ";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(967, 16);
            this.healthBar.Margin = new System.Windows.Forms.Padding(4);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(249, 28);
            this.healthBar.TabIndex = 1;
            this.healthBar.Value = 100;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // picb_gamename
            // 
            this.picb_gamename.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picb_gamename.Image = global::MusicApp.Properties.Resources.welcome_little_one___3__removebg_preview;
            this.picb_gamename.Location = new System.Drawing.Point(442, 63);
            this.picb_gamename.Name = "picb_gamename";
            this.picb_gamename.Size = new System.Drawing.Size(517, 386);
            this.picb_gamename.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_gamename.TabIndex = 4;
            this.picb_gamename.TabStop = false;
            // 
            // picb_startgame
            // 
            this.picb_startgame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picb_startgame.Image = global::MusicApp.Properties.Resources.welcome_little_one___1__removebg_preview;
            this.picb_startgame.Location = new System.Drawing.Point(570, 464);
            this.picb_startgame.Name = "picb_startgame";
            this.picb_startgame.Size = new System.Drawing.Size(300, 116);
            this.picb_startgame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_startgame.TabIndex = 3;
            this.picb_startgame.TabStop = false;
            this.picb_startgame.Click += new System.EventHandler(this.picb_startgame_Click);
            // 
            // player
            // 
            this.player.Image = global::MusicApp.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(289, 307);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // picb_playagain
            // 
            this.picb_playagain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picb_playagain.Image = global::MusicApp.Properties.Resources.welcome_little_one___2__removebg_preview;
            this.picb_playagain.Location = new System.Drawing.Point(524, 285);
            this.picb_playagain.Name = "picb_playagain";
            this.picb_playagain.Size = new System.Drawing.Size(372, 142);
            this.picb_playagain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_playagain.TabIndex = 5;
            this.picb_playagain.TabStop = false;
            this.picb_playagain.Visible = false;
            this.picb_playagain.Click += new System.EventHandler(this.picb_playagain_Click);
            // 
            // shootoutgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1342, 653);
            this.Controls.Add(this.picb_playagain);
            this.Controls.Add(this.picb_gamename);
            this.Controls.Add(this.picb_startgame);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAmmo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "shootoutgame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zombie Shootout Game ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picb_gamename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_startgame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_playagain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox picb_startgame;
        private System.Windows.Forms.PictureBox picb_gamename;
        private System.Windows.Forms.PictureBox picb_playagain;
    }
}

