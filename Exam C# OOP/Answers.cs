using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C__OOP
{
    internal class Answers
    {
        public string AnswerTxt { get; set; }
        public int AnswerID { get; set; }

        public Answers(int answerId, string answerText)
        {
            AnswerID = answerId;

            AnswerTxt = answerText;

        }

        public Answers()
        {
        }

        public override string ToString()
        {
            return $"{AnswerID} :: {AnswerTxt}";
        }

        public static implicit operator Answers(int v)
        {
            throw new NotImplementedException();
        }
    }
}
