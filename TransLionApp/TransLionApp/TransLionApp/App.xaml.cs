﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransLionApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new ShellPage();
            //Verzuimbegeleiding verzuimbegeleiding = new Verzuimbegeleiding();
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
