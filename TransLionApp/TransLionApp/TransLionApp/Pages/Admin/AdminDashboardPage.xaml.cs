using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransLionApp.Pages.Admin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminDashboardPage : ContentPage
    {
        public AdminDashboardPage()
        {
            InitializeComponent();
           // frameB.HasShadow = false;
        }

        private async void WIAaanvraagButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///wiaaanvragen");
        }

        private async void Sollicitatieoverizicht_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///sollicitatieoverzicht"); 
        }

        private async void Sollicitatie_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("/sollicitatiePage");
        }

        private async void Clienten_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///clienten");
            
        }

        private async void BedrijvenButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///bedrijven");
        }
    }
}