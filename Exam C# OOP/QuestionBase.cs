using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C__OOP
{
    internal class QuestionBase
    {
        public QuestionBase() { }

        public string Header {  get; set; }
        public string BodyOfQuestion { get; set; }
        public int Marks { get; set; }

        public Answers[] answers { get; set; }

        public int Correct_Answers {  get; set; }

        public QuestionBase (string _HeaderOfQuestion, string _BodyOfQuestion, int _Marks, Answers[] _answers,int _CorrectAnswers)
        {
            this.Header = _HeaderOfQuestion;
            this.BodyOfQuestion = _BodyOfQuestion;
            this.Marks = _Marks;
            this.answers = _answers;
            this.Correct_Answers = _CorrectAnswers;
        }


  
        public override string ToString()
        {
            return $"{BodyOfQuestion} , Your Mark: {Marks}";
        }
    }
}
