namespace Attempt_1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            this.Hide();
            The_Game the_Game = new The_Game();
            the_Game.ShowDialog();
            
        }
    }
}
