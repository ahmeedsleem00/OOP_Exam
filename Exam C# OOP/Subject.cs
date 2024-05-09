using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C__OOP
{
    internal class Subject
    {
        public string SubjectName { get; set; }
        public int SubjectID {  get; set; }
        public Exam Exam { get; set; }

        public Exam SubjectOfExam { get; set; }
        public Subject() { }


        public Subject(int subjectId, string subjectName)
        {
            SubjectID = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExams()
        {
            Console.Write("Please Enter The Type Of Exam You Want To Create (1 for Practical , 2 for Final ) : ");
            int input = int.Parse(Console.ReadLine());

            if(input == 1)
            {
                Console.Write("Please Enter The Time Of The Exam (Minuts): ");
                int PracticeMin = int.Parse(Console.ReadLine());

                Console.Write("Please Enter Number Of Question: ");
                int NumOfQuestion = int.Parse(Console.ReadLine());
                Console.Clear();

                SubjectOfExam = new PracticalExam();
                SubjectOfExam.time = PracticeMin;
                SubjectOfExam.NumberOfQuestion = NumOfQuestion;
                SubjectOfExam.CreateExam(NumOfQuestion);
                // The Practical Exam :
            }
            else if(input == 2)
            {
                Console.Write("Please Enter The Time of Exam (Minuts): ");
                int PracticeMin = int.Parse(Console.ReadLine());
                Console.Write("Please Enter Number Of Question: ");
                int NumOfQuestion = int.Parse(Console.ReadLine());
                Console.Clear();

                SubjectOfExam = new FinalExam();
                SubjectOfExam.NumberOfQuestion = NumOfQuestion;
                SubjectOfExam.time = PracticeMin;
                SubjectOfExam.CreateExam(NumOfQuestion);
             
            }
            else
            {
                Console.WriteLine("Please Try Again Later!");
            }
        }
    }
}
