using System;
using System.Collections.Generic;
using System.Linq;
using TransLionApp.Data;
using Xamarin.Forms;

namespace TransLionApp.Views
{
    [QueryProperty("CompanyName", "companyname")]
    public partial class CompanyEdit : ContentPage
    {
        public string CompanyName
        {
            set
            {
                BindingContext = CompanyData.Companies.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }
        public CompanyEdit()
        {
            InitializeComponent();
        }
    }
}
