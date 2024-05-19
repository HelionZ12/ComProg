using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunBlitz
{
    public partial class Tutorial_lvl_2 : Form
    {
        //PlayerMovement
        bool goLeft, goRight, Jump, hasGun, interact, GameOver, CompleteObj,reload;

        //Player
        string Direction = "right";
        int jumpSpeed = 5;
        int force = 8;
        int PlayerSpeed = 10;
        int playerHealth = 100;
        int totalKills;
        int ammo;

        //LavaThings
        int lavaSpeed = 11;
        int lavaSpeed2 = 8;

        //Platform
        int verticalspeed = 1;

        //Enemy
        int EnemyDamage = 5;
        int TutorialEnSpeed = 1;
        int TutorialEnSpeed2 = 1;
        int TutorialEnSpeed3 = 1;
        int TutorialEnSpeed4 = 1;
        int TutorialEnSpeed5 = 1;
        int TutorialEnSpeed6 = 1;
        public Tutorial_lvl_2()
        {
            InitializeComponent();
        }

        private void MainEventTimer(object sender, EventArgs e)
        {
            //player
            if (playerHealth > 1)
            {
                HealthBar.Value = playerHealth;
            }
            player.Visible = true;
            //Player Movement
            player.Top += jumpSpeed;
            if (goLeft == true && player.Left > 0)
            {
                player.Left -= PlayerSpeed;
            }

            if (goRight == true && player.Left + (player.Width + 0) < this.ClientSize.Width)
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
                jumpSpeed = 14;
            }
            if (Jump == true && force == 0)
            {
                Jump = false;
            }
            //GunPlay


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
                }


                //Moving Platform
                if (player.Bounds.IntersectsWith(verticalPlatform.Bounds) && Jump == false)
                {
                    verticalPlatform.Top += verticalspeed;
                    if (verticalPlatform.Top < 320 || verticalPlatform.Top > 788)
                    {
                        verticalspeed = -verticalspeed;
                    }
                }
                if (player.Bounds.IntersectsWith(Button1.Bounds) && interact == true)
                {
                    verticalPlatform.Top += verticalspeed;
                    if (verticalPlatform.Top < 320 || verticalPlatform.Top > 788)
                    {
                        verticalspeed = -verticalspeed;
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
                        playerHealth = -EnemyDamage;
                        
                    }
                    if (player.Bounds.IntersectsWith(x.Bounds)&& hasGun == false)
                    {
                        GameTimer.Stop();
                        MessageBox.Show("You have no means for defending yourself maybe try getting the gun at the top of the level!");
                    }
                }
                //Enemy
                TutorialEn.Left -= TutorialEnSpeed;
                if (TutorialEn.Left < EnPatrol.Left || TutorialEn.Left + TutorialEn.Width > EnPatrol.Left + EnPatrol.Width)
                {
                    TutorialEnSpeed = -TutorialEnSpeed;
                }
                TutorialEn2.Left -= TutorialEnSpeed2;
                if (TutorialEn2.Left < EnPatrol2.Left || TutorialEn2.Left + TutorialEn2.Width > EnPatrol2.Left + EnPatrol2.Width)
                {
                    TutorialEnSpeed2 = -TutorialEnSpeed2;
                }
                TutorialEn3.Left -= TutorialEnSpeed3;
                if (TutorialEn3.Left < EnPatrol4.Left || TutorialEn3.Left + TutorialEn3.Width > EnPatrol4.Left + EnPatrol4.Width)
                {
                    TutorialEnSpeed3 = -TutorialEnSpeed3;
                }
                TutorialEn4.Left -= TutorialEnSpeed4;
                if (TutorialEn4.Left < EnPatrol3.Left || TutorialEn4.Left + TutorialEn4.Width > EnPatrol3.Left + EnPatrol3.Width)
                {
                    TutorialEnSpeed4 = -TutorialEnSpeed4;
                }
                TutorialEn5.Left -= TutorialEnSpeed5;
                if (TutorialEn5.Left < EnPatrol5.Left || TutorialEn5.Left + TutorialEn5.Width > EnPatrol5.Left + EnPatrol5.Width)
                {
                    TutorialEnSpeed5 = -TutorialEnSpeed5;
                }


            }

            //Objective and Interactable
            if (player.Bounds.IntersectsWith(Gun.Bounds)&& hasGun == false)
            {
                Gun.Visible = false;
                hasGun = true;
                HealthBar.Visible = true;
                HealthBar2.Visible = true;
                ammo1.Visible = true; 
                ammo2.Visible = true;
                ammo = 5;
            }
            ammo1.Text = "Ammo : " + ammo;

            if (totalKills == 5)
            {
                CompleteObj = true;
            }
            else
            {
                CompleteObj = false;
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
                Direction = "jump";
            }
            if (e.KeyCode == Keys.Space && hasGun == true && reload == false && ammo > 0)
            {
                reload = true;
                ShootGun(Direction);
                ammo--;
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
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (Jump == true)
            {
                Jump = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                reload = false;
            }
            if (e.KeyCode == Keys.F)
            {
                interact = false;
            }
        }

        private void Restart()
        {
            Tutorial_lvl_2 newWindow = new Tutorial_lvl_2();
            newWindow.Show();
            this.Close();
        }
        private void ShootGun(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }
        private void Tutorial_lvl_2_Load(object sender, EventArgs e)
        {

        }
    }
}
