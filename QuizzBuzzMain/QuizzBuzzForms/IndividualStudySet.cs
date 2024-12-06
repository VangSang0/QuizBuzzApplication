using QuizzBuzzMain.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuizzBuzzMain.QuizzBuzzForms
{
    public partial class IndividualStudySet : Form
    {
        private FormManager formManager;
        StudySetManager studySetManager;
        public IndividualStudySet(ListViewItem item)
        {

            InitializeComponent();
            formManager = new FormManager();
            studySetManager = new StudySetManager();
            SingleStudySetLabel.Text = item.Text;
            //IndividualStudySetDataGrid.CellValueChanged += IndividualStudySetDataGrid_CellValueChanged;
            //IndividualStudySetDataGrid.RowsRemoved += IndividualStudySetDataGrid_RowsRemoved;
        }

        private void StudySetsButton_Click(object sender, EventArgs e)
        {
            StudySetsForm studySetsForm = new StudySetsForm();
            formManager.SwitchForm(QuizBuzzMain.MainPanel, studySetsForm);
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            formManager.SwitchForm(QuizBuzzMain.MainPanel, mainMenuForm);
        }

        private void IndividualStudySet_Load(object sender, EventArgs e)
        {
            string studySetName = SingleStudySetLabel.Text;
            string studySetNamePath = studySetName + ".txt";
            formManager.loadStudySetContentOnForm(IndividualStudySetDataGrid, studySetNamePath);
            
            IndividualStudySetDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            
            IndividualStudySetDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string fileName = SingleStudySetLabel.Text + ".txt";
            //SaveDataGridViewToFile(IndividualStudySetDataGrid, fileName);
        }



    }
}
