using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exam_C__OOP
{
    internal class FinalExam : Exam
    {
        public int Grade { get; set; }

        public FinalExam() { }

        public override void CreateExam(int NumberOfQuestions)
        {
            QuestionList = new QuestionBase[NumberOfQuestions];

            for(int i = 0;  i < NumberOfQuestions; i++)
            {
                Console.Clear();
                Console.Write($"Please Choose Type Of Question {i + 1}(1 for True and False , 2 for MCQ) : ");
                int Type_Of_Question = int.Parse( Console.ReadLine() );
                Console.Clear();

                if ( Type_Of_Question == 1 )
                {
                    Console.WriteLine("Choose one Answer Question\nPlease Enter The Body Of Question : ");
                    string BodyOfQuestion = Console.ReadLine();

                    Console.WriteLine("Please Enter Mark Of The Question : ");
                    int Marks = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please Enter The Right Answer (1 for True , 2 for False) : ");
                    int TheRightAnswer = int.Parse(Console.ReadLine());

                    QuestionBase question = new QuestionBase();

                    question.answers = new Answers[2];
                    question.answers[0] = new Answers();
                    question.answers[0].AnswerTxt = "True";
                    question.answers[0].AnswerID = 1;
                    question.answers[1] = new Answers();
                    question.answers[1].AnswerID = 2;
                    question.answers[1].AnswerTxt = "False";

                    question = Create_Question("True or False", BodyOfQuestion, Marks, TheRightAnswer, question.answers);
                    QuestionList[i] = question;
                    Console.Clear();
    
                }
                else if( Type_Of_Question == 2 )
                {
                    Console.WriteLine("Choose one Answer Question\nPlease Enter The Body Of Question: ");
                    string BodyOfQuestion = Console.ReadLine();

                    Console.WriteLine("Please Enter Mark Of The Question: ");
                    int Marks = int.Parse(Console.ReadLine());
                    QuestionBase question = new QuestionBase();
                    question.answers = new Answers[3];

                    for (int n = 0; n < 3; n++)
                    {
                        Console.WriteLine($"Please Enter Choice Number {n + 1} : ");
                        string answer = Console.ReadLine();

                        question.answers[n] = new Answers();
                        question.answers[n].AnswerTxt = answer;
                        question.answers[n].AnswerID = n + 1;

                    }

                    Console.WriteLine("Please Enter The Right Answer : ");
                    int TheRightAnswer = int.Parse(Console.ReadLine());
                    question = Create_Question("True or False", BodyOfQuestion, Marks, TheRightAnswer , question.answers);
                    QuestionList[i] = question;
                    //The MCQ Question
                }
                else
                {
                    Console.WriteLine("Invalid. Please Try Again");
                }
            }
        }
        public static QuestionBase Create_Question(string HeadOfQuestion, string Body_Of_Question, int Marks, int TheRightAnswer, Answers[] answers)
        {
            QuestionBase question = new QuestionBase(HeadOfQuestion, Body_Of_Question, Marks, answers , TheRightAnswer);
            return question;
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam:");

            for(int i = 0; i < QuestionList.Length; i++)
            {
                Console.WriteLine("Header Of Question: " + QuestionList[i].answers);
                Console.WriteLine("Question: " + QuestionList[i].BodyOfQuestion);
                foreach(var answers in QuestionList[i].answers)
                {
                    Console.WriteLine(answers.AnswerID + " " + answers.AnswerTxt + " ");
                }
                Console.WriteLine("\n Write Answer : ");
                int User_Answer = int.Parse(Console.ReadLine());
                if(User_Answer == QuestionList[i].Correct_Answers)
                {
                    Grade = Grade + QuestionList[i].Marks;
                }
                Console.WriteLine();
            }
            for(int i = 0;i < QuestionList.Length;i++)
            {
                Console.WriteLine($"Number Of Question {i + 1} : " + QuestionList[i].BodyOfQuestion);
                
                Console.WriteLine($"The Correct Answer : {QuestionList[i].Correct_Answers}");
            }
            Console.WriteLine("Your Grade : " + Grade);
        }
    }
}
