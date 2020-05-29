using Syncfusion.Compression.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransLionApp.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransLionApp.Pages.Admin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminWIAaanvraagPage : ContentPage
    {
        //public IList<UserInfo> _sortedUsers = new IList<UserInfo>();
        public IList<UserInfo> SortedUsers { get; set; }
        
        public AdminWIAaanvraagPage()
        {
            InitializeComponent();
            var lastUser = new UserInfo();
            var UsersSorted = from _user in UserData.Users
                           orderby _user.LastDateOfWatching descending
                              select _user;
            foreach (var _user in UsersSorted)
            {
                lastUser = _user;
                break;
            }
            latestUserNameLabel.Text = lastUser.NamePerson;
            lastUserDateLabel.Text = lastUser.LastDateOfWatching.ToString();

            SortedUsers = new List<UserInfo>();
            List<int> numbers = new List<int>();

            for (int i = 1; i < UsersSorted.Count(); i++)
            {
                var _user = UsersSorted.ElementAt(i);
                SortedUsers.Add(_user);
                numbers.Add(i);
            }

            WIAusersCollectionView.ItemsSource = SortedUsers;
            BinsCollectionView.ItemsSource = numbers;
           

            //MainStackLayout.Children.Add(new Grid
            //{
            //    RowDefinitions = { new RowDefinition() },
            //    ColumnDefinitions = {new ColumnDefinition()},
            //    Children =
            //    {
            //        new 
            //    }
            //});
        }

        private async void wiaDetailButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("wiadetail");
        }

        private void deleteWIAButton_Clicked(object sender, EventArgs e)
        {
            //var tt = e.
            var user = WIAusersCollectionView.SelectedItem as UserInfo;
           // string _userLogin = (WIAusersCollectionView.CurrentSelection.FirstOrDefault() as UserInfo).Login;
            //await DisplayAlert(WIAusersCollectionView.SelectedItem.ToString(), "", "o");
        }
    }
}