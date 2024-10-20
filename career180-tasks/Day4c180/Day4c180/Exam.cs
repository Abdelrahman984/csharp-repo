using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4c180
{
    public class Exam
    {
        public Dictionary<Question, List<Answer>> Questions { get; set; }

        public Exam()
        {
            Questions = new Dictionary<Question, List<Answer>>();
        }

        public void AddQuestion(Question question, List<Answer> answers)
        {
            Questions.Add(question, answers);
        }

        public void PrintExam()
        {
            foreach (var questionEntry in Questions)
            {
                Console.WriteLine(questionEntry.Key);
                foreach (var answer in questionEntry.Value)
                {
                    Console.WriteLine("  " + answer);
                }
            }
        }
    }
}
