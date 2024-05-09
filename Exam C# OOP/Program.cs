using System;
using System.Diagnostics;

namespace Exam_C__OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(10, "C#");

            subject.CreateExams();

            Console.Clear();

            Console.WriteLine("Do You Want To Start Exam (Y | N) : ");

            if(char.Parse(Console.ReadLine()) == 'y')
            {
                Console.Clear() ;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                subject.SubjectOfExam.ShowExam();
                Console.WriteLine($"Elapsed Time {stopwatch.Elapsed}");
            }
            else if( char.Parse(Console.ReadLine()) == 'n')
            {
                Console.WriteLine("Thank you");
            }
            else
            {
                Console.WriteLine("Wrong Input, Try Again");
            }

        }
    }
}
