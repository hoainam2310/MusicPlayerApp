using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class SaveTheEggs : Form
    {
        bool goLeft, goRight;
        bool play = false;

        int speed = 8;
        int score = 0;
        int missed = 0;

        Random randX = new Random();
        Random randY = new Random();

        PictureBox splash = new PictureBox();
        public SaveTheEggs()
        {
            InitializeComponent();
            RestartGame();
        }

        private void MainGameTimeEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Saved: " + score;
            txtMiss.Text = "Missed: " + missed;

            if(goLeft == true && player.Left >0)
            {
                player.Left -= 12;
                player.Image = Properties.Resources.chicken_normal2;
            }
            if(goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += 12;
                player.Image = Properties.Resources.chicken_normal;
            }
            
            foreach(Control x in this.Controls)
            {
                if(play == true)
                {
                    if (x is PictureBox && (string)x.Tag == "eggs")
                    {
                        x.Top += speed;

                        if (x.Top + x.Height > this.ClientSize.Height)
                        {
                            splash.Image = Properties.Resources.splash;
                            splash.Location = x.Location;
                            splash.Height = 60;
                            splash.Width = 60;
                            splash.BackColor = Color.Transparent;

                            this.Controls.Add(splash);

                            x.Top = randY.Next(80, 300) * -1;
                            x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                            missed += 1;
                            player.Image = Properties.Resources.chicken_hurt;
                        }

                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Top = randY.Next(80, 300) * -1;
                            x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                            score += 1;
                        }
                    }
                }
                
                if(score >10)
                {
                    speed = 12;
                }

                if(missed > 5)
                {
                    GameTimer.Stop();
                    play = false;
                    picb_playagain.Visible = true;
                    lbl_gameover.Visible = true;
                    lbl_score.Text = "You've saved " + score + " !";
                    lbl_score.Visible = true;
                    picb_title.Visible = true;
                    lbl_instruction.Visible = true;
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void picb_playgame1_Click(object sender, EventArgs e)
        {
            play = true;
            picb_playgame1.Visible = false;
            picb_title.Visible = false;
            lbl_instruction.Visible = false;
        }

        private void picb_playagain_Click(object sender, EventArgs e)
        {
            play = true;
            picb_playagain.Visible = false;
            lbl_gameover.Visible = false;
            lbl_score.Visible = false;
            lbl_instruction.Visible = false;
            picb_title.Visible = false;
            RestartGame();
        }

        private void RestartGame()
        {
            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "eggs")
                {
                    x.Top = randY.Next(80, 300) * -1;
                    x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                }
            }

            player.Left = this.ClientSize.Width / 2;
            player.Image = Properties.Resources.chicken_normal;

            score = 0;
            missed = 0;
            speed = 8;

            goLeft = false;
            goRight = false;

            GameTimer.Start();
        }
    }
}
