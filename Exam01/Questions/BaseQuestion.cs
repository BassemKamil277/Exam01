using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01.Questions
{
    internal abstract class BaseQuestion
    {
      
        #region Attributes
        public string?  Head { get; set; }
        public string? Body { get; set; }
        public decimal Mark { get; set; }
        public Answer[]? Answers { get; set; } 
        public Answer? RightAnswer { get; set; } 
        #endregion

        #region constructor
        public BaseQuestion(string? head, string? body, decimal mark)
        {
            Head = head;
            Body = body;
            Mark = mark;
        }
        #endregion

        #region Methods
        public void showQuestion()
        {
            Console.WriteLine($"Head : {Head}\nBody: {Body}\nMark: {Mark}");
            Console.WriteLine();
            foreach (var item in Answers)
            {
                Console.WriteLine($"{item.AnswerId} , {item.AnswerText}");
            }
        }

        public override string ToString()
        {
            return $"{Head}\n{Body}\n{Mark}";
        }
        #endregion

    }
}
