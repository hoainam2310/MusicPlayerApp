
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
            this.picb_ground = new System.Windows.Forms.PictureBox();
            this.picb_pipebottom = new System.Windows.Forms.PictureBox();
            this.picb_pipetop = new System.Windows.Forms.PictureBox();
            this.picb_planet = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lb_scoregame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_planet)).BeginInit();
            this.SuspendLayout();
            // 
            // picb_ground
            // 
            this.picb_ground.Image = global::MusicApp.Properties.Resources.ground;
            this.picb_ground.Location = new System.Drawing.Point(-10, 394);
            this.picb_ground.Name = "picb_ground";
            this.picb_ground.Size = new System.Drawing.Size(1335, 81);
            this.picb_ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_ground.TabIndex = 3;
            this.picb_ground.TabStop = false;
            // 
            // picb_pipebottom
            // 
            this.picb_pipebottom.Image = global::MusicApp.Properties.Resources.pipe;
            this.picb_pipebottom.Location = new System.Drawing.Point(809, 283);
            this.picb_pipebottom.Name = "picb_pipebottom";
            this.picb_pipebottom.Size = new System.Drawing.Size(66, 130);
            this.picb_pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_pipebottom.TabIndex = 2;
            this.picb_pipebottom.TabStop = false;
            // 
            // picb_pipetop
            // 
            this.picb_pipetop.Image = global::MusicApp.Properties.Resources.pipedown;
            this.picb_pipetop.Location = new System.Drawing.Point(954, -21);
            this.picb_pipetop.Name = "picb_pipetop";
            this.picb_pipetop.Size = new System.Drawing.Size(66, 127);
            this.picb_pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_pipetop.TabIndex = 1;
            this.picb_pipetop.TabStop = false;
            // 
            // picb_planet
            // 
            this.picb_planet.Image = global::MusicApp.Properties.Resources.planet_removebg_preview;
            this.picb_planet.Location = new System.Drawing.Point(32, 12);
            this.picb_planet.Name = "picb_planet";
            this.picb_planet.Size = new System.Drawing.Size(64, 58);
            this.picb_planet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_planet.TabIndex = 0;
            this.picb_planet.TabStop = false;
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
            this.lb_scoregame.Location = new System.Drawing.Point(611, 427);
            this.lb_scoregame.Name = "lb_scoregame";
            this.lb_scoregame.Size = new System.Drawing.Size(24, 28);
            this.lb_scoregame.TabIndex = 4;
            this.lb_scoregame.Text = "0";
            // 
            // FlappyPlanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1266, 473);
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
            ((System.ComponentModel.ISupportInitialize)(this.picb_ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_planet)).EndInit();
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
    }
}