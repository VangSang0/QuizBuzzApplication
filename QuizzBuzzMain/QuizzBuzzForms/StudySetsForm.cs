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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuizzBuzzMain.QuizzBuzzForms
{
    public partial class StudySetsForm : Form
    {
        private FormManager formManager;
        private StudySetManager studySetManager;

        public StudySetsForm()
        {
            formManager = new FormManager();
            studySetManager = new StudySetManager();
            InitializeComponent();
            StudySetListView.SelectedIndexChanged += StudySetListView_SelectedIndexChanged;
        }

        private void BackButton_MouseClick(object sender, MouseEventArgs e)
        {

            MainMenuForm mainMenuForm = new MainMenuForm();
            formManager.SwitchForm(QuizBuzzMain.MainPanel, mainMenuForm);

        }

        private void StudySetsForm_Load(object sender, EventArgs e)
        {
            List<string> studySets = studySetManager.GetAllStudySets();
            if (studySets.Count == 0)
            {
                ListViewItem noItemsItem = new ListViewItem("No study sets found");
                StudySetListView.Items.Add(noItemsItem);
                StudySetListView.Enabled = false;
                //return;
            }
            else
            {
                foreach (string studySet in studySets)
                {
                    StudySetListView.Items.Add(studySet);
                }

            }

        }
        private void StudySetListView_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (StudySetListView.SelectedItems.Count > 0 && StudySetListView.Focused)
            {
                ListViewItem selectedItem = StudySetListView.SelectedItems[0];
                DeleteButton.Visible = true;
                EditNameButton.Visible = true;
                SelectButton.Visible = true;
            }
            else
            {
                DeleteButton.Visible = false;
                EditNameButton.Visible = false;
                SelectButton.Visible = false;
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            ListViewItem selectedItem = StudySetListView.SelectedItems[0];

            _ = formManager.deleteStudySet(StudySetListView, selectedItem);

        }

        private void CreateStudySetButton_Click(object sender, EventArgs e)
        {
            NewStudySetLabel.Visible = true;
            NewStudySetNameInput.Visible = true;
            CancelNewSetButton.Visible = true;
            CreateButton.Visible = true;
        }

        private void CancelNewSetButton_Click(object sender, EventArgs e)
        {
            NewStudySetNameInput.Text = "";
            NewStudySetLabel.Visible = false;
            NewStudySetNameInput.Visible = false;
            CancelNewSetButton.Visible = false;
            CreateButton.Visible = false;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            formManager.createNewStudySet(NewStudySetNameInput);
            formManager.RefreshStudySets(StudySetListView);
            NewStudySetNameInput.Text = "";
            NewStudySetLabel.Visible = false;
            NewStudySetNameInput.Visible = false;
            CancelNewSetButton.Visible = false;
            CreateButton.Visible = false;

        }

        private void EditNameButton_Click(object sender, EventArgs e)
        {
            EditNewNameLabel.Text = "Enter new name for study set:";
            EditNewNameLabel.Visible = true;
            EditNewNameTextBox.Visible = true;
            ConfirmEditButton.Visible = true;
            CancelEditButton.Visible = true;
            DeleteButton.Visible = false;
            SelectButton.Visible = false;
        }

        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            EditNewNameLabel.Text = "Enter New Name for Study Set:";
            EditNewNameLabel.Visible = false;
            EditNewNameTextBox.Text = "";
            EditNewNameTextBox.Visible = false;
            ConfirmEditButton.Visible = false;
            CancelEditButton.Visible = false;
            DeleteButton.Visible = true;
            SelectButton.Visible = true;
        }

        private void ConfirmEditButton_Click(object sender, EventArgs e)
        {
            if (StudySetListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a study set to rename.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem selectedItem = StudySetListView.SelectedItems[0];
            string oldFileName = selectedItem.Text + ".txt";


            // Use the TextBox for answer
            string newEditName = EditNewNameTextBox.Text;

            if (string.IsNullOrWhiteSpace(newEditName))
            {
                MessageBox.Show("New name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ = formManager.editStudySet(StudySetListView, oldFileName, newEditName);
            EditNewNameTextBox.Text = "";
            EditNewNameLabel.Visible = false;
            EditNewNameTextBox.Visible = false;
            ConfirmEditButton.Visible = false;
            CancelEditButton.Visible = false;
            DeleteButton.Visible = true;
            SelectButton.Visible = true;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = StudySetListView.SelectedItems[0];
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to enter '{selectedItem.Text}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                IndividualStudySet individualStudySet = new IndividualStudySet(selectedItem);
                formManager.SwitchForm(QuizBuzzMain.MainPanel, individualStudySet);
            }
            else
            {
                return;
            }
        }
    }
}
