using Exam01.Questions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exam01.Exam
{
    internal class FinalExam : BaseClassExam
    {


        #region constructor
        public FinalExam(int timeOfExam, int numberOfQuestion) : base(timeOfExam, numberOfQuestion)
        {

        }

        #endregion

        #region Method

        public override void ShowExam()
        {
            #region first way
            //    decimal totalMarks = 0;
            //    int AnswerID = 0;
            //    decimal allmarks = 0;
            //    int[] answersID = new int[4];
            //    for (int i = 0 ; i < Questions.Length ; i++)
            //    {
            //        Questions[i].showQuestion();
            //        Console.WriteLine("enter the answer Id : ");
            //        while (!int.TryParse(Console.ReadLine(), out AnswerID) || (AnswerID > 4 || AnswerID < 1))
            //        {
            //            Console.WriteLine("Id must be between 1 to 4 ");
            //            continue;
            //        }
            //        if (Questions[i].RightAnswer.AnswerId == AnswerID)
            //        {
            //            answersID[i] = AnswerID - 1;
            //            totalMarks += Questions[i].Mark;
            //            allmarks += Questions[i].Mark;
            //        }

            //            Console.Clear();
            //    }
            //    Console.Clear();
            //    for(int i = 0; i < Questions.Length; i++)
            //    {
            //        Console.WriteLine($"{Questions[i].Body}");
            //        Console.WriteLine($"Right answer is : {Questions[i].RightAnswer.AnswerText}");
            //        Console.WriteLine($"your answer is : {Questions[i].Answers[answersID[i]].AnswerText}");
            //        Console.WriteLine($"your grade is : {totalMarks} / {allmarks} ");

            //        Console.WriteLine();
            //    }
            //    Console.WriteLine($"Your total marks is : {totalMarks}"); 
            #endregion

            decimal totalMarks = 0;
            int AnswerID = 0;
            decimal allmarks = 0;
            int[] answersID = new int[Questions.Length];   // make same size as Questions
            DateTime start = DateTime.Now;

            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i].showQuestion();
                Console.WriteLine("enter the answer Id : ");

                while (!int.TryParse(Console.ReadLine(), out AnswerID) || (AnswerID > 4 || AnswerID < 1))
                {
                    Console.WriteLine("Id must be between 1 to 4 ");
                }

                answersID[i] = AnswerID - 1;
                allmarks += Questions[i].Mark;

                if (Questions[i].RightAnswer.AnswerId == AnswerID)
                {
                    totalMarks += Questions[i].Mark;
                }

                Console.Clear();
            }
          
            DateTime end = DateTime.Now;
            TimeSpan duration = end - start;

            Console.Clear();
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"{Questions[i].Body}");
                Console.WriteLine($"Right answer is : {Questions[i].RightAnswer.AnswerText}");
                Console.WriteLine($"Your answer is : {Questions[i].Answers[answersID[i]].AnswerText}");
                Console.WriteLine();
            }

                Console.WriteLine($"You finished the exam in {duration.Minutes} minutes and {duration.Seconds} seconds.");
                Console.WriteLine($"Your grade is : {totalMarks} / {allmarks}");
                Console.WriteLine("thank you");

        }

        #endregion
    }
}
