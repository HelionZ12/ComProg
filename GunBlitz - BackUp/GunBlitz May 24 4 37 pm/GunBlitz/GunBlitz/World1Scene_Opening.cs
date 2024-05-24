using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunBlitz
{
    public partial class World1Scene_Opening : Form
    {
        int scene = 1;
        public World1Scene_Opening()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            if (scene == 1)
            {
                scene = scene + 1;
                Dialog.Image = Properties.Resources.World1Opening2;
            }
            else if (scene == 2)
            {
                scene = scene + 1;
                Dialog.Image = Properties.Resources.World1Opening3;
            }
            else if (scene == 3)
            {
                //NextLevel For World1
                MainMenu newWindow = new MainMenu();
                newWindow.Show();
                this.Close();
            }
        }

        private void Dialog_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //NextLevel For World1
            Chapter1Level1 newWindow = new Chapter1Level1();
            newWindow.Show();
            this.Close();
        }
    }
}
