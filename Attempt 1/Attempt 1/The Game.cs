using Dont_At_Me_Zombies_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Attempt_1
{
    public partial class The_Game : Form
    {
        bool goLeft, goRight, Jump, hasKey, hasAmmo;
        bool hasGun = false;
        int jumpSpeed = 5;
        int force = 8;
        int score = 0;
        string facing = "right";
        int playerSpeed = 10;
        int backgroundSpeed = 8;
        int ammo = 5;

        public The_Game()
        {
            InitializeComponent();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtAmmo.Visible = false;
            if (hasGun == true)
            {
                txtAmmo.Visible = true;
            }
            /*Movement of Player and Stuff */
            /*txtscore.Text = "Score : " + txtscore;*/
            txtAmmo.Text = "Ammo: " + ammo;
            player.Top += jumpSpeed;
            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }

            if (goRight == true && player.Left + (player.Width + 0) < this.ClientSize.Width)
            {
                player.Left += playerSpeed;
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

                    x.BringToFront();


                }


                /*
                if (x is PictureBox && (string)x.Tag == "coins")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds)&& x.Visible == true)
                    {
                        x.Visible = false;
                        score += 1;
                    }
                }
                */
            }
            if (player.Bounds.IntersectsWith(Key.Bounds))
            {
                Key.Visible = false;
                hasKey = true;
            }

            if (player.Bounds.IntersectsWith(Gun.Bounds))
            {
                Gun.Visible = false;
                hasGun = true;

            }

            if (player.Bounds.IntersectsWith(Door.Bounds) && hasKey == true)
            {
                Door.Image = Properties.Resources.door_open;
                GameTimer.Stop();
                MessageBox.Show("Thank you for Playing");
                GoToMenu();
            }
            if (player.Bounds.IntersectsWith(Lava.Bounds))
            {
                GameTimer.Stop();
                MessageBox.Show("You Died!" + Environment.NewLine + "Click OK to play again");
                GoToMenu();
            }

        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
                facing = "left";
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
                facing = "right";

            }
            if (e.KeyCode == Keys.W && Jump == false)
            {
                Jump = true;
            }

            if (e.KeyCode == Keys.Space && ammo > 0 && hasGun == true)
            {
                ammo--;
                ShootGun(facing);

            }
            if (e.KeyCode == Keys.R && ammo == 0)
            {
                ammo = 5;
            }
            /* For Backgroun Movements
              if (goLeft == true && background.Left <0)
            {
            background.Left += backgroundspeed;
            }
             if (goRight == true && background.Left > insertHowFarBackground)
            {
            background.Left -= backgroundspeed;
            }
             */
        }
        private void ShootGun(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);



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
            if (e.KeyCode == Keys.ShiftKey)
            {
                playerSpeed = 10;
            }
            if (e.KeyCode == Keys.Space)
            {

            }

        }
        private void GoToMenu()
        {
            Menu newWindow = new Menu();
            newWindow.Show();
            this.Hide();
        }


        /* for background 
private void MoveGameElement(string direction)
{

}
*/
    }
}
