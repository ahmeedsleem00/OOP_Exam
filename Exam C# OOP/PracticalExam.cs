using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C__OOP
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(){}

        public override void CreateExam(int NumberOfQuestions)
        {
            QuestionList = new QuestionBase[NumberOfQuestions];
            for (int i = 0; i< NumberOfQuestions; i++)
            {
                Console.WriteLine("You Chose Practical Exam:");
                Console.WriteLine("Choose one Answer Question ");
                Console.WriteLine("Please Enter The Body Of Question: ");
               Console.WriteLine();
                string BodyOfQuestion = Console.ReadLine();

                Console.WriteLine("Please Enter Mark Of The Question: ");
                int Marks = int.Parse(Console.ReadLine());

                QuestionBase question = new QuestionBase();
                Console.WriteLine("Choices of Three Questions Are: ");

                question.answers = new Answers[3];
                for(int n = 0; n < 3; n++)
                {
                    Console.WriteLine($"Please Enter Choice Number {n+1} : " );

                    string answer = Console.ReadLine();
                    question.answers[n] = new Answers();
                    question.answers[n].AnswerTxt = answer;
                    question.answers[n].AnswerID = n + 1;
                }
                Console.WriteLine("Please Enter The Right Answer : ");

                int TheRightAnswer = int.Parse(Console.ReadLine());
                question = CreateQuestion("MCQ",BodyOfQuestion, TheRightAnswer, Marks, question.answers);
                QuestionList[i] = question;
                Console.Clear();
            
            } 

        }

        public QuestionBase CreateQuestion(string Header, string BodyOfQuestion, int Marks, int Correct_Answers, Answers[] answers)
        {
            QuestionBase question = new QuestionBase(Header, BodyOfQuestion, Marks, answers, Correct_Answers);
            Console.Clear();
            return question;
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam: ");
            for (int j = 0; j < QuestionList.Length; j++)
            {
                Console.WriteLine("Header Of Question: " + QuestionList[j].Header);
                Console.WriteLine("Question: " + QuestionList[j].BodyOfQuestion);
                Console.WriteLine("Answers Of Questions: ");

                foreach (var answer in QuestionList[j].answers)
                {
                    Console.WriteLine(answer.AnswerID + " )" + answer.AnswerTxt );
                }
                Console.WriteLine("\nWrite Your Answer :");
                int UserAnswer = int.Parse(Console.ReadLine());
                if (UserAnswer != 0)
                {
                    Console.WriteLine($"Correct Answer Number Is {j + 1} : " + QuestionList[j].answers);

                }
                Console.WriteLine();
            }

        }
    }
}

