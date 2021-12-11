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
    public partial class FlappyPlanet : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;

        bool play = false;

        public FlappyPlanet()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if(play == true)
            {
                picb_planet.Top += gravity;
                picb_pipetop.Left -= pipeSpeed;
                picb_pipebottom.Left -= pipeSpeed;
                lb_scoregame.Text = "Score: " + score;

                if (picb_pipetop.Left < -180)
                {
                    picb_pipetop.Left = 950;
                    score++;
                }
                if (picb_pipebottom.Left < -150)
                {
                    picb_pipebottom.Left = 800;
                    score++;
                }

                if (picb_planet.Bounds.IntersectsWith(picb_pipebottom.Bounds) ||
                    picb_planet.Bounds.IntersectsWith(picb_pipetop.Bounds) ||
                    picb_planet.Bounds.IntersectsWith(picb_ground.Bounds) ||
                    picb_planet.Top < -25)
                {
                    endGame();
                }

                if (score > 5)
                {
                    pipeSpeed = 10;
                }
                if (score > 10)
                {
                    pipeSpeed = 12;
                }
                if (score > 15)
                {
                    pipeSpeed = 14;
                }
                if (score > 20)
                {
                    pipeSpeed = 16;
                }
                if (score > 25)
                {
                    pipeSpeed = 18;
                }
                if (score > 30)
                {
                    pipeSpeed = 20;
                }
                if (score > 35)
                {
                    pipeSpeed = 22;
                }
                if (score > 40)
                {
                    pipeSpeed = 24;
                }
                if (score > 45)
                {
                    pipeSpeed = 26;
                }
                if (score > 50)
                {
                    pipeSpeed = 28;
                }
                if (score > 55)
                {
                    pipeSpeed = 30;
                }
                if (score > 60)
                {
                    pipeSpeed = 32;
                }
            }


        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }    
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            lb_scoregame.Text += " Game over!!!";
            play = false;
            picb_playagain.Visible = true;
        }

        private void picb_Close_game1_Click(object sender, EventArgs e)
        {
            picb_playagain.Visible = true;

            this.Close();
        }

        private void picb_playgame1_Click(object sender, EventArgs e)
        {
            play = true;
            picb_name.Visible = false;
            picb_playgame1.Visible = false;
        }

        private void picb_playagain_Click(object sender, EventArgs e)
        {
            pipeSpeed = 8;
            gravity = 5;
            score = 0;

            picb_playagain.Visible = false;
            play = true;

            picb_planet.Location = new System.Drawing.Point(12, 249);

            gameTimer.Start();


        }

    }
}
