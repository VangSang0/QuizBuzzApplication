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
            IndividualStudySetDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IndividualStudySetDataGrid.Columns.AddRange(new DataGridViewColumn[] { Terms, Definitions });
            IndividualStudySetDataGrid.Location = new Point(140, 55);
            IndividualStudySetDataGrid.Name = "IndividualStudySetDataGrid";
            IndividualStudySetDataGrid.Size = new Size(713, 394);
            IndividualStudySetDataGrid.TabIndex = 4;
            // 
            // Terms
            // 
            Terms.HeaderText = "Terms";
            Terms.Name = "Terms";
            Terms.Width = 250;
            // 
            // Definitions
            // 
            Definitions.HeaderText = "Definitions";
            Definitions.Name = "Definitions";
            Definitions.Width = 450;
            // 
            // IndividualStudySet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 461);
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
    }
}