using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunBlitz
{
    public partial class Tutorial_lvl_1 : Form
    {
        //PlayerMovement
        bool goLeft, goRight, Jump, hasKey, interact, GameOver;
        //Player
        string Direction = "right";
        int jumpSpeed = 5;
        int force = 8;
        int PlayerSpeed = 10;
        int playerHealth = 100;

        //Platform
        int verticalspeed = 2;
        int verticalspeed2 = 1;

        //LavaThings
        int lavaSpeed = 11;
        int lavaSpeed2 = 8;

        //Enemy
        int TutorialEnSpeed = 2;

        //Signs
        bool sign1 = false;
        bool sign2a = false;
        bool sign3 = false;
        bool sign4 = false;
        bool sign5 = false;

        public Tutorial_lvl_1()
        {
            InitializeComponent();
        }
        private void MainEventTimer(object sender, EventArgs e)
        {
            //For Checking 
            player.Visible = true;
            verticalPlatform.Visible = true;
            verticalPlatform2.Visible = true;
            if (player.Visible == true)
            {

            }
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

                    x.BringToFront();
                    if (player.Bounds.IntersectsWith(verticalPlatform.Bounds) && Jump == false)
                    {
                        verticalPlatform.Top += verticalspeed;

                        if (verticalPlatform.Top < 685 || verticalPlatform.Top > 829)
                        {
                            verticalspeed = -verticalspeed;
                        }
                    }
                    if (player.Bounds.IntersectsWith(verticalPlatform2.Bounds) && Jump == false)
                    {
                        verticalPlatform2.Top += verticalspeed2;
                        if (verticalPlatform2.Top < 528 || verticalPlatform2.Top > 665)
                        {
                            verticalspeed2 = -verticalspeed2;
                        }
                    }
                    if (player.Bounds.IntersectsWith(Button1.Bounds) && interact == true)
                    {
                        verticalPlatform2.Top += verticalspeed2;
                        if (verticalPlatform2.Top < 528 || verticalPlatform2.Top > 665)
                        {
                            verticalspeed2 = -verticalspeed2;
                        }
                    }



                }


            }

            //Lava
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Lava")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    { 
                    GameTimer.Stop();
                    GameOver = true;
                    MessageBox.Show("Try not touching the Lava :)");
                    Restart();
                    }
                }
            }
            LavaThing.Top += lavaSpeed;

            if (LavaThing.Top < 317 || LavaThing.Top > 509)
            {
                lavaSpeed = -lavaSpeed;
            }

            LavaThing2.Top += lavaSpeed2;

            if (LavaThing2.Top < 372 || LavaThing2.Top > 508)
            {
                lavaSpeed2 = -lavaSpeed2;
            }

            //Signs
            if (player.Bounds.IntersectsWith(Sign1.Bounds) && sign1 == false)
            {
                sign1 = true;
            }
            if (sign1 == true)
            {
                Guide1.Visible = true;
            }
            if (player.Bounds.IntersectsWith(Sign3.Bounds) && sign3 == false)
            {
                sign3 = true;
            }
            if (sign3 == true)
            {
                Guide3.Visible = true;
                Guide4.Visible = true;
                ButtonShow1.Visible = true;
            }
            if (player.Bounds.IntersectsWith(Sign2.Bounds) && sign2a == false)
            {
                sign2a = true;
            }
            if (sign2a == true)
            {
                Guide2.Visible = true;
            }
            if (player.Bounds.IntersectsWith(Sign4.Bounds) && sign4 == false)
            {
                sign4 = true;
            }
            if (sign4 == true)
            {
                Guide5.Visible = true;
            }
            if (player.Bounds.IntersectsWith(Sign5.Bounds) && sign5 == false)
            {
                sign5 = true;
            }
            if (sign5 == true)
            {
                Guide6.Visible = true;
                Show.Visible = true;
            }

            //Enemy
            TutorialEn.Left -= TutorialEnSpeed;
            if (TutorialEn.Left < e1Patrol.Left || TutorialEn.Left + TutorialEn.Width > e1Patrol.Left + e1Patrol.Width)
            {
                TutorialEnSpeed = -TutorialEnSpeed;
            }
            if (player.Bounds.IntersectsWith(TutorialEn.Bounds))
            {
                GameTimer.Stop();
                GameOver = true;
                MessageBox.Show("Try not Interacting with other people dude you're creeping them out");
                Restart();
            }

       
    

            //For Key and Door Func
            if (player.Bounds.IntersectsWith(Key.Bounds) && hasKey == false) 
            { 
                hasKey = true;
            }
            if (hasKey == true) 
            {
                Key.Visible = false;
                Open.Visible = true;
                Closed.Visible = false;
                Knob.Visible = false;
            }
            if (player.Bounds.IntersectsWith(Open.Bounds) && hasKey == true)
            {
                GameTimer.Stop();
                MessageBox.Show("GreatJob You Finished Tutorial lvl -1!");
                
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
            if (e.KeyCode == Keys.F)
            {
                interact = false;
            }
        }
        private void Restart()
        {
            Tutorial_lvl_1 newWindow = new Tutorial_lvl_1();
            newWindow.Show();
            this.Hide();
        }

    }
}
