using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransLionApp.Controls;
using TransLionApp.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TransLionApp.Views;


namespace TransLionApp.Pages.Admin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BedrijvenPage : ContentPage
    {
        public BedrijvenPage()
        {
            InitializeComponent();
        }

        private void plusButton_Clicked(object sender, EventArgs e)
        {

        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string _userLogin = (e.CurrentSelection.FirstOrDefault() as UserInfo).Login;
            string _companyName = (e.CurrentSelection.FirstOrDefault() as CompanyInfo).Name;
            await Shell.Current.GoToAsync($"companydetail?companyname={_companyName}");
        }
    }
}
