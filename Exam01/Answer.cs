﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    internal class Answer
    {
      
        #region Attributes
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }
        #endregion

        #region Constructor
        public Answer(int answerId, string? answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
        #endregion


        public override string ToString()
        {
            return $"{AnswerId} : {AnswerText}";
        }
    }
}
