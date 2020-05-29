using System;
using System.Collections.Generic;
using System.Text;

namespace TransLionApp.Data
{
    public class UserInfo
    {
        public int ID_inApp { get; set; }
        public int ID { get; set; }
        //отдельно имя и фамилия
        public string NamePerson { get; set; }
        public string SurnamePerson { get; set; }
        public string Type { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        //public string LastDateOfWatching { get; set; }
        public DateTime LastDateOfWatching { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime LastGuidanceDay { get; set; }
        public DateTime LastDayOfSickness { get; set; }
        public DateTime FirstDayOfSickness { get; set; }
    }
}
