using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userLogIn
{
    class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; } = new string[3];

        public User(int id, string userName, string pass)
        {
            Id = id;
            UserName = userName;
            Password = pass;
            Messages[0] = $"Welcome {UserName}";
            Messages[1] = "Wrong data. Try again.Enter your user name and password again";
            Messages[2] = "This data is taken. Enter your data again.";
        }
    }
}
