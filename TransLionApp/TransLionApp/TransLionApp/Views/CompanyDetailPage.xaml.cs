using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TransLionApp.Views
{
    public partial class CompanyDetailPage : ContentPage
    {
        public CompanyDetailPage()
        {
            InitializeComponent();
        }

        private async void editButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("bedrijf");
        }
    }
}
