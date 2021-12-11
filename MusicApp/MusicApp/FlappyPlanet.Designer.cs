
namespace MusicApp
{
    partial class FlappyPlanet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyPlanet));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lb_scoregame = new System.Windows.Forms.Label();
            this.picb_playagain = new System.Windows.Forms.PictureBox();
            this.picb_playgame1 = new System.Windows.Forms.PictureBox();
            this.picb_name = new System.Windows.Forms.PictureBox();
            this.picb_Close_game1 = new System.Windows.Forms.PictureBox();
            this.picb_planet = new System.Windows.Forms.PictureBox();
            this.picb_ground = new System.Windows.Forms.PictureBox();
            this.picb_pipebottom = new System.Windows.Forms.PictureBox();
            this.picb_pipetop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picb_playagain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_playgame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Close_game1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_planet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_pipetop)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // lb_scoregame
            // 
            this.lb_scoregame.AutoSize = true;
            this.lb_scoregame.BackColor = System.Drawing.Color.Moccasin;
            this.lb_scoregame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_scoregame.Location = new System.Drawing.Point(239, 709);
            this.lb_scoregame.Name = "lb_scoregame";
            this.lb_scoregame.Size = new System.Drawing.Size(24, 28);
            this.lb_scoregame.TabIndex = 4;
            this.lb_scoregame.Text = "0";
            // 
            // picb_playagain
            // 
            this.picb_playagain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picb_playagain.Image = global::MusicApp.Properties.Resources.welcome_little_one___2__removebg_preview;
            this.picb_playagain.Location = new System.Drawing.Point(153, 376);
            this.picb_playagain.Name = "picb_playagain";
            this.picb_playagain.Size = new System.Drawing.Size(343, 100);
            this.picb_playagain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_playagain.TabIndex = 8;
            this.picb_playagain.TabStop = false;
            this.picb_playagain.Visible = false;
            this.picb_playagain.Click += new System.EventHandler(this.picb_playagain_Click);
            // 
            // picb_playgame1
            // 
            this.picb_playgame1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picb_playgame1.Image = global::MusicApp.Properties.Resources.welcome_little_one___1__removebg_preview;
            this.picb_playgame1.Location = new System.Drawing.Point(153, 376);
            this.picb_playgame1.Name = "picb_playgame1";
            this.picb_playgame1.Size = new System.Drawing.Size(343, 100);
            this.picb_playgame1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_playgame1.TabIndex = 7;
            this.picb_playgame1.TabStop = false;
            this.picb_playgame1.Click += new System.EventHandler(this.picb_playgame1_Click);
            // 
            // picb_name
            // 
            this.picb_name.Image = global::MusicApp.Properties.Resources.welcome_little_one__removebg_preview;
            this.picb_name.Location = new System.Drawing.Point(153, 0);
            this.picb_name.Name = "picb_name";
            this.picb_name.Size = new System.Drawing.Size(343, 366);
            this.picb_name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_name.TabIndex = 6;
            this.picb_name.TabStop = false;
            // 
            // picb_Close_game1
            // 
            this.picb_Close_game1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_Close_game1.BackColor = System.Drawing.Color.Moccasin;
            this.picb_Close_game1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picb_Close_game1.Image = ((System.Drawing.Image)(resources.GetObject("picb_Close_game1.Image")));
            this.picb_Close_game1.Location = new System.Drawing.Point(12, 700);
            this.picb_Close_game1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picb_Close_game1.Name = "picb_Close_game1";
            this.picb_Close_game1.Size = new System.Drawing.Size(43, 37);
            this.picb_Close_game1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_Close_game1.TabIndex = 5;
            this.picb_Close_game1.TabStop = false;
            this.picb_Close_game1.Click += new System.EventHandler(this.picb_Close_game1_Click);
            // 
            // picb_planet
            // 
            this.picb_planet.Image = global::MusicApp.Properties.Resources.planet_removebg_preview;
            this.picb_planet.Location = new System.Drawing.Point(12, 249);
            this.picb_planet.Name = "picb_planet";
            this.picb_planet.Size = new System.Drawing.Size(100, 92);
            this.picb_planet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_planet.TabIndex = 0;
            this.picb_planet.TabStop = false;
            // 
            // picb_ground
            // 
            this.picb_ground.Image = global::MusicApp.Properties.Resources.ground;
            this.picb_ground.Location = new System.Drawing.Point(-6, 676);
            this.picb_ground.Name = "picb_ground";
            this.picb_ground.Size = new System.Drawing.Size(668, 95);
            this.picb_ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_ground.TabIndex = 3;
            this.picb_ground.TabStop = false;
            // 
            // picb_pipebottom
            // 
            this.picb_pipebottom.Image = global::MusicApp.Properties.Resources.pipe;
            this.picb_pipebottom.Location = new System.Drawing.Point(351, 482);
            this.picb_pipebottom.Name = "picb_pipebottom";
            this.picb_pipebottom.Size = new System.Drawing.Size(131, 235);
            this.picb_pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_pipebottom.TabIndex = 2;
            this.picb_pipebottom.TabStop = false;
            // 
            // picb_pipetop
            // 
            this.picb_pipetop.Image = global::MusicApp.Properties.Resources.pipedown;
            this.picb_pipetop.Location = new System.Drawing.Point(502, -10);
            this.picb_pipetop.Name = "picb_pipetop";
            this.picb_pipetop.Size = new System.Drawing.Size(124, 241);
            this.picb_pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_pipetop.TabIndex = 1;
            this.picb_pipetop.TabStop = false;
            // 
            // FlappyPlanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(638, 746);
            this.Controls.Add(this.picb_playagain);
            this.Controls.Add(this.picb_playgame1);
            this.Controls.Add(this.picb_name);
            this.Controls.Add(this.picb_Close_game1);
            this.Controls.Add(this.picb_planet);
            this.Controls.Add(this.lb_scoregame);
            this.Controls.Add(this.picb_ground);
            this.Controls.Add(this.picb_pipebottom);
            this.Controls.Add(this.picb_pipetop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlappyPlanet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlappyPlanet";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.picb_playagain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_playgame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Close_game1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_planet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_pipetop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picb_planet;
        private System.Windows.Forms.PictureBox picb_pipetop;
        private System.Windows.Forms.PictureBox picb_pipebottom;
        private System.Windows.Forms.PictureBox picb_ground;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lb_scoregame;
        private System.Windows.Forms.PictureBox picb_Close_game1;
        private System.Windows.Forms.PictureBox picb_name;
        private System.Windows.Forms.PictureBox picb_playgame1;
        private System.Windows.Forms.PictureBox picb_playagain;
    }
}