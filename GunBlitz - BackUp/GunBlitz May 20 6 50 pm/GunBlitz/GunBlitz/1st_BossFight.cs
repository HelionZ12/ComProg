using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GunBlitz
{
    public partial class _1st_BossFight : Form
    {
        //Objective
        bool ObjectiveComplete = false;

        //PlayerMovement
        bool goLeft, goRight, Jump, interact, GameOver, CompleteObj, reload;

        //Player
        string Direction = "right";
        int jumpSpeed = 5;
        int force = 8;
        int PlayerSpeed = 10;
        int playerHealth = 100;
        int totalKills;
        int ammo;
        int Dmg;
        int finalspeed = 3;

        //BossState
        bool Channeling = false, BossFightStart = true, BossAlive = false, ChangePos = false, fatig = false;
        int fatigue = 0;
        int Ability = 0;
        int Selected = 0;
        int BossPos = 0;
        int restSpeed = 5;
        int BossHealth = 100;

        //Laser
        int LSpeed1 = 50;
        int LSpeed2 = 50;
        int LSpeed3 = 50;
        int LSpeed4 = 50;
        int LSpeed5 = 50;
        int LSpeed6 = 50;
        Random rand = new Random();
        Random rand2 = new Random();
        public _1st_BossFight()
        {
            InitializeComponent();


        }

        private void MainEventTimer(object sender, EventArgs e)
        {
            //Boss
            if (BossHealth > 1)
            {
                BossHP.Value = BossHealth;
            }
            else if (BossHealth == 0) 
            {
                BossAlive = false;
                TheBigBad.Top = 127;
                TheBigBad.Left = 662;
                FinalBullet.Visible = true;
                FinalBullet.Left += finalspeed;
                if (FinalBullet.Bounds.IntersectsWith(Final.Bounds))
                {
                    GameTimer.Stop();
                    MessageBox.Show("You Defeated (BossName)!");
                }
            }
            // Player Health Management
            if (playerHealth > 1)
            {
                PlayerHp.Value = playerHealth;
            }
            else if (playerHealth == 0)
            {
                GameTimer.Stop();
                MessageBox.Show("You Have Been Defeated!");
            }
            player.Visible = true;

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
                jumpSpeed = 14;
            }
            if (Jump == true && force == 0)
            {
                Jump = false;
            }

            // Platform Collision
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !Jump)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                        jumpSpeed = 0;
                    }
                }
            }

            // Teleporter Interaction
            if (player.Bounds.IntersectsWith(Teleporter1.Bounds))
            {
                player.Top = 616;
                player.Left = 51;
                BossAlive = true;
                fatig = false;
                Channeling = false;
                ChangePos = true;
                TheBigBad.Visible = true;
                TheBigBad.Left = 651;
                TheBigBad.Top = 378;
            }

            // Boss Ability Selection
            if (!Channeling && !fatig && BossAlive)
            {
                Ability = rand.Next(1, 3); // Generates a number between 1 and 2 inclusive
                Selected = Ability;
                Channeling = true;
            }

            // Boss Visibility and Position Handling
            if (BossAlive)
            {
                TheBigBad.Visible = true;
                PlayerPort.Visible = true;
                PlayerHp.Visible = true;
                BossHP.Visible = true;
                Vs.Visible = true;

                if (ChangePos)
                {
                    BossPos = rand.Next(1, 5); // Generates a number between 1 and 4 inclusive
                    ChangePos = false;

                    switch (BossPos)
                    {
                        case 1:
                            TheBigBad.Left = 651;
                            TheBigBad.Top = 378;
                            break;
                        case 2:
                            TheBigBad.Left = 97;
                            TheBigBad.Top = 87;
                            break;
                        case 3:
                            TheBigBad.Left = 990;
                            TheBigBad.Top = 475;
                            break;
                        case 4:
                            TheBigBad.Left = 37;
                            TheBigBad.Top = 569;
                            break;
                    }
                }
            }

            // Laser Handling for Ability 1
            if (Channeling && Selected == 1)
            {
                Laser1.Left -= LSpeed1;
                Laser2.Left -= LSpeed2;
                Laser3.Left -= LSpeed3;
                Laser4.Left -= LSpeed4;
                Laser5.Left -= LSpeed5;
                Laser6.Left -= LSpeed6;
                Laser1.Visible = true;
                Laser2.Visible = true;
                Laser3.Visible = true;
                Laser4.Visible = true;
                Laser5.Visible = true;
                Laser6.Visible = true;
                ChangePos = false;

                if (Detection.Bounds.IntersectsWith(Laser1.Bounds))
                {
                    Channeling = false;
                    ResetLasers();
                    ChangePos = true;
                    fatigue++;
                }
            }
            // Laser Handling for Ability 2
            else if (Channeling && Selected == 2)
            {
                LaserUp1.Top -= LSpeed1;
                LaserUp2.Top -= LSpeed2;
                LaserUp3.Top -= LSpeed3;
                LaserUp4.Top -= LSpeed4;
                LaserUp5.Top -= LSpeed5;
                LaserUp1.Visible = true;
                LaserUp2.Visible = true;
                LaserUp3.Visible = true;
                LaserUp4.Visible = true;
                LaserUp5.Visible = true;
                ChangePos = false;

                if (Detection1.Bounds.IntersectsWith(LaserUp1.Bounds))
                {
                    Channeling = false;
                    ResetLaserUps();
                    ChangePos = true;
                    fatigue++;
                }
            }

            // Fatigue Handling
            if (fatigue == 8)
            {
                Dialogue.Visible = true;
                TheBigBad.Left = 669;
                TheBigBad.Top = 378;
                Rest.Visible = true;
                Rest.Top += restSpeed;
                fatig = true;

                if (Rest.Bounds.IntersectsWith(EndRest.Bounds))
                {
                    Dialogue.Visible = false;
                    Rest.Visible = false;
                    Rest.Top = 0;
                    fatig = false;
                    fatigue = 0;
                }
            }

            //Hit Detection for laser
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Laser")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 8;

                    }
                }
            }
            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && (string)j.Tag == "bullet")
                {
                    if (j.Bounds.IntersectsWith(TheBigBad.Bounds) && BossAlive == true)
                    {
                        this.Controls.Remove(j);
                        ((PictureBox)j).Dispose();
                        BossHealth -= 2;
                    }

                }
            }
        }
        private void ResetLasers()
        {
            Laser1.Left = 1375;
            Laser2.Left = 1334;
            Laser3.Left = 1375;
            Laser4.Left = 1334;
            Laser5.Left = 1375;
            Laser6.Left = 1334;
            Laser1.Visible = false;
            Laser2.Visible = false;
            Laser3.Visible = false;
            Laser4.Visible = false;
            Laser5.Visible = false;
            Laser6.Visible = false;
        }

        private void ResetLaserUps()
        {
            LaserUp1.Top = 616;
            LaserUp2.Top = 616;
            LaserUp3.Top = 616;
            LaserUp4.Top = 616;
            LaserUp5.Top = 616;
            LaserUp1.Visible = false;
            LaserUp2.Visible = false;
            LaserUp3.Visible = false;
            LaserUp4.Visible = false;
            LaserUp5.Visible = false;
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
            if (e.KeyCode == Keys.Space && ammo > 0)
            {
                reload = true;
                ShootGun(Direction);
                ammo--;
            }
            if (e.KeyCode == Keys.R && ammo == 0)
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
        private void ShootGun(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }

    }
}


