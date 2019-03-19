using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberStatus
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberMethods MyMethods = new NumberMethods();
            
            do
            {
                Console.WriteLine("Enter a number");
                string answer = Console.ReadLine();
                string ans = "";
                double number;
                bool sucess = double.TryParse(answer, out number);
                if (sucess)
                {
                    Console.WriteLine(MyMethods.PrintInConsole(number));
                }
                else
                {
                    Console.WriteLine("Your input is not valid.\nDo you want to try again?\nIf ansewr is yes press Y for no press N");

                    ans = Console.ReadLine();
                }
                if (ans.ToLower() == "y")
                {
                    continue;
                }
                else if (ans.ToLower() == "n")
                {
                    break;
                }
            } while (true);
        }
    }

    }

