using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzBuzzMain.QuizQuestion
{
    internal class MultipleChoiceQuestion : IQuestionType
    {
        public string QuestionText { get; set; }
        public List<string> Options { get; set; } 
        public string CorrectAnswer { get; set; }

        public bool IsCorrect(string userAnswer)
        {
            return CorrectAnswer.Equals(userAnswer, StringComparison.OrdinalIgnoreCase);
        }

        public List<string> GetOptions()
        {
            return Options;
        }
    }
}
