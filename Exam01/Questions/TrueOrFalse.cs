using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01.Questions
{
    internal class TrueOrFalse : BaseQuestion
    {
        #region constructor
        public TrueOrFalse(string header, string body, decimal mark , Answer[] answers, Answer rightAnswer) : base(header, body, mark)
        {
            Answers = answers;
            RightAnswer = rightAnswer;
        }
        #endregion

        #region Method
      
        #endregion

    }
}
