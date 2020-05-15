using System;
using System.Collections.Generic;
using System.Text;

namespace TransLionApp.Controls
{
    public static class Admin
    {
        public static IList<Person> admins { get; private set; }

        static Admin()
        {
            admins = new List<Person>();
            admins.Add(new Person
            {
                Login = "admin",
                Password = "1111",
                Type = 1
            });
        }
    }
}
