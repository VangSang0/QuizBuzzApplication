using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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

            foreach (string studySet in studySets)
            {
                list.Items.Add(studySet);
            }
        }
    }
}
