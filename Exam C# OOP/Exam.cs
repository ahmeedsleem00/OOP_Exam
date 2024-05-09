using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C__OOP
{
    internal abstract class Exam
    {
        internal int NumOfQuestion;

        public Stopwatch Stopwatch { get; set; }

        public int time { get; set; }
        public int NumberOfQuestion { get; set; }
    
        public QuestionBase[] QuestionList { get; set; }

        public virtual void StopWatch()
        {
            Stopwatch = Stopwatch.StartNew();
        }
        public abstract void CreateExam(int NumOfQuestion);

        public abstract void ShowExam();
    }

    
}
