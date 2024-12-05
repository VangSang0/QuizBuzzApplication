using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizzBuzzMain.Utilities;

namespace QuizzBuzzMain.QuizzBuzzForms
{
    public partial class MainMenuForm : Form
    {
        FormManager formManager;
        public MainMenuForm()
        {
            formManager = new FormManager();
            InitializeComponent();
        }

        private void ViewStudyButton_MouseClick(object sender, MouseEventArgs e)
        {

            StudySetsForm studySetsForm = new StudySetsForm();
            formManager.SwitchForm(QuizBuzzMain.MainPanel, studySetsForm);

        }
    }
}
