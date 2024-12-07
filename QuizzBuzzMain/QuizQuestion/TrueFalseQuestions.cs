using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzBuzzMain.QuizQuestion
{
    internal class TrueFalseQuestions : IQuestionType
    {
        public string QuestionText { get; set; }
        public bool CorrectAnswer { get; set; } // True or False

        public bool IsCorrect(string userAnswer)
        {
            if (bool.TryParse(userAnswer, out bool parsedAnswer))
            {
                return parsedAnswer == CorrectAnswer;
            }
            return false;
        }

        public List<string> GetOptions()
        {
            return new List<string> { "True", "False" };
        }
    }
}
