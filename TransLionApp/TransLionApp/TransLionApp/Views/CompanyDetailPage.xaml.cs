using System;
using System.Collections.Generic;
using System.Linq;
using TransLionApp.Data;
using Xamarin.Forms;

namespace TransLionApp.Views
{

    [QueryProperty("CompanyName", "companyname")]
    public partial class CompanyDetailPage : ContentPage
    {
        public string _companyName;
        public string CompanyName
        {
            set
            {
                BindingContext = CompanyData.Companies.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
                _companyName = Uri.UnescapeDataString(value);
            }
            get
            {

                return _companyName;
            }
        }
        public CompanyDetailPage()
        {
            InitializeComponent();
        }

        private async void editButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"companyedit?companyname={CompanyName}");
        }
    }
}
