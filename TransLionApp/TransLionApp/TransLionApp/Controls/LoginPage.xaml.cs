using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TransLionApp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MySql.Data.MySqlClient;
using System.IO;
using System.Reflection;
using TransLionApp.Data;

namespace TransLionApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        //public string Type { get; set; }

        public LoginPage()
        {

            //WriteText(2);
           //ReadText();
           
            InitializeComponent();
            //TestMessage();
        }

        

        public async void TestMessage()
        {
            await DisplayAlert("IMPORTANT THING:", "To log in as a user enter login:user password:1111, to log in as an admin enter login:admin password:2222 ", "I see");
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            var login = loginEntry.Text.ToLower();
            var password = passwordEntry.Text.ToLower();
            //var type = 2;

            if (login == "user")
            {
                await App.Database.SaveUserAsync(new Person { Login = "user", NamePerson = "UserName", Password = "1111", Type = "user" });
                App.Current.MainPage = new ShellPage();
                await Shell.Current.GoToAsync("///dashboardUser");
            }
            if (login == "admin")
            {
                await App.Database.SaveUserAsync(new Person { Login = "admin", NamePerson = "AdminName", Password = "2222", Type = "admin" });
                App.Current.MainPage = new ShellPage();
                await Shell.Current.GoToAsync("///dashboardAdmin");
            }
        }

            //Person person = new Person { Type = type, Password = password, Login = login };
            //await DisplayAlert("", "created", "ok");
            //People _people = new People(login, password, type);

            //People.people.Add(person);


            //await DisplayAlert("", "added", "ok");


            //App.Current.MainPage = new ShellPage();

            //await Shell.Current.GoToAsync("//shellpage/homepage/home");
            //Shell.Current.FlyoutIsPresented = false;


        private void loginEntry_Focused(object sender, FocusEventArgs e)
        {
            loginEntry.Text = "";
        }

        private void passwordEntry_Focused(object sender, FocusEventArgs e)
        {
            passwordEntry.Text = "";
            passwordEntry.IsPassword = true;
        }
    }
}