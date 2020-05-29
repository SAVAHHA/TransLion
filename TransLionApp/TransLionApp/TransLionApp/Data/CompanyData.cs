using System;
using System.Collections.Generic;
using System.Text;

namespace TransLionApp.Data
{
    public class CompanyData
    {
        public static IList<CompanyInfo> Companies { get; private set; }

        static CompanyData()
        {
            Companies = new List<CompanyInfo>();
            //выгружаем данные из таблицы User'ов

            Companies.Add(new CompanyInfo { ID_inApp = 12, Contact = "Elena Volkova", ID = 144, Name = "X", PostCode = "426039", EMail = "lenavolkova99@mail.ru", Address = "Sanochnaya 20", City = "Izhevsk", PhoneNumber = "123456789", UserDate = new DateTime(2020, 5, 26, 19, 21, 0) });
            Companies.Add(new CompanyInfo { ID_inApp = 12, Contact = "Elena Volkova", ID = 144, Name = "Y", PostCode = "426039", EMail = "lenavolkova99@mail.ru", Address = "Sanochnaya 20", City = "Izhevsk", PhoneNumber = "123456789", UserDate = new DateTime(2020, 5, 28, 19, 21, 0) });
        }
    }
}

