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
        //Sign
        bool Touch1;
        //LavaThings
        int lavaSpeed = 11;
        int lavaSpeed2 = 8;

        //Platform
        int verticalspeed = 1;

        //Enemy
        bool EnAlive = false, EnAlive2 = false, EnAlive3 = false, EnAlive4 = false;
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
            if (playerHealth == 0)
            {
                GameTimer.Stop();
                MessageBox.Show("You Have Been Defeated!");

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
            //Sign
            if (player.Bounds.IntersectsWith(Sign1.Bounds) && Touch1 == false)
            {
                Touch1 = true;
            }

            //Sign True
            if (Touch1 == true)
            {
                Guide1.Visible = true;
                Guide2.Visible = true;
                Guide3.Visible = true;
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
                        if (verticalPlatform.Top < 202 || verticalPlatform.Top > 788)
                        {
                            verticalspeed = -verticalspeed;
                        }
                    }
                    if (player.Bounds.IntersectsWith(Button1.Bounds) && interact == true)
                    {
                        verticalPlatform.Top += verticalspeed;
                        if (verticalPlatform.Top < 202 || verticalPlatform.Top > 788)
                        {
                            verticalspeed = -verticalspeed;
                        }
                    }
                }
            }

            //Enemy
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Enemy")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && hasGun == true)
                    {
                        playerHealth -= 5;

                    }
                    if (player.Bounds.IntersectsWith(x.Bounds) && hasGun == false)
                    {
                        GameTimer.Stop();
                        MessageBox.Show("GreatJob You Finished Tutorial lvl -2!");
                    }
                }
            }
            TutorialEn.Left -= TutorialEnSpeed;
            if (TutorialEn.Left < EnPatrol.Left || TutorialEn.Left + TutorialEn.Width > EnPatrol.Left + EnPatrol.Width)
            {
                TutorialEnSpeed = -TutorialEnSpeed;
            }

            //Objective and Interactable
            if (player.Bounds.IntersectsWith(Gun.Bounds) && hasGun == false)
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
            if (CompleteObj == true)
            {
                Door.Image = Properties.Resources.door_open;
            }
            if (totalKills == 4)
            {
                CompleteObj = true;
            }
            if (player.Bounds.IntersectsWith(Door.Bounds) && CompleteObj == true) 
            {
                GameTimer.Stop();
                MessageBox.Show("Thank you for Playing");
            }
            //Kill Enemy

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
            }
            if (e.KeyCode == Keys.Space && hasGun == true && reload == false && ammo > 0)
            {
                reload = true;
                ShootGun(Direction);
                ammo--;
            }
            if (e.KeyCode == Keys.R && hasGun && ammo == 0)
            {
                ammo = 5;
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
        private void  Tutorial_lvl_2_Load (object sender, EventArgs e)
        {

        }
    }
}
