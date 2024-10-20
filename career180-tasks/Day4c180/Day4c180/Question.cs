using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4c180
{
    public class Question
    {
        public string QuestionBody { get; set; }
        public int Mark { get; set; }
        public Question(string questinBody,int mark )
        {
            this.QuestionBody = questinBody;
            this.Mark = mark;
        }
        public override string ToString()
        {
            return $"Question: {QuestionBody}, Mark: {Mark}";
        }
    }
}
