
namespace MusicApp
{
    partial class SaveTheEggs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveTheEggs));
            this.txtScore = new System.Windows.Forms.Label();
            this.txtMiss = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_gameover = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_instruction = new System.Windows.Forms.Label();
            this.picb_title = new System.Windows.Forms.PictureBox();
            this.picb_playgame1 = new System.Windows.Forms.PictureBox();
            this.picb_playagain = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picb_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_playgame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_playagain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(-1, 0);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(114, 29);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Saved: 0";
            // 
            // txtMiss
            // 
            this.txtMiss.AutoSize = true;
            this.txtMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiss.Location = new System.Drawing.Point(575, 0);
            this.txtMiss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMiss.Name = "txtMiss";
            this.txtMiss.Size = new System.Drawing.Size(125, 29);
            this.txtMiss.TabIndex = 5;
            this.txtMiss.Text = "Missed: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimeEvent);
            // 
            // lbl_gameover
            // 
            this.lbl_gameover.AutoSize = true;
            this.lbl_gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameover.Location = new System.Drawing.Point(275, 502);
            this.lbl_gameover.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gameover.Name = "lbl_gameover";
            this.lbl_gameover.Size = new System.Drawing.Size(159, 29);
            this.lbl_gameover.TabIndex = 11;
            this.lbl_gameover.Text = "Game Over !";
            this.lbl_gameover.Visible = false;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(269, 566);
            this.lbl_score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(159, 29);
            this.lbl_score.TabIndex = 12;
            this.lbl_score.Text = "Game Over !";
            this.lbl_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_score.Visible = false;
            // 
            // lbl_instruction
            // 
            this.lbl_instruction.AutoSize = true;
            this.lbl_instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instruction.Location = new System.Drawing.Point(15, 417);
            this.lbl_instruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_instruction.Name = "lbl_instruction";
            this.lbl_instruction.Size = new System.Drawing.Size(627, 24);
            this.lbl_instruction.TabIndex = 14;
            this.lbl_instruction.Text = "Use LEFT and RIGHT arrow key to collect eggs from falling down !";
            this.lbl_instruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_instruction.UseWaitCursor = true;
            this.lbl_instruction.Visible = false;
            // 
            // picb_title
            // 
            this.picb_title.Image = global::MusicApp.Properties.Resources.saveeggs;
            this.picb_title.Location = new System.Drawing.Point(124, 294);
            this.picb_title.Margin = new System.Windows.Forms.Padding(4);
            this.picb_title.Name = "picb_title";
            this.picb_title.Size = new System.Drawing.Size(451, 106);
            this.picb_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_title.TabIndex = 13;
            this.picb_title.TabStop = false;
            // 
            // picb_playgame1
            // 
            this.picb_playgame1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picb_playgame1.Image = global::MusicApp.Properties.Resources.welcome_little_one___1__removebg_preview;
            this.picb_playgame1.Location = new System.Drawing.Point(187, 640);
            this.picb_playgame1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picb_playgame1.Name = "picb_playgame1";
            this.picb_playgame1.Size = new System.Drawing.Size(343, 100);
            this.picb_playgame1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_playgame1.TabIndex = 10;
            this.picb_playgame1.TabStop = false;
            this.picb_playgame1.Click += new System.EventHandler(this.picb_playgame1_Click);
            // 
            // picb_playagain
            // 
            this.picb_playagain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picb_playagain.Image = global::MusicApp.Properties.Resources.welcome_little_one___2__removebg_preview;
            this.picb_playagain.Location = new System.Drawing.Point(187, 640);
            this.picb_playagain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picb_playagain.Name = "picb_playagain";
            this.picb_playagain.Size = new System.Drawing.Size(343, 100);
            this.picb_playagain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_playagain.TabIndex = 9;
            this.picb_playagain.TabStop = false;
            this.picb_playagain.Visible = false;
            this.picb_playagain.Click += new System.EventHandler(this.picb_playagain_Click);
            // 
            // player
            // 
            this.player.Image = global::MusicApp.Properties.Resources.chicken_normal;
            this.player.Location = new System.Drawing.Point(308, 759);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(120, 87);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::MusicApp.Properties.Resources.egg;
            this.pictureBox3.Location = new System.Drawing.Point(540, 128);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "eggs";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::MusicApp.Properties.Resources.egg;
            this.pictureBox2.Location = new System.Drawing.Point(308, 128);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "eggs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::MusicApp.Properties.Resources.egg;
            this.pictureBox1.Location = new System.Drawing.Point(64, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "eggs";
            // 
            // SaveTheEggs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 892);
            this.Controls.Add(this.lbl_instruction);
            this.Controls.Add(this.picb_title);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_gameover);
            this.Controls.Add(this.picb_playgame1);
            this.Controls.Add(this.picb_playagain);
            this.Controls.Add(this.txtMiss);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveTheEggs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveTheEggs";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picb_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_playgame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_playagain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtMiss;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox picb_playagain;
        private System.Windows.Forms.PictureBox picb_playgame1;
        private System.Windows.Forms.Label lbl_gameover;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.PictureBox picb_title;
        private System.Windows.Forms.Label lbl_instruction;
    }
}