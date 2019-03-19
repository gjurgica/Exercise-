using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    public class Answers
    {
        public bool A { get; set; }
        public bool B { get; set; }
        public bool C { get; set; }
        public bool D { get; set; }
        public Answers(bool first,bool second,bool third,bool fourth)
        {
            A = first;
            B = second;
            C = third;
            D = fourth;
        }
    }
}
