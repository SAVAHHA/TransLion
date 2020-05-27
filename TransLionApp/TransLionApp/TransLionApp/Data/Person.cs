using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TransLionApp.Data
{
    [Table("Person")]
    public class Person
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID_inApp { get; set; }
        public int ID { get; set; }
        public string NamePerson { get; set; }
        public string Type { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
