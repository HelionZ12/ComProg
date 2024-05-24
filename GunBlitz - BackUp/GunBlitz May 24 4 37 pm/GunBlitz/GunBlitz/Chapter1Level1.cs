using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunBlitz
{
    public partial class Chapter1Level1 : Form
    {
        //SoundEffects
        SoundPlayer JumpSfx;

        //PlayerMovement
        bool goLeft, goRight, Jump, hasKey, interact, GameOver, BreakerStatus = true;

        //Player
        string Direction = "right";
        int jumpSpeed = 5;
        int force = 8;
        int PlayerSpeed = 10;
        int playerHealth = 100;

        //Platform
        int verticalspeed = 1;
        int verticalspeed2 = 1;

        //Enemy
        int EnSpeed1 = 5;
        int EnSpeed2 = 3;

        public Chapter1Level1()
        {
            InitializeComponent();
            JumpSfx = new SoundPlayer("PlayerJump.wav");
        }

        private void Chapter1Level1_Load(object sender, EventArgs e)
        {

        }

        private void MainEventTimer(object sender, EventArgs e)
        {
            //goal
            if (player.Bounds.IntersectsWith(Exit.Bounds))
            {
                GoToNextLvl();
            }
            //PlayerAnimation
            if (goLeft == true && Jump == true)
            {
                player.Image = Properties.Resources.PlayerJumpLeft;
            }
            if (goRight == true && Jump == true)
            {
                player.Image = Properties.Resources.PlayerJumpRight;
            }
            if (goLeft == true && Jump == false)
            {
                player.Image = Properties.Resources.RunLeft;
            }
            if (goRight == true && Jump == false)
            {
                player.Image = Properties.Resources.RunRight;
            }
            //Player Movement
            player.Top += jumpSpeed;
            if (goLeft == true && player.Left > 10)
            {
                player.Left -= PlayerSpeed;
            }

            if (goRight == true && player.Left + (player.Width + 10) < this.ClientSize.Width)
            {
                player.Left += PlayerSpeed;
            }
            if (Jump == true && force < 0)
            {
                Jump = false;
            }
            if (Jump == true)
            {
                jumpSpeed = -10;
                force -= 1;
            }
            else
            {
                jumpSpeed = 15;
            }
            if (Jump == true && force == 0)
            {
                Jump = false;

            }
            //Platform
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && Jump == false)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                        jumpSpeed = 0;
                    }
                    //Moving Platform
                    if (player.Bounds.IntersectsWith(verticalPlatform.Bounds) && Jump == false)
                    {
                        verticalPlatform.Top += verticalspeed;
                        if (verticalPlatform.Top < 367 || verticalPlatform.Top > 500)
                        {
                            verticalspeed = -verticalspeed;
                        }
                    }
                    if (player.Bounds.IntersectsWith(Button1.Bounds) && interact == true)
                    {
                        verticalPlatform.Top += verticalspeed;
                        if (verticalPlatform.Top < 367 || verticalPlatform.Top > 500)
                        {
                            verticalspeed = -verticalspeed;
                        }
                    }
                    if (player.Bounds.IntersectsWith(verticalPlatform2.Bounds) && Jump == false)
                    {
                        verticalPlatform2.Top += verticalspeed2;
                        if (verticalPlatform2.Top < 518 || verticalPlatform2.Top > 788)
                        {
                            verticalspeed2 = -verticalspeed2;
                        }
                    }
                    if (player.Bounds.IntersectsWith(Button2.Bounds) && interact == true)
                    {
                        verticalPlatform2.Top += verticalspeed2;
                        if (verticalPlatform2.Top < 518 || verticalPlatform2.Top > 788)
                        {
                            verticalspeed2 = -verticalspeed2;
                        }
                    }
                }
  
            }
            //Enemy
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop();
                        MessageBox.Show("You have been killed by the Enemy");
                        Restart();
                    }
                }
            }
            En1.Left -= EnSpeed1;
            if (En1.Left < EnPatrol1.Left || En1.Left + En1.Width > EnPatrol1.Left + EnPatrol1.Width)
            {
                EnSpeed1 = -EnSpeed1;
            }
            En2.Left -= EnSpeed2;
            if (En2.Left < EnPatrol2.Left || En2.Left + En2.Width > EnPatrol2.Left + EnPatrol2.Width)
            {
                EnSpeed2 = -EnSpeed2;
            }

            //Dialogue
            if (player.Bounds.IntersectsWith(C.Bounds))
            {
                C1.Visible = true;
            }
            if (player.Bounds.IntersectsWith(D.Bounds)&& C1.Visible == true)
            {
                C1.Visible = false;
                D1.Visible = true;
            }
            if (player.Bounds.IntersectsWith(E.Bounds) && D1.Visible == true)
            {
                D1.Visible = false;
                E1.Visible = true;
                E2.Visible = true;
            }
            if (player.Bounds.IntersectsWith(Dialogue.Bounds) && Float1.Visible == true && BreakerStatus == true)
            {
                Float1.Visible = false;
                lable.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                E1.Visible = false;
                E2.Visible = false;
            }
            if (player.Bounds.IntersectsWith(Dialogue2.Bounds) && label1.Visible == true)
            {
                lable.Visible = false;
                label3.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
            }
            if (player.Bounds.IntersectsWith(Float2.Bounds) && label3.Visible == true)
            {
                label4.Visible = true;
                label3.Visible = false;
            }
            if (player.Bounds.IntersectsWith(b.Bounds) && label4.Visible == true)
            {
                label5.Visible = true;
                label4.Visible = false;
            }
            if (player.Bounds.IntersectsWith(a.Bounds))
            {
                label6.Visible = false;
            }
            if (player.Bounds.IntersectsWith(f.Bounds) && label7.Visible == true)
            {
                label7.Visible = false;
            }
            //Key and door
            if (player.Bounds.IntersectsWith(Key.Bounds) && hasKey == false) 
            {
                hasKey = true;
                Key.Visible = false;
                label7.Visible = true;
            }
            if (player.Bounds.IntersectsWith(Door1.Bounds) && hasKey == false)
            {
                player.Left -= 10;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "WallLeft")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        player.Left -= 10;   
                    }
                }
                if (x is PictureBox && (string)x.Tag == "WallRight")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        player.Left += 10;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "WallBot")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        player.Top += 10;

                    }

                }


            }
            //Breaker
            if (player.Bounds.IntersectsWith(Breaker.Bounds) && interact == true && BreakerStatus == true)
            {
                BreakerStatus = false;
                label6.Visible = true;
            }

            if (BreakerStatus == false)
            {
                label4.Visible = false;
                label5.Visible = false;
                
                this.Controls.Remove(LaserWall);
                ((PictureBox)LaserWall).Dispose();    
            }
            if (BreakerStatus == true)
            {
                LaserWall.Visible = true;
            }

            //LaserWall
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Laser")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && Jump == false)
                    {
                        GameTimer.Stop();
                        MessageBox.Show("You have been killed by The Laser Wall");
                        Restart();

                    }
                }


            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
                Direction = "left";

            }
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
                Direction = "right";
            }
            if (e.KeyCode == Keys.W && Jump == false)
            {
                Jump = true;
                JumpSfx.Play();
            }
            if (e.KeyCode == Keys.F)
            {
                interact = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                player.Image = Properties.Resources.IdleInGameLeft;
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                player.Image = Properties.Resources.IdleInGame;
                goRight = false;
            }
            if (Jump == true)
            {
                Jump = false;
                if (Direction == "left")
                {
                    player.Image = Properties.Resources.IdleInGameLeft;
                }
                if (Direction == "right")
                {
                    player.Image = Properties.Resources.IdleInGame;
                }
            }
            if (e.KeyCode == Keys.F)
            {
                interact = false;
            }
        }
        private void Restart()
        {
            Chapter1Level1 newWindow = new Chapter1Level1();
            newWindow.Show();
            this.Close();
        }
        private void GoToNextLvl()
        {
            MainMenu newWindow = new MainMenu();
            newWindow.Show();
            this.Close();
        }
    }
    }

