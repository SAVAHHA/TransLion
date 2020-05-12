using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TransLionApp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransLionApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        
        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            //var shellPage = new ShellPage();
            //shellPage.Enter = true;
            //var enter = new Enter() { HasEntered = 1 };
            await Navigation.PopModalAsync();
            LoginButton.Text = "Uitloggen";
            //var enter = new Enter() { HasEntered = 1 };
            //shellPage.AddItem();

            //NavigationPage navPage = (NavigationPage)Application.Current.MainPage;
            //IReadOnlyList<Page> navStack = navPage.Navigation.NavigationStack;
            //ShellPage homePage = navStack[navPage.Navigation.NavigationStack.Count - 1] as ShellPage;

            //await DisplayAlert("h", "no", "oh");

            //if (homePage != null)
            //{
            //    homePage.enter.HasEntered = 1;
            //}
        }
    }
}