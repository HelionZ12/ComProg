namespace GunBlitz
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
             Levels Level = new Levels();
            Level.ShowDialog();
        }
    }
}
