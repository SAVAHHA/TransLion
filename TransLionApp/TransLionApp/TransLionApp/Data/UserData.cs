﻿using System;
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

            Users.Add(new UserInfo { ID_inApp = 12, Login = "savahha", ID = 144, NamePerson = "Anna", SurnamePerson = "Savina", Password = "0000", Type = "user", Postcode="1234HH", BirthDate="17 maart 1974", Address="Gerarduslaan 34", City="Rotterdam", Email="savinaanna@gmail.com", Phone="89169111930", LastDateOfWatching = new DateTime(2020, 5, 26, 19, 21, 0)});
            Users.Add(new UserInfo { Type = "user", Password = "0000", NamePerson = "Richard", SurnamePerson = "Banks", ID = 777, Login = "rrr", ID_inApp = 90, LastDateOfWatching = new DateTime(2020, 5, 26, 13, 0, 0)});
        }
    }
}
