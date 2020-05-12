using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TransLionApp.Controls;

namespace TransLionApp
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();
            //MainPage = new Pages.User.UserDashboardPage();
            MainPage = new ShellPage();
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
