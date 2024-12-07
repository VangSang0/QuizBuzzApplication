namespace QuizzBuzzMain.QuizzBuzzForms
{
    partial class IndividualStudySet
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
            MainMenuButton = new Button();
            StudySetsButton = new Button();
            SingleStudySetLabel = new Label();
            IndividualStudySetDataGrid = new DataGridView();
            Terms = new DataGridViewTextBoxColumn();
            Definitions = new DataGridViewTextBoxColumn();
            GenerateQuizButton = new Button();
            MultipleChoiceButton = new RadioButton();
            TrueFalseOption = new RadioButton();
            ConfrimQuizType = new Button();
            CancelSelection = new Button();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)IndividualStudySetDataGrid).BeginInit();
            SuspendLayout();
            // 
            // MainMenuButton
            // 
            MainMenuButton.Location = new Point(12, 40);
            MainMenuButton.Name = "MainMenuButton";
            MainMenuButton.Size = new Size(122, 21);
            MainMenuButton.TabIndex = 0;
            MainMenuButton.Text = "Main Menu";
            MainMenuButton.UseVisualStyleBackColor = true;
            MainMenuButton.Click += MainMenuButton_Click;
            // 
            // StudySetsButton
            // 
            StudySetsButton.Location = new Point(12, 12);
            StudySetsButton.Name = "StudySetsButton";
            StudySetsButton.Size = new Size(122, 22);
            StudySetsButton.TabIndex = 1;
            StudySetsButton.Text = "Back to Study Sets";
            StudySetsButton.UseVisualStyleBackColor = true;
            StudySetsButton.Click += StudySetsButton_Click;
            // 
            // SingleStudySetLabel
            // 
            SingleStudySetLabel.AutoSize = true;
            SingleStudySetLabel.Font = new Font("SimSun", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SingleStudySetLabel.Location = new Point(336, 12);
            SingleStudySetLabel.Name = "SingleStudySetLabel";
            SingleStudySetLabel.Size = new Size(222, 27);
            SingleStudySetLabel.TabIndex = 3;
            SingleStudySetLabel.Text = "Your Study Set";
            // 
            // IndividualStudySetDataGrid
            // 
            IndividualStudySetDataGrid.AllowUserToOrderColumns = true;
            IndividualStudySetDataGrid.AllowUserToResizeColumns = false;
            IndividualStudySetDataGrid.AllowUserToResizeRows = false;
            IndividualStudySetDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IndividualStudySetDataGrid.Columns.AddRange(new DataGridViewColumn[] { Terms, Definitions });
            IndividualStudySetDataGrid.Location = new Point(140, 55);
            IndividualStudySetDataGrid.MultiSelect = false;
            IndividualStudySetDataGrid.Name = "IndividualStudySetDataGrid";
            IndividualStudySetDataGrid.RowHeadersWidth = 51;
            IndividualStudySetDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            IndividualStudySetDataGrid.Size = new Size(713, 394);
            IndividualStudySetDataGrid.TabIndex = 4;
            // 
            // Terms
            // 
            Terms.HeaderText = "Terms";
            Terms.MinimumWidth = 6;
            Terms.Name = "Terms";
            Terms.Width = 250;
            // 
            // Definitions
            // 
            Definitions.HeaderText = "Definitions";
            Definitions.MinimumWidth = 6;
            Definitions.Name = "Definitions";
            Definitions.Width = 390;
            // 
            // GenerateQuizButton
            // 
            GenerateQuizButton.Location = new Point(9, 147);
            GenerateQuizButton.Name = "GenerateQuizButton";
            GenerateQuizButton.Size = new Size(125, 22);
            GenerateQuizButton.TabIndex = 5;
            GenerateQuizButton.Text = "Generate Quiz";
            GenerateQuizButton.UseVisualStyleBackColor = true;
            GenerateQuizButton.Click += GenerateQuizButton_Click;
            // 
            // MultipleChoiceButton
            // 
            MultipleChoiceButton.AutoSize = true;
            MultipleChoiceButton.Location = new Point(12, 175);
            MultipleChoiceButton.Name = "MultipleChoiceButton";
            MultipleChoiceButton.Size = new Size(114, 19);
            MultipleChoiceButton.TabIndex = 6;
            MultipleChoiceButton.TabStop = true;
            MultipleChoiceButton.Text = "Multiple Choice?";
            MultipleChoiceButton.UseVisualStyleBackColor = true;
            MultipleChoiceButton.Visible = false;
            // 
            // TrueFalseOption
            // 
            TrueFalseOption.AutoSize = true;
            TrueFalseOption.Location = new Point(12, 200);
            TrueFalseOption.Name = "TrueFalseOption";
            TrueFalseOption.Size = new Size(78, 19);
            TrueFalseOption.TabIndex = 7;
            TrueFalseOption.TabStop = true;
            TrueFalseOption.Text = "True/False";
            TrueFalseOption.UseVisualStyleBackColor = true;
            TrueFalseOption.Visible = false;
            // 
            // ConfrimQuizType
            // 
            ConfrimQuizType.Location = new Point(9, 225);
            ConfrimQuizType.Name = "ConfrimQuizType";
            ConfrimQuizType.Size = new Size(59, 21);
            ConfrimQuizType.TabIndex = 8;
            ConfrimQuizType.Text = "Confirm";
            ConfrimQuizType.UseVisualStyleBackColor = true;
            ConfrimQuizType.Visible = false;
            ConfrimQuizType.Click += ConfrimQuizType_Click;
            // 
            // CancelSelection
            // 
            CancelSelection.Location = new Point(75, 225);
            CancelSelection.Name = "CancelSelection";
            CancelSelection.Size = new Size(59, 21);
            CancelSelection.TabIndex = 9;
            CancelSelection.Text = "Cancel";
            CancelSelection.UseVisualStyleBackColor = true;
            CancelSelection.Visible = false;
            CancelSelection.Click += CancelSelection_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(859, 55);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(60, 37);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // IndividualStudySet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 461);
            Controls.Add(SaveButton);
            Controls.Add(CancelSelection);
            Controls.Add(ConfrimQuizType);
            Controls.Add(TrueFalseOption);
            Controls.Add(MultipleChoiceButton);
            Controls.Add(GenerateQuizButton);
            Controls.Add(IndividualStudySetDataGrid);
            Controls.Add(SingleStudySetLabel);
            Controls.Add(StudySetsButton);
            Controls.Add(MainMenuButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IndividualStudySet";
            Text = "Individual Study Set";
            Load += IndividualStudySet_Load;
            ((System.ComponentModel.ISupportInitialize)IndividualStudySetDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MainMenuButton;
        private Button StudySetsButton;
        private Label SingleStudySetLabel;
        private DataGridView IndividualStudySetDataGrid;
        private DataGridViewTextBoxColumn Terms;
        private DataGridViewTextBoxColumn Definitions;
        private Button GenerateQuizButton;
        private RadioButton MultipleChoiceButton;
        private RadioButton TrueFalseOption;
        private Button ConfrimQuizType;
        private Button CancelSelection;
        private Button SaveButton;
    }
}