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
    [QueryProperty("UserLogin", "userlogin")]
    public partial class UserDetailPage : ContentPage
    {
        public string _userLogin;
        public string UserLogin
        {
            set
            {
                BindingContext = UserData.Users.FirstOrDefault(m => m.Login == Uri.UnescapeDataString(value));
                _userLogin = Uri.UnescapeDataString(value);
            }
            get
            {

                return _userLogin;
            }
        }

        public UserDetailPage()
        {
            InitializeComponent();
        }

        private async void editButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"useredit?userlogin={UserLogin}");
        }

        //private async void BackButton_Clicked(object sender, EventArgs e)
        //{
        //    await DisplayAlert("f", "ff", "OK");

        //    await Shell.Current.GoToAsync("//clienten");
        //}
    }
}