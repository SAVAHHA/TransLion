using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TransLionApp.Data
{
    [Table("Sollicitatie")]
    public class Sollicitatie
    {
        
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID_inApp { get; set; }
        public int ID { get; set; } //ID из 
        public string NamePerson { get; set; }
        public string Type { get; set; }
        public int StatusID { get; set; }
        public string Password { get; set; }
    }
}
