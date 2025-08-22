using Exam01.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01.Exam
{
    internal abstract class BaseClassExam
    {

        #region Attributes
        public int TimeOfExam { get; set; }
        public int NumberOfQuestion { get; set; }

       public BaseQuestion[] Questions { get; set; }

        #endregion

        #region constructor
        protected BaseClassExam(int timeOfExam, int numberOfQuestion)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestion = numberOfQuestion;
            Questions = new BaseQuestion[NumberOfQuestion];
        }
        #endregion

        #region Methods
        public abstract void ShowExam();

        #endregion
    }
}
