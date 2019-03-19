using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberStatus
{
    class NumberMethods
    {
        private string PositiveOrNegative(double num)
        {
            if (num < 0)
            {
                return "Negative";
            }
            else
            {
                return "Positive";
            }
        }
        private  string OddOrEven(double num)
        {
            if (num % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
        private string DecimalOrInteger(double num)
        {
            // num = num < 0 ? num = num * -1 : num;
            double number = Math.Floor(num);
            if (num > number)
            {
                return "Decimal";
            }
            else
            {
                return "Integer";
            }
        }
        public  string PrintInConsole(double num)
        {
            return $"Status for number: {num}\n{PositiveOrNegative(num)}\n{OddOrEven(num)}\n{ DecimalOrInteger(num)}";
        }
    }
}
