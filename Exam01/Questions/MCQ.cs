using Exam01.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01.Questions
{
    internal class MCQ : BaseQuestion
    {
        #region constructor
        public MCQ(string header, string body, decimal mark, Answer[] answers, Answer rightAnswer) : base(header, body, mark )
        {
             Answers = answers;
            RightAnswer = rightAnswer;
        }
        #endregion

        #region Method 
       
        #endregion
    }
}
