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
            if (StudySetListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = StudySetListView.SelectedItems[0];
                DeleteButton.Visible = true;
                EditNameButton.Visible = true;
                SelectButton.Visible = true;
            }
            else if (StudySetListView.SelectedItems.Count == 0)
            {
                DeleteButton.Visible = false;
                EditNameButton.Visible = false;
                SelectButton.Visible = false;
            }
            //else
            //{
            //    throw new Exception("Invalid number of selected items");
            //}

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //if (StudySetListView.SelectedItems.Count > 0)
            //{
            //    ListViewItem selectedItem = StudySetListView.SelectedItems[0];
            //    string studySetName = selectedItem.Text + ".txt";
            //    StudySetListView.Items.Remove(selectedItem);
            //    studySetManager.DeleteStudySet(studySetName);
            //}
            ListViewItem selectedItem = StudySetListView.SelectedItems[0];
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete '{selectedItem.Text}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                string studySetName = selectedItem.Text + ".txt";
                StudySetListView.Items.Remove(selectedItem);
                studySetManager.DeleteStudySet(studySetName);
                formManager.RefreshStudySets(StudySetListView);
            }
            else
            {
                return;
            }

        }

        private void CreateStudySetButton_Click(object sender, EventArgs e)
        {

        }
    }
}
