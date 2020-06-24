using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransLionApp.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransLionApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
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
