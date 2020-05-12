using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using TransLionApp;
using Xamarin.Forms.Xaml;

namespace TransLionApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutHeader : ContentView
    {
        public FlyoutHeader()
        {
            InitializeComponent();
        }

        private async void LogginButton_Clicked(object sender, EventArgs e)
        {
            //var test = new TestPage();
            await Navigation.PushModalAsync(new LoginPage());
           //test.DisplayStack();
        }

        public void UserEntered()
        {

        }
    }
}