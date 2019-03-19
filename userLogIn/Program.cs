using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userLogIn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for Log in and 2 for Register");
            string logOrReg = Console.ReadLine();
            User[] users = new User[5];
            users[0] = new User(23, "gjurgica", "nesto");
            users[1] = new User(5, "ivica", "drugo");
            users[2] = new User(77, "slavica", "blabla");
            users[3] = new User(75, "usko", "hah");
            users[4] = new User(34, "violeta", "pasta");
            if (logOrReg == "1")
            {
                Console.WriteLine(LogIn(users));
                Console.ReadLine();
            }
            else if (logOrReg == "2")
            {
                Console.WriteLine(Register(users));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid input.Try again.");
                logOrReg = Console.ReadLine();
            }
        }
        public static  string LogIn(User[] users)
        {
            do
            {
                Console.WriteLine("Enter your user name");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();
                foreach(var user in users)
                {
                    if(userName.ToLower() == user.UserName.ToLower() && password == user.Password)
                    {
                        return user.Messages[0];
                    }
                }
                Console.WriteLine(users[0].Messages[1]);
            } while (true);
            
        }
        public static string Register(User[] users)
        {
            do
            {
                Console.WriteLine("Enter your Id");
                string answer = Console.ReadLine();
                int id = int.Parse(answer);
                string userName = "";
                string password = "";
                foreach(var user in users)
                {
                    if (id == user.Id)
                    {
                        Console.WriteLine("This Id is already taken");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter your user name");
                        userName = Console.ReadLine();
                        if(userName == user.UserName)
                        {
                            Console.WriteLine("This user name is already taken");
                            break;
                        }
                    }
                            Console.WriteLine("Enter your password");
                            password = Console.ReadLine();
                            Array.Resize(ref users, users.Length + 1);
                            users[users.Length - 1] = new User(id, userName, password);
                            string print = "Registration complete!\n Users:\n";
                            foreach (var newuser in users)
                            {
                                print += $" {newuser.Id}   {newuser.UserName}\n";
                            }
                            return print;
                    
                }
            } while (true);
        }
    }
}
