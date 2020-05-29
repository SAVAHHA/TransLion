using System;
using System.Collections.Generic;
using System.Text;

namespace TransLionApp.Data
{
    public class CompanyInfo
    {
        public int ID_inApp { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public DateTime UserDate { get; set; }
    }
}
