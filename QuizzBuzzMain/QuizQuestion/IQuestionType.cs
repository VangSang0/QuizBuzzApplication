using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzBuzzMain.QuizQuestion
{
    public interface IQuestionType
    {
        string QuestionText { get; set; }
        bool IsCorrect(string userAnswer);
        List<string> GetOptions(); 
    }
}
