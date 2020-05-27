using System;
using System.Collections.Generic;
using System.Text;

namespace TransLionApp.Data
{
    public static class UserData
    {
        public static IList<UserInfo> Users { get; private set; }

        static UserData()
        {
            Users = new List<UserInfo>();
            //выгружаем данные из таблицы User'ов

            Users.Add(new UserInfo { ID_inApp = 12, Login = "savahha", ID = 144, NamePerson = "Anna Savina", Password = "0000", Type = "user", LastDateOfWatching = new DateTime(2020, 5, 26, 19, 21, 0)});
            Users.Add(new UserInfo { Type = "user", Password = "0000", NamePerson = "Richard", ID = 777, Login = "rrr", ID_inApp = 90, LastDateOfWatching = new DateTime(2020, 5, 26, 13, 0, 0)});
        }
    }
}
