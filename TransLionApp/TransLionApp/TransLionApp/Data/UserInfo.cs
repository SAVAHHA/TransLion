using System;
using System.Collections.Generic;
using System.Text;

namespace TransLionApp.Data
{
    public class UserInfo
    {
        public int ID_inApp { get; set; }
        public int ID { get; set; }
        public string NamePerson { get; set; }
        public string Type { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        //public string LastDateOfWatching { get; set; }
        public DateTime LastDateOfWatching { get; set; }
    }
}
