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
            BackButton.Location = new Point(10, 14);
            BackButton.Margin = new Padding(3, 2, 3, 2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(142, 22);
            BackButton.TabIndex = 0;
            BackButton.Text = "Back To Menu";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.MouseClick += BackButton_MouseClick;
            // 
            // YourStudySetLabel
            // 
            YourStudySetLabel.AutoSize = true;
            YourStudySetLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YourStudySetLabel.Location = new Point(374, 14);
            YourStudySetLabel.Name = "YourStudySetLabel";
            YourStudySetLabel.Size = new Size(179, 32);
            YourStudySetLabel.TabIndex = 2;
            YourStudySetLabel.Text = "Your Study Sets";
            // 
            // SelectButton
            // 
            SelectButton.Location = new Point(575, 352);
            SelectButton.Margin = new Padding(3, 2, 3, 2);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(147, 22);
            SelectButton.TabIndex = 3;
            SelectButton.Text = "Select";
            SelectButton.UseVisualStyleBackColor = true;
            SelectButton.Visible = false;
            SelectButton.Click += SelectButton_Click;
            // 
            // StudySetListView
            // 
            StudySetListView.Columns.AddRange(new ColumnHeader[] { StudySetsColumn });
            StudySetListView.Location = new Point(262, 62);
            StudySetListView.Margin = new Padding(3, 2, 3, 2);
            StudySetListView.MultiSelect = false;
            StudySetListView.Name = "StudySetListView";
            StudySetListView.Size = new Size(409, 280);
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
            DeleteButton.Location = new Point(399, 352);
            DeleteButton.Margin = new Padding(3, 2, 3, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(147, 22);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Visible = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditNameButton
            // 
            EditNameButton.Location = new Point(223, 352);
            EditNameButton.Margin = new Padding(3, 2, 3, 2);
            EditNameButton.Name = "EditNameButton";
            EditNameButton.Size = new Size(147, 22);
            EditNameButton.TabIndex = 6;
            EditNameButton.Text = "Edit Study Set Name";
            EditNameButton.UseVisualStyleBackColor = true;
            EditNameButton.Visible = false;
            EditNameButton.Click += EditNameButton_Click;
            // 
            // CreateStudySetButton
            // 
            CreateStudySetButton.Location = new Point(81, 170);
            CreateStudySetButton.Margin = new Padding(3, 2, 3, 2);
            CreateStudySetButton.Name = "CreateStudySetButton";
            CreateStudySetButton.Size = new Size(161, 22);
            CreateStudySetButton.TabIndex = 7;
            CreateStudySetButton.Text = "Create New Study Set";
            CreateStudySetButton.UseVisualStyleBackColor = true;
            CreateStudySetButton.Click += CreateStudySetButton_Click;
            // 
            // NewStudySetLabel
            // 
            NewStudySetLabel.AutoSize = true;
            NewStudySetLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewStudySetLabel.Location = new Point(12, 204);
            NewStudySetLabel.Name = "NewStudySetLabel";
            NewStudySetLabel.Size = new Size(234, 17);
            NewStudySetLabel.TabIndex = 8;
            NewStudySetLabel.Text = "What is the Name of the new Study set";
            NewStudySetLabel.Visible = false;
            // 
            // NewStudySetNameInput
            // 
            NewStudySetNameInput.Location = new Point(31, 224);
            NewStudySetNameInput.Name = "NewStudySetNameInput";
            NewStudySetNameInput.Size = new Size(211, 23);
            NewStudySetNameInput.TabIndex = 9;
            NewStudySetNameInput.Visible = false;
            // 
            // CancelNewSetButton
            // 
            CancelNewSetButton.Location = new Point(167, 253);
            CancelNewSetButton.Name = "CancelNewSetButton";
            CancelNewSetButton.Size = new Size(75, 23);
            CancelNewSetButton.TabIndex = 10;
            CancelNewSetButton.Text = "Cancel";
            CancelNewSetButton.UseVisualStyleBackColor = true;
            CancelNewSetButton.Visible = false;
            CancelNewSetButton.Click += CancelNewSetButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(31, 253);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(92, 23);
            CreateButton.TabIndex = 11;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Visible = false;
            CreateButton.Click += CreateButton_Click;
            // 
            // EditNewNameLabel
            // 
            EditNewNameLabel.AutoSize = true;
            EditNewNameLabel.Location = new Point(179, 386);
            EditNewNameLabel.Name = "EditNewNameLabel";
            EditNewNameLabel.Size = new Size(220, 15);
            EditNewNameLabel.TabIndex = 12;
            EditNewNameLabel.Text = "What did you want the new name to be?";
            EditNewNameLabel.Visible = false;
            // 
            // EditNewNameTextBox
            // 
            EditNewNameTextBox.Location = new Point(192, 404);
            EditNewNameTextBox.Name = "EditNewNameTextBox";
            EditNewNameTextBox.Size = new Size(186, 23);
            EditNewNameTextBox.TabIndex = 13;
            EditNewNameTextBox.Visible = false;
            // 
            // ConfirmEditButton
            // 
            ConfirmEditButton.Location = new Point(192, 433);
            ConfirmEditButton.Name = "ConfirmEditButton";
            ConfirmEditButton.Size = new Size(75, 23);
            ConfirmEditButton.TabIndex = 14;
            ConfirmEditButton.Text = "Confirm";
            ConfirmEditButton.UseVisualStyleBackColor = true;
            ConfirmEditButton.Visible = false;
            ConfirmEditButton.Click += ConfirmEditButton_Click;
            // 
            // CancelEditButton
            // 
            CancelEditButton.Location = new Point(295, 433);
            CancelEditButton.Name = "CancelEditButton";
            CancelEditButton.Size = new Size(75, 23);
            CancelEditButton.TabIndex = 15;
            CancelEditButton.Text = "Cancel";
            CancelEditButton.UseVisualStyleBackColor = true;
            CancelEditButton.Visible = false;
            CancelEditButton.Click += CancelEditButton_Click;
            // 
            // StudySetsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(919, 488);
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
            Margin = new Padding(3, 2, 3, 2);
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