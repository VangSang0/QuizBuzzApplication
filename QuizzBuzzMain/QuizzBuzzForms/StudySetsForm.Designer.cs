namespace QuizzBuzzMain.QuizzBuzzForms
{
    partial class StudySetsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BackButton = new Button();
            YourStudySetLabel = new Label();
            SelectButton = new Button();
            StudySetListView = new ListView();
            StudySetsColumn = new ColumnHeader();
            DeleteButton = new Button();
            EditNameButton = new Button();
            CreateStudySetButton = new Button();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 18);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(162, 29);
            BackButton.TabIndex = 0;
            BackButton.Text = "Back To Menu";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.MouseClick += BackButton_MouseClick;
            // 
            // YourStudySetLabel
            // 
            YourStudySetLabel.AutoSize = true;
            YourStudySetLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YourStudySetLabel.Location = new Point(427, 18);
            YourStudySetLabel.Name = "YourStudySetLabel";
            YourStudySetLabel.Size = new Size(223, 41);
            YourStudySetLabel.TabIndex = 2;
            YourStudySetLabel.Text = "Your Study Sets";
            // 
            // SelectButton
            // 
            SelectButton.Location = new Point(657, 469);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(168, 29);
            SelectButton.TabIndex = 3;
            SelectButton.Text = "Select";
            SelectButton.UseVisualStyleBackColor = true;
            SelectButton.Visible = false;
            // 
            // StudySetListView
            // 
            StudySetListView.Columns.AddRange(new ColumnHeader[] { StudySetsColumn });
            StudySetListView.Location = new Point(300, 82);
            StudySetListView.MultiSelect = false;
            StudySetListView.Name = "StudySetListView";
            StudySetListView.Size = new Size(467, 372);
            StudySetListView.TabIndex = 4;
            StudySetListView.UseCompatibleStateImageBehavior = false;
            StudySetListView.View = View.Details;
            // 
            // StudySetsColumn
            // 
            StudySetsColumn.Text = "Current Study Sets";
            StudySetsColumn.Width = 300;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(456, 469);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(168, 29);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Visible = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditNameButton
            // 
            EditNameButton.Location = new Point(255, 469);
            EditNameButton.Name = "EditNameButton";
            EditNameButton.Size = new Size(168, 29);
            EditNameButton.TabIndex = 6;
            EditNameButton.Text = "Edit Study Set Name";
            EditNameButton.UseVisualStyleBackColor = true;
            EditNameButton.Visible = false;
            // 
            // CreateStudySetButton
            // 
            CreateStudySetButton.Location = new Point(93, 226);
            CreateStudySetButton.Name = "CreateStudySetButton";
            CreateStudySetButton.Size = new Size(184, 29);
            CreateStudySetButton.TabIndex = 7;
            CreateStudySetButton.Text = "Create New Study Set";
            CreateStudySetButton.UseVisualStyleBackColor = true;
            CreateStudySetButton.Click += CreateStudySetButton_Click;
            // 
            // StudySetsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1050, 650);
            Controls.Add(CreateStudySetButton);
            Controls.Add(EditNameButton);
            Controls.Add(DeleteButton);
            Controls.Add(StudySetListView);
            Controls.Add(SelectButton);
            Controls.Add(YourStudySetLabel);
            Controls.Add(BackButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudySetsForm";
            Text = "Form1";
            Load += StudySetsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Label YourStudySetLabel;
        private Button SelectButton;
        private ListView StudySetListView;
        private ColumnHeader StudySetsColumn;
        private Button DeleteButton;
        private Button EditNameButton;
        private Button CreateStudySetButton;
    }
}