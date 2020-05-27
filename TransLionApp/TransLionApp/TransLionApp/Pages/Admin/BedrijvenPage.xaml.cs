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

        private async void plusButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("adduser");
        }

    }
}
