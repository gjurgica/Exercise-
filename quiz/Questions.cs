using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    public class Questions
    {
        public string Question { get; set; }
        public string First { get; set; }
        public string Second { get; set; }
        public string Third { get; set; }
        public string Fourth { get; set; }
        public Questions(string question,string first,string second,string third,string fourth)
        {
            Question = question;
            First = first;
            Second = second;
            Third = third;
            Fourth = fourth;
        }
    }
}
