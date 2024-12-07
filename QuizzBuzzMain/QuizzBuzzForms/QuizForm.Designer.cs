namespace QuizzBuzzMain.QuizzBuzzForms
{
    partial class QuizForm
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
            QuestionLabel = new Label();
            ConfirmAnswerButton = new Button();
            OptionPanel = new Panel();
            FeedbackLabel = new Label();
            QuestionNumberLabel = new Label();
            SuspendLayout();
            // 
            // QuestionLabel
            // 
            QuestionLabel.AutoSize = true;
            QuestionLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuestionLabel.Location = new Point(116, 24);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Size = new Size(68, 20);
            QuestionLabel.TabIndex = 0;
            QuestionLabel.Text = "Question";
            // 
            // ConfirmAnswerButton
            // 
            ConfirmAnswerButton.Location = new Point(265, 372);
            ConfirmAnswerButton.Name = "ConfirmAnswerButton";
            ConfirmAnswerButton.Size = new Size(121, 23);
            ConfirmAnswerButton.TabIndex = 1;
            ConfirmAnswerButton.Text = "Confrim Answer";
            ConfirmAnswerButton.UseVisualStyleBackColor = true;
            ConfirmAnswerButton.MouseClick += ConfirmAnswerButton_MouseClick;
            // 
            // OptionPanel
            // 
            OptionPanel.Location = new Point(94, 55);
            OptionPanel.Name = "OptionPanel";
            OptionPanel.Size = new Size(620, 300);
            OptionPanel.TabIndex = 2;
            // 
            // FeedbackLabel
            // 
            FeedbackLabel.AutoSize = true;
            FeedbackLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FeedbackLabel.Location = new Point(505, 374);
            FeedbackLabel.Name = "FeedbackLabel";
            FeedbackLabel.Size = new Size(83, 21);
            FeedbackLabel.TabIndex = 3;
            FeedbackLabel.Text = "Is Correct?";
            // 
            // QuestionNumberLabel
            // 
            QuestionNumberLabel.AutoSize = true;
            QuestionNumberLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuestionNumberLabel.Location = new Point(97, 24);
            QuestionNumberLabel.Name = "QuestionNumberLabel";
            QuestionNumberLabel.Size = new Size(22, 20);
            QuestionNumberLabel.TabIndex = 4;
            QuestionNumberLabel.Text = "1)";
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(QuestionNumberLabel);
            Controls.Add(FeedbackLabel);
            Controls.Add(OptionPanel);
            Controls.Add(ConfirmAnswerButton);
            Controls.Add(QuestionLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuizForm";
            Text = "Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label QuestionLabel;
        private Button ConfirmAnswerButton;
        private Panel OptionPanel;
        private Label FeedbackLabel;
        private Label QuestionNumberLabel;
    }
}