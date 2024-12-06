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
            MainMenuButton.Location = new Point(14, 53);
            MainMenuButton.Margin = new Padding(3, 4, 3, 4);
            MainMenuButton.Name = "MainMenuButton";
            MainMenuButton.Size = new Size(139, 28);
            MainMenuButton.TabIndex = 0;
            MainMenuButton.Text = "Main Menu";
            MainMenuButton.UseVisualStyleBackColor = true;
            MainMenuButton.Click += MainMenuButton_Click;
            // 
            // StudySetsButton
            // 
            StudySetsButton.Location = new Point(14, 16);
            StudySetsButton.Margin = new Padding(3, 4, 3, 4);
            StudySetsButton.Name = "StudySetsButton";
            StudySetsButton.Size = new Size(139, 29);
            StudySetsButton.TabIndex = 1;
            StudySetsButton.Text = "Back to Study Sets";
            StudySetsButton.UseVisualStyleBackColor = true;
            StudySetsButton.Click += StudySetsButton_Click;
            // 
            // SingleStudySetLabel
            // 
            SingleStudySetLabel.AutoSize = true;
            SingleStudySetLabel.Font = new Font("SimSun", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SingleStudySetLabel.Location = new Point(384, 16);
            SingleStudySetLabel.Name = "SingleStudySetLabel";
            SingleStudySetLabel.Size = new Size(267, 34);
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
            IndividualStudySetDataGrid.Location = new Point(160, 73);
            IndividualStudySetDataGrid.Margin = new Padding(3, 4, 3, 4);
            IndividualStudySetDataGrid.MultiSelect = false;
            IndividualStudySetDataGrid.Name = "IndividualStudySetDataGrid";
            IndividualStudySetDataGrid.RowHeadersWidth = 51;
            IndividualStudySetDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            IndividualStudySetDataGrid.Size = new Size(815, 525);
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
            Definitions.Width = 500;
            // 
            // IndividualStudySet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 615);
            Controls.Add(IndividualStudySetDataGrid);
            Controls.Add(SingleStudySetLabel);
            Controls.Add(StudySetsButton);
            Controls.Add(MainMenuButton);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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