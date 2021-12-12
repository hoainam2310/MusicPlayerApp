using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicApp;

namespace Shoot_Out_Game_MOO_ICT
{
    public partial class shootoutgame : Form
    {

        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int zombieSpeed = 3;
        Random randNum = new Random();
        int score;
        List<PictureBox> zombiesList = new List<PictureBox>();

        bool play = false;



        public shootoutgame()
        {
            InitializeComponent();
            RestartGame();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if(play == true)
            {
                if (playerHealth > 1)
                {
                    healthBar.Value = playerHealth;
                }
                else
                {
                    gameOver = true;
                    player.Image = global::MusicApp.Properties.Resources.dead;
                    GameTimer.Stop();
                    picb_playagain.Visible = true;
                }

                txtAmmo.Text = "Ammo: " + ammo;
                txtScore.Text = "Kills: " + score;

                if (goLeft == true && player.Left > 0)
                {
                    player.Left -= speed;
                }
                if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
                {
                    player.Left += speed;
                }
                if (goUp == true && player.Top > 45)
                {
                    player.Top -= speed;
                }
                if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
                {
                    player.Top += speed;
                }



                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "ammo")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            ammo += 5;

                        }
                    }


                    if (x is PictureBox && (string)x.Tag == "zombie")
                    {

                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            playerHealth -= 1;
                        }


                        if (x.Left > player.Left)
                        {
                            x.Left -= zombieSpeed;
                            ((PictureBox)x).Image = global::MusicApp.Properties.Resources.zleft;
                        }
                        if (x.Left < player.Left)
                        {
                            x.Left += zombieSpeed;
                            ((PictureBox)x).Image = global::MusicApp.Properties.Resources.zright;
                        }
                        if (x.Top > player.Top)
                        {
                            x.Top -= zombieSpeed;
                            ((PictureBox)x).Image = global::MusicApp.Properties.Resources.zup;
                        }
                        if (x.Top < player.Top)
                        {
                            x.Top += zombieSpeed;
                            ((PictureBox)x).Image = global::MusicApp.Properties.Resources.zdown;
                        }

                    }



                    foreach (Control j in this.Controls)
                    {
                        if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                        {
                            if (x.Bounds.IntersectsWith(j.Bounds))
                            {
                                score++;

                                this.Controls.Remove(j);
                                ((PictureBox)j).Dispose();
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                zombiesList.Remove(((PictureBox)x));
                                MakeZombies();
                            }
                        }
                    }
                }    
            


            }


        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = global::MusicApp.Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = global::MusicApp.Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = global::MusicApp.Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = global::MusicApp.Properties.Resources.down;
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

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);


                if (ammo < 1)
                {
                    DropAmmo();
                }
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }

        }

        private void picb_startgame_Click(object sender, EventArgs e)
        {
            lbl_instruction.Visible = false;
            play = true;
            picb_startgame.Visible = false;
            picb_gamename.Visible = false;
        }

        private void picb_playagain_Click(object sender, EventArgs e)
        {
            RestartGame();
            picb_playagain.Visible = false;
        }

        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = global::MusicApp.Properties.Resources.zdown;
            zombie.Left = randNum.Next(0, 900);
            zombie.Top = randNum.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombiesList.Add(zombie);
            this.Controls.Add(zombie);
            player.BringToFront();

        }

        private void DropAmmo()
        {

            PictureBox ammo = new PictureBox();
            ammo.Image = global::MusicApp.Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);

            ammo.BringToFront();
            player.BringToFront();



        }

        private void RestartGame()
        {
            player.Image = global::MusicApp.Properties.Resources.up;

            foreach (PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }

            zombiesList.Clear();

            for (int i = 0; i < 3; i++)
            {
                MakeZombies();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;

            GameTimer.Start();
        }

    }
}
