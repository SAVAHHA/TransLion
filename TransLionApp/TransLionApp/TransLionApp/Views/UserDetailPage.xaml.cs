﻿using System;
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
        public string UserLogin
        {
            set
            {
                BindingContext = UserData.Users.FirstOrDefault(m => m.Login == Uri.UnescapeDataString(value));
            }
        }

        public UserDetailPage()
        {
            InitializeComponent();
        }

        //private async void BackButton_Clicked(object sender, EventArgs e)
        //{
        //    await DisplayAlert("f", "ff", "OK");

        //    await Shell.Current.GoToAsync("//clienten");
        //}
    }
}