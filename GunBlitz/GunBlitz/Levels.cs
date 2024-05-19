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
    public partial class Levels : Form
    {
        public Levels()
        {
            InitializeComponent();
        }

        private void lvl1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutorial_lvl_1 Tutorial = new Tutorial_lvl_1();
            Tutorial.ShowDialog();
        }

        private void lvl2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutorial_lvl_2 Tutorial = new Tutorial_lvl_2();
            Tutorial.ShowDialog();
        }
    }
}
