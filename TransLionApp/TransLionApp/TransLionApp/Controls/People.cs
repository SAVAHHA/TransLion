using System;
using System.Collections.Generic;
using System.Text;

namespace TransLionApp.Controls
{
    public class People
    {
        public static IList<Person> people { get; set; }

        public People(string login, string password, int type)
        {
            people.Add(new Person { Login = login, Password = password, Type = type });
        }
    }
}
