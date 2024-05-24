using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunBlitz
{
    class Bullet
    {
        public string direction = ""; // Initialize as empty string to avoid null
        public int bulletLeft;
        public int bulletTop;

        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private System.Windows.Forms.Timer bulletTimer = new System.Windows.Forms.Timer();

        public void MakeBullet(Form form)
        {
            bullet.BackColor = Color.Cyan;
            bullet.Size = new Size(15, 2);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            bullet.BringToFront();

            form.Controls.Add(bullet);

            bulletTimer.Interval = speed;
            bulletTimer.Tick += BulletTimerEvent;
            bulletTimer.Start();
        }

        private void BulletTimerEvent(object? sender, EventArgs e) // Use nullable annotations
        {
            if (direction == "left")
            {
                bullet.Left -= speed;
            }
            else if (direction == "right")
            {
                bullet.Left += speed;
            }

            // Additional directions can be handled similarly (up, down) if needed

            // Adjusted boundary condition
            if (bullet.Left < 10 || bullet.Left > 1453 || bullet.Top < 10 || bullet.Top > 950)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null!;
                bullet = null!;
            }
        }
    }
}


