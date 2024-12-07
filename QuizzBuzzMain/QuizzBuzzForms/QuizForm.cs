using QuizzBuzzMain.QuizQuestion;
using QuizzBuzzMain.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzBuzzMain.QuizzBuzzForms
{
    public partial class QuizForm : Form
    {
        private FormManager formManager;
        private List<IQuestionType> questions;
        private int currentQuestionIndex = 0;
        private int currentQuestionCount = 1;
        private int correctAnswers = 0;
        private IQuestionType currentQuestion = null!;
        ListViewItem currentStudySet;

        public QuizForm(List<IQuestionType> questions, ListViewItem studySet)
        {
            InitializeComponent();
            this.questions = questions;
            LoadQuestion();
            currentStudySet = studySet;
            formManager = new FormManager();
        }
        private void LoadQuestion()
        {
            if (currentQuestionIndex >= questions.Count)
            {
                MessageBox.Show($"Quiz Complete!\nYou answered {correctAnswers} out of {questions.Count} correctly!",
                        "Quiz Results",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                IndividualStudySet individualStudySet = new IndividualStudySet(currentStudySet);
                formManager.SwitchForm(QuizBuzzMain.MainPanel, individualStudySet);
                return;
            }
            
            QuestionNumberLabel.Text = currentQuestionCount.ToString() + ")";
            currentQuestion = questions[currentQuestionIndex];
            QuestionLabel.Text = currentQuestion.QuestionText;

            OptionPanel.Controls.Clear();

            var options = currentQuestion.GetOptions();
            if (options != null)
            {
                int y = 10;
                foreach (var option in options)
                {
                    var radioButton = new RadioButton
                    {
                        Text = option,
                        Location = new Point(10, y),
                        AutoSize = true,
                        Width = OptionPanel.Width - 20,  
                        Height = 40,  
                        TextAlign = ContentAlignment.MiddleLeft,
                        MaximumSize = new Size(OptionPanel.Width - 20, 0)
                    };
                    OptionPanel.Controls.Add(radioButton);
                    y += 30;
                }
            }
            else
            {
                var trueOption = new RadioButton { Text = "True", Location = new Point(10, 10), AutoSize = true };
                var falseOption = new RadioButton { Text = "False", Location = new Point(10, 40), AutoSize = true };
                OptionPanel.Controls.Add(trueOption);
                OptionPanel.Controls.Add(falseOption);
            }
        }
        private void ConfirmAnswerButton_MouseClick(object sender, EventArgs e)
        {
            var selectedOption = OptionPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text;

            if (string.IsNullOrEmpty(selectedOption))
            {
                MessageBox.Show("Please select an answer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (currentQuestion.IsCorrect(selectedOption))
            {
                FeedbackLabel.Text = "Correct!";
                FeedbackLabel.ForeColor = Color.Green;
                correctAnswers++;
            }
            else
            {
                FeedbackLabel.Text = "Wrong!";
                FeedbackLabel.ForeColor = Color.Red;
            }

            FeedbackLabel.Visible = true;
            Task.Delay(1000).ContinueWith(_ =>
            {
                this.Invoke(new Action(() =>
                {
                    FeedbackLabel.Visible = false;
                    currentQuestionIndex++;
                    currentQuestionCount++;
                    LoadQuestion();
                }));
            });
        }
    }
}
