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
            SearchBar searchBar = (SearchBar)sender;
            searchResults.ItemsSource = GetCompanies(searchBar.Text);
        }
        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string _userLogin = (e.CurrentSelection.FirstOrDefault() as UserInfo).Login;
            string _companyName = (e.CurrentSelection.FirstOrDefault() as CompanyInfo).Name;
            await Shell.Current.GoToAsync($"companydetail?companyname={_companyName}");
        }

        private IEnumerable<CompanyInfo> GetCompanies(string searchText = null)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return CompanyData.Companies;
            }
            else
            {
                //return UserData.Users.Where(p => p.SurnamePerson.ToLower().StartsWith(searchText));
                return CompanyData.Companies.Where(p => p.Name.ToLower().Contains(searchText.ToLower()));

            }
        }
    }
}
