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
        public FlappyPlanet()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            picb_planet.Top += gravity;
            picb_pipetop.Left -= pipeSpeed;
            picb_pipebottom.Left -= pipeSpeed;
            lb_scoregame.Text = "Score: " + score; 

            if(picb_pipetop.Left < -180)
            {
                picb_pipetop.Left = 950;
                score++;
            }
            if (picb_pipebottom.Left < -150)
            {
                picb_pipebottom.Left = 800;
                score++;
            }

            if(picb_planet.Bounds.IntersectsWith(picb_pipebottom.Bounds) ||
                picb_planet.Bounds.IntersectsWith(picb_pipetop.Bounds) ||
                picb_planet.Bounds.IntersectsWith(picb_ground.Bounds) ||
                picb_planet.Top < -25)
            {
                endGame();
            }    

            if(score > 5)
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
        }
    }
}
