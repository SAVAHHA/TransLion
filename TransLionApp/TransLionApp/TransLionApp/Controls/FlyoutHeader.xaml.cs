using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using TransLionApp;
using Xamarin.Forms.Xaml;
using TransLionApp.Pages;

namespace TransLionApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutHeader : ContentView
    {
        public FlyoutHeader()
        {
            

            InitializeComponent();

            if (App.ID != 0)
            {
                LogginButton.Text = "Uitloggen";
            }
        }

      

        private async void LogginButton_Clicked(object sender, EventArgs e)
        {
            if (App.ID != 0)
            {
                await App.Database.DeleteUserAsync(App.ID);
                App.Current.MainPage = new ShellPage();
                //await Navigation.PushModalAsync(new HomePage());
                //await Shell.Current.GoToAsync();

            }
            else
            {
                var navPage = new NavigationPage(new LoginPage());
                navPage.BarBackgroundColor = Color.White;
                await Navigation.PushModalAsync(navPage);
               // await Shell.Current.GoToAsync("loginpage");
            }
        }

       
    }
}