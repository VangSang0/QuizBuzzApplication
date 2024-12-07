using QuizzBuzzMain.QuizQuestion;
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
        ListViewItem currentStudySet;
        public IndividualStudySet(ListViewItem item)
        {

            InitializeComponent();
            formManager = new FormManager();
            studySetManager = new StudySetManager();
            SingleStudySetLabel.Text = item.Text;
            currentStudySet = item;
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

        private void GenerateQuizButton_Click(object sender, EventArgs e)
        {
            MultipleChoiceButton.Visible = true;
            TrueFalseOption.Visible = true;
            ConfrimQuizType.Visible = true;
            CancelSelection.Visible = true;
        }

        private void CancelSelection_Click(object sender, EventArgs e)
        {
            MultipleChoiceButton.Visible = false;
            TrueFalseOption.Visible = false;
            ConfrimQuizType.Visible = false;
            CancelSelection.Visible = false;
        }

        private void ConfrimQuizType_Click(object sender, EventArgs e)
        {
            string studySetName = SingleStudySetLabel.Text;
            string studySetPath = studySetName + ".txt";
            List<IQuestionType> questionTypes = new List<IQuestionType>();

            if (MultipleChoiceButton.Checked)
            {
                questionTypes = studySetManager.GenerateMultipleChoiceQuestions(studySetPath);

            }
            else if (TrueFalseOption.Checked)
            {
                {
                    questionTypes = studySetManager.GenerateTrueFalseQuestions(studySetPath);
                }
            }

            QuizForm quizForm = new QuizForm(questionTypes, currentStudySet);
            formManager.SwitchForm(QuizBuzzMain.MainPanel, quizForm);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string studySetName = SingleStudySetLabel.Text;
            studySetManager.SaveContentToFile(studySetName, IndividualStudySetDataGrid);
        }
    }
}
