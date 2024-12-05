using QuizzBuzzMain.QuizzBuzzForms;

namespace QuizzBuzzMain
{
    public partial class QuizBuzzMain : Form
    {
        public static Panel MainPanel;
        public QuizBuzzMain()
        {
            InitializeComponent();
            MainPanel = panel1;
        }

        private void QuizBuzzMain_Load(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Dock = DockStyle.Fill;
            mainMenu.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(mainMenu);
            mainMenu.Show();
        }
    }
}
