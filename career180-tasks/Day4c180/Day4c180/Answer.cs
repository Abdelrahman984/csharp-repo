using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4c180
{
    public class Answer
    {
        public int Num { get; set; }
        public string Choose { get; set; }

        public Answer(int num, string choose)
        {
            Num = num;
            Choose = choose;
        }

        public override string ToString()
        {
            return $"Answer: {Num}, Choose: {Choose}";
        }


    }
}
