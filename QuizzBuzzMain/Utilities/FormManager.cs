using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuizzBuzzMain.Utilities
{
    public class FormManager
    {
        private StudySetManager studySetManager = new StudySetManager();
        public void SwitchForm(Panel panel, Form form)
        {
            if (panel.Controls.Count > 0)
            {
                foreach (Control control in panel.Controls)
                {
                    control.Dispose();
                }
                panel.Controls.Clear();
            }

            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(form);
            form.Show();
        }

        public void RefreshStudySets(ListView list)
        {
            
            list.Items.Clear();

            
            List<string> studySets = studySetManager.GetAllStudySets();

            
            if (studySets.Count == 0)
            {
                ListViewItem noItemsItem = new ListViewItem("No study sets found");
                noItemsItem.ForeColor = Color.Gray;
                list.Items.Add(noItemsItem);
                list.Enabled = false;
                return;
            }
            else
            {
                list.Enabled= true;
                foreach (string studySet in studySets)
                {
                    list.Items.Add(studySet);
                }
            }

            
            list.Refresh();
        }

        public async void createNewStudySet(TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                string studySet = textBox.Text.Trim();
                string fixedStudySet = Regex.Replace(studySet, @"\s+", " ");
                fixedStudySet = fixedStudySet.Replace(" ", "_") + ".txt";
                DialogResult result = MessageBox.Show(
                    $"Do you want the name '{textBox.Text}'?", 
                    "Confirm Creation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                    );
                if (result == DialogResult.Yes)
                {

                    await studySetManager.CreateNewStudySetAsync(fixedStudySet);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show(
                    $"This entry is Invalid! Make sure to Enter Words only",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }
        }

        public async Task deleteStudySet(ListView listView, ListViewItem listViewItem)
        {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete '{listViewItem.Text}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                string studySetName = listViewItem.Text + ".txt";
                listView.Items.Remove(listViewItem);
                await studySetManager.DeleteStudySetAsync(studySetName);
                this.RefreshStudySets(listView);
            }
            else
            {
                return;
            }
        }

        public async Task editStudySet(ListView listView, string oldListViewName, string newListViewName)
        {
            string newStudySetName = newListViewName.Trim();
            string fixedNewStudySetName = Regex.Replace(newStudySetName, @"\s+", " ");
            fixedNewStudySetName = fixedNewStudySetName.Replace(" ", "_") + ".txt";

            try
            {
                _ = studySetManager.EditStudySetName(oldListViewName, fixedNewStudySetName);
                await Task.CompletedTask;

                this.RefreshStudySets(listView);

                MessageBox.Show("Study set renamed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error renaming study set: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadStudySetContentOnForm(DataGridView dataGrid, string studySetName)
        {
            Dictionary<string,string> studySet = studySetManager.LoadStudySetContent(studySetName);
            dataGrid.Rows.Clear();

            foreach (KeyValuePair<string, string> entry in studySet)
            {
                dataGrid.Rows.Add(entry.Key, entry.Value);
            }
        }

    }
}
