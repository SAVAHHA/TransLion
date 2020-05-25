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
    public partial class ClientenPage : ContentPage
    {
        //public IEnumerable<UserInfo> ts { get; set; }
        public ClientenPage()
        {
            //ts = UserData.Users;
            //ListView searchResults = new ListView();
            //searchResults.ItemsSource = UserData.Users;
            InitializeComponent();
        }

        private async void plusButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("adduser");
        }

        private void backButton_Clicked(object sender, EventArgs e)
        {

        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            searchResults.ItemsSource = GetUsers(searchBar.Text);
            
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string _userLogin = (e.CurrentSelection.FirstOrDefault() as UserInfo).Login;
            await Shell.Current.GoToAsync($"userdetail?userlogin={_userLogin}");
        }

        private IEnumerable<UserInfo> GetUsers(string searchText = null)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return UserData.Users;
            }
            else
            {
                return UserData.Users.Where(p => p.NamePerson.StartsWith(searchText));
            }
        }
    }
}