namespace QuizzBuzzMain.QuizzBuzzForms
{
    partial class MainMenuForm
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
            TitleLabel = new Label();
            ViewStudyButton = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = Color.Transparent;
            TitleLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(314, 78);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(242, 30);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Welcome To QuizBuzz";
            // 
            // ViewStudyButton
            // 
            ViewStudyButton.BackColor = SystemColors.ActiveCaption;
            ViewStudyButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewStudyButton.Location = new Point(362, 287);
            ViewStudyButton.Margin = new Padding(3, 2, 3, 2);
            ViewStudyButton.Name = "ViewStudyButton";
            ViewStudyButton.Size = new Size(173, 47);
            ViewStudyButton.TabIndex = 1;
            ViewStudyButton.Text = "View Study Sets";
            ViewStudyButton.UseVisualStyleBackColor = false;
            ViewStudyButton.MouseClick += ViewStudyButton_MouseClick;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 488);
            Controls.Add(ViewStudyButton);
            Controls.Add(TitleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainMenuForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Button ViewStudyButton;
    }
}