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
            var shellPage = new ShellPage();
            shellPage.Enter = true;
            await Navigation.PopModalAsync();
        }
    }
}