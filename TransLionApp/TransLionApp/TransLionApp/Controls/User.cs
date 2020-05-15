using System;
using System.Collections.Generic;
using System.Text;

namespace TransLionApp.Controls
{
    public static class User
    {
        public static IList<Person> users { get; private set; }

        static User()
        {
            users = new List<Person>();

            users.Add(new Person
            {
                Login = "user",
                Password = "2222",
                Type = 2
            });
        }
    }
}
