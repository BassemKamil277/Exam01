using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01.Exam
{
    internal class PracticalExam : BaseClassExam
    {
        #region Constructor
        public PracticalExam(int timeOfExam, int numberOfQuestion) : base(timeOfExam, numberOfQuestion)
        {

        }


        #endregion


        #region Method
        public override void ShowExam()
        {
            decimal totalMarks = 0;
            int AnswerID = 0;
            int[] answersID = new int[Questions.Length];
            //foreach (var item in Questions)
            //{
            //    item.showQuestion();
            //    Console.WriteLine("enter the answer Id : ");
            //    while (!int.TryParse(Console.ReadLine(), out AnswerID) || (AnswerID > 4 || AnswerID < 1))
            //    {
            //        Console.WriteLine("Id must be between 1 to 4 ");
            //        continue;
            //    }

            //if (item.RightAnswer.AnswerId == AnswerID)
            //{
            //    totalMarks += item.Mark;
            //}
            //Console.Clear();

            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i].showQuestion();
                Console.WriteLine("enter the answer Id : ");

                while (!int.TryParse(Console.ReadLine(), out AnswerID) || (AnswerID > 4 || AnswerID < 1))
                {
                    Console.WriteLine("Id must be between 1 to 4 ");
                }

                answersID[i] = AnswerID - 1;
            }
            Console.Clear();

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Your answer is : {Questions[i].Answers[answersID[i]].AnswerText}");
                Console.WriteLine($"Right answer is : {Questions[i].RightAnswer.AnswerText}");
                Console.WriteLine("thank you");
            }
            Console.WriteLine();
        }
    

        #endregion
    }
}
