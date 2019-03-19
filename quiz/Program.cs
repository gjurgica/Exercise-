using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[3];
            users[0] = new User("gjurgica", 55);
            users[1] = new User("nikola", 50);
            users[2] = new User("jovana", 40);
            Console.WriteLine("Enter your user name");
            string userName = Console.ReadLine();
            Questions[] questions = new Questions[11];
            questions[0] = new Questions("Which of the variable types is not a C# variable type?", "a) int", "b) var", "c) let", "d) string");
            questions[1] = new Questions("If we declare an int variable in C# without initialization what efault value will it get?", "a) undefined", "b) 0", "c) null", "d) cant declare variable without initialization");
            questions[2] = new Questions("If we declare an var variable in C# without initialization what value will it get?", "a) undefined", "b) 0", "c) null", "d) cant declare var without initialization");
            questions[3] = new Questions("Which declaration/intialization of the offered is not possible?", "a) var random = \"Hello World\"", "b) int number = 3", "c) int string = int.Parse(\"4\")", "d) random = number");
            questions[4] = new Questions(" How do we initialize a new empty int array?", "a) int[] arr = []", "b) int[] arr = new int[]", "c) int[] arr = new int[] {}", "d) int[] arr = new int[2]");
            questions[5] = new Questions("Which of the array declarations is incorrect?", "a) int[] arr = new int[] { 1, 2, 3, 4 }", "b) char[] arr = { 'a', 'b', 'c', 'd' }", "c) var[] arr = new var[] { 1, \"2\", 'c', [1, 2] }", "d) int[][] arr = { new int[] { 1, 2 }, new int[] { 3, 4 } }");
            questions[6] = new Questions("Which of the method signatures is correct?", "a) public string sayMyName(string name, string lastName)", "b) private sayMyName(string name, string lastName)", "c) public string SayMyName(name, lastName)", "d) public string SayMyName(string name, string lastName)");
            questions[7] = new Questions("Can we have more that one method with the same name?", "a) No, this is not possible in C#", "b) Yes, but the access modifier needs to be different", "c) No, becase the name is already used", "d) Yes, but we must declare the new method with different set of parameters");
            questions[8] = new Questions("We use classes to instantiate objects in C#, which method does the class use to create our object?", "a) the constructor method", "b) it doesn't use any method", "c) the create new object method", "d) the initializator method");
            questions[9] = new Questions(" If we dont have a constructor declared in our class, what does the class use to create the new object?", "a) it cannot be done", "b) it will create our object but we cannot set any values to the porperties, ever", "c) the default empty constructor", "d) it orders it from AliExpress");
            questions[10] = new Questions("How do we declare a constructor method?", "a) constructor(name, lastName)", "b) new constructor(string name, string lastName)", "c) private ClassName(string name, string lastName)", "d) public ClassName(string name, string lastName)");
            Answers[] answers = new Answers[11];
            answers[0] = new Answers(false, false, true, false);
            answers[1] = new Answers(false, true, false, false);
            answers[2] = new Answers(false, false, false, true);
            answers[3] = new Answers(false, false, false, true);
            answers[4] = new Answers(false, false, true, true);
            answers[5] = new Answers(false, false, true, false);
            answers[6] = new Answers(true, false, false, true);
            answers[7] = new Answers(false, false, false, true);
            answers[8] = new Answers(true, false, false, false);
            answers[9] = new Answers(false, false, true, false);
            answers[10] = new Answers(false, false, false, true);
            int count = 1;
            int score = 0;
            for(var i=0;i<questions.Length;i++)
            {
                Console.WriteLine($"{count++}.{questions[i].Question}:\n{questions[i].First}\n{questions[i].Second}\n{questions[i].Third}\n{questions[i].Fourth}");
                string answer = Console.ReadLine();
                if (answers[i].A == true && answer.ToLower() == "a")
                {
                    Console.WriteLine("Correct answer");
                    score += 5;
                }
                else if (answers[i].B == true && answer.ToLower() == "b")
                {
                    Console.WriteLine("Correct answer");
                    score += 5;
                }
                else if (answers[i].C == true && answer.ToLower() == "c")
                {
                    Console.WriteLine("Correct answer");
                    score += 5;
                }
                else if (answers[i].D == true && answer.ToLower() == "d")
                {
                    Console.WriteLine("Correct answer");
                    score += 5;
                }
                else
                {
                    Console.WriteLine("Wrong answer");
                }

            }
            Console.WriteLine($"YOURE SCORE IS: {score}");
            Console.ReadLine();
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = new User(userName, score);
            Array.Sort(users, delegate (User user1, User user2)
             {
                 return user1.Score.CompareTo(user2.Score);
             });
            string print = "Registration complete!\n Users:\n";
            for (var i= users.Length-1;i>=0;i--)
            {
                    print += $" {users[i].UserName} Your score is:  {users[i].Score}\n";
                
            }

            Console.WriteLine(print);
            Console.ReadLine();
        }
    }
}
