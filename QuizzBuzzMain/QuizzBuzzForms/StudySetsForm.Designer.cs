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
            NewStudySetLabel = new Label();
            NewStudySetNameInput = new TextBox();
            CancelNewSetButton = new Button();
            CreateButton = new Button();
            EditNewNameLabel = new Label();
            EditNewNameTextBox = new TextBox();
            ConfirmEditButton = new Button();
            CancelEditButton = new Button();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(11, 19);
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
            YourStudySetLabel.Location = new Point(427, 19);
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
            SelectButton.Click += SelectButton_Click;
            // 
            // StudySetListView
            // 
            StudySetListView.Columns.AddRange(new ColumnHeader[] { StudySetsColumn });
            StudySetListView.Location = new Point(337, 78);
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
            EditNameButton.Click += EditNameButton_Click;
            // 
            // CreateStudySetButton
            // 
            CreateStudySetButton.Location = new Point(93, 227);
            CreateStudySetButton.Name = "CreateStudySetButton";
            CreateStudySetButton.Size = new Size(184, 29);
            CreateStudySetButton.TabIndex = 7;
            CreateStudySetButton.Text = "Create New Study Set";
            CreateStudySetButton.UseVisualStyleBackColor = true;
            CreateStudySetButton.Click += CreateStudySetButton_Click;
            // 
            // NewStudySetLabel
            // 
            NewStudySetLabel.AutoSize = true;
            NewStudySetLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewStudySetLabel.Location = new Point(14, 272);
            NewStudySetLabel.Name = "NewStudySetLabel";
            NewStudySetLabel.Size = new Size(308, 23);
            NewStudySetLabel.TabIndex = 8;
            NewStudySetLabel.Text = "What is the Name of the new Study set";
            NewStudySetLabel.Visible = false;
            // 
            // NewStudySetNameInput
            // 
            NewStudySetNameInput.Location = new Point(35, 299);
            NewStudySetNameInput.Margin = new Padding(3, 4, 3, 4);
            NewStudySetNameInput.Name = "NewStudySetNameInput";
            NewStudySetNameInput.Size = new Size(241, 27);
            NewStudySetNameInput.TabIndex = 9;
            NewStudySetNameInput.Visible = false;
            // 
            // CancelNewSetButton
            // 
            CancelNewSetButton.Location = new Point(191, 337);
            CancelNewSetButton.Margin = new Padding(3, 4, 3, 4);
            CancelNewSetButton.Name = "CancelNewSetButton";
            CancelNewSetButton.Size = new Size(86, 31);
            CancelNewSetButton.TabIndex = 10;
            CancelNewSetButton.Text = "Cancel";
            CancelNewSetButton.UseVisualStyleBackColor = true;
            CancelNewSetButton.Visible = false;
            CancelNewSetButton.Click += CancelNewSetButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(35, 337);
            CreateButton.Margin = new Padding(3, 4, 3, 4);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(105, 31);
            CreateButton.TabIndex = 11;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Visible = false;
            CreateButton.Click += CreateButton_Click;
            // 
            // EditNewNameLabel
            // 
            EditNewNameLabel.AutoSize = true;
            EditNewNameLabel.Location = new Point(205, 515);
            EditNewNameLabel.Name = "EditNewNameLabel";
            EditNewNameLabel.Size = new Size(277, 20);
            EditNewNameLabel.TabIndex = 12;
            EditNewNameLabel.Text = "What did you want the new name to be?";
            EditNewNameLabel.Visible = false;
            // 
            // EditNewNameTextBox
            // 
            EditNewNameTextBox.Location = new Point(219, 539);
            EditNewNameTextBox.Margin = new Padding(3, 4, 3, 4);
            EditNewNameTextBox.Name = "EditNewNameTextBox";
            EditNewNameTextBox.Size = new Size(212, 27);
            EditNewNameTextBox.TabIndex = 13;
            EditNewNameTextBox.Visible = false;
            // 
            // ConfirmEditButton
            // 
            ConfirmEditButton.Location = new Point(219, 577);
            ConfirmEditButton.Margin = new Padding(3, 4, 3, 4);
            ConfirmEditButton.Name = "ConfirmEditButton";
            ConfirmEditButton.Size = new Size(86, 31);
            ConfirmEditButton.TabIndex = 14;
            ConfirmEditButton.Text = "Confirm";
            ConfirmEditButton.UseVisualStyleBackColor = true;
            ConfirmEditButton.Visible = false;
            ConfirmEditButton.Click += ConfirmEditButton_Click;
            // 
            // CancelEditButton
            // 
            CancelEditButton.Location = new Point(337, 577);
            CancelEditButton.Margin = new Padding(3, 4, 3, 4);
            CancelEditButton.Name = "CancelEditButton";
            CancelEditButton.Size = new Size(86, 31);
            CancelEditButton.TabIndex = 15;
            CancelEditButton.Text = "Cancel";
            CancelEditButton.UseVisualStyleBackColor = true;
            CancelEditButton.Visible = false;
            CancelEditButton.Click += CancelEditButton_Click;
            // 
            // StudySetsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1050, 651);
            Controls.Add(CancelEditButton);
            Controls.Add(ConfirmEditButton);
            Controls.Add(EditNewNameTextBox);
            Controls.Add(EditNewNameLabel);
            Controls.Add(CreateButton);
            Controls.Add(CancelNewSetButton);
            Controls.Add(NewStudySetNameInput);
            Controls.Add(NewStudySetLabel);
            Controls.Add(CreateStudySetButton);
            Controls.Add(EditNameButton);
            Controls.Add(DeleteButton);
            Controls.Add(StudySetListView);
            Controls.Add(SelectButton);
            Controls.Add(YourStudySetLabel);
            Controls.Add(BackButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudySetsForm";
            Text = "StudySet Window";
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
        private Label NewStudySetLabel;
        private TextBox NewStudySetNameInput;
        private Button CancelNewSetButton;
        private Button CreateButton;
        private Label EditNewNameLabel;
        private TextBox EditNewNameTextBox;
        private Button ConfirmEditButton;
        private Button CancelEditButton;
    }
}