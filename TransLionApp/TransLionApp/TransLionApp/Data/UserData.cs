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

            //List<Person> Persons = new List<Person>();
            //Persons = App.Database.GetUsersAsync().Result;
            //foreach (var item in Persons)
            //{
            //    Users.Add(new UserInfo
            //    {
            //        ID = item.ID,
            //        Login = item.Login,
            //        NamePerson = item.NamePerson,
            //        Password = item.Password,
            //        Type = item.Type,
            //        Postcode = item.Postcode,
            //        Phone = item.Phone,
            //        ID_inApp = item.ID_inApp,
            //        LastDayOfSickness = item.LastDayOfSickness,
            //        FirstDayOfSickness = item.FirstDayOfSickness,
            //        LastGuidanceDay = item.LastGuidanceDay,
            //        Email = item.Email

            //    });
            //}

            Users.Add(new UserInfo { ID_inApp = 12, Login = "savahha", ID = 144, NamePerson = "Anna", SurnamePerson = "Savina", Password = "0000", Type = "user", Postcode = "1234HH", BirthDate = "17 maart 1974", Address = "Gerarduslaan 34", City = "Rotterdam", Email = "savinaanna@gmail.com", Phone = "89169111930", LastDayOfSickness = new DateTime(2020, 5, 26, 19, 21, 0), FirstDayOfSickness = new DateTime(2019, 3, 13, 10, 30, 0), LastGuidanceDay = new DateTime(2019, 3, 14, 9, 0, 0), LastDateOfWatching = new DateTime(2020, 5, 29, 10, 11, 0) });
            Users.Add(new UserInfo { Type = "user", Password = "0000", NamePerson = "Anna", SurnamePerson = "Kleschenko", ID = 777, Login = "annak", ID_inApp = 91, LastDayOfSickness = new DateTime(2020, 5, 26, 13, 0, 0), FirstDayOfSickness = new DateTime(2020, 4, 14, 10, 30, 0), LastGuidanceDay = new DateTime(2020, 4, 11, 8, 0, 0) });
            Users.Add(new UserInfo { Type = "user", Password = "0001", NamePerson = "Richard", SurnamePerson = "Banks", ID = 777, Login = "rrr", ID_inApp = 90, LastDayOfSickness = new DateTime(2020, 5, 26, 13, 0, 0) });
        }

        private static async void UpdateDatabase()
        {
            await App.Database.SaveUserAsync(new Person { ID_inApp = 12, Login = "savahha", ID = 144, NamePerson = "Anna", Password = "0000", Type = "user", Postcode = "1234HH", BirthDate = "17 maart 1974", Address = "Gerarduslaan 34", City = "Rotterdam", Email = "savinaanna@gmail.com", Phone = "89169111930", LastDayOfSickness = new DateTime(2020, 5, 26, 19, 21, 0), FirstDayOfSickness = new DateTime(2019, 3, 13, 10, 30, 0), LastGuidanceDay = new DateTime(2019, 3, 14, 9, 0, 0) });
        }
    }
}
