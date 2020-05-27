using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Plugin.Messaging;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TransLionApp;

namespace TransLionApp.Pages.User
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BedrijfPage : ContentPage
    {
        private double lastScrollPoint = 0;
        private bool translating = false;
        private bool isVisible = true;
        public BedrijfPage()
        {
            InitializeComponent();
        }
        private void emailButton_Clicked(object sender, EventArgs e)
        {
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                emailMessenger.SendEmail("info@translion.nl");
            }
        }

        private void callButton_Clicked(object sender, EventArgs e)
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
            {
                phoneDialer.MakePhoneCall("010 - 264 3030");
            }
        }

        private void linkedinButton_Clicked(object sender, EventArgs e)
        {
            Uri siteUri = new Uri("https://www.linkedin.com/company/trans-lion");
            Launcher.OpenAsync(siteUri);
        }

        private async void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            if (translating)
                return;
            uint mills = 100;
            translating = true;
            if (e.ScrollY > lastScrollPoint)
            {
                // hide
                if (isVisible)
                {
                    await PanelGrid.TranslateTo(PanelGrid.TranslationX, PanelGrid.TranslationY + PanelGrid.HeightRequest, mills);
                    isVisible = false;
                }
            }
            else
            {
                // show
                if (!isVisible)
                {
                    await PanelGrid.TranslateTo(PanelGrid.TranslationX, PanelGrid.TranslationY - PanelGrid.HeightRequest, mills);
                    isVisible = true;
                }
            }
            lastScrollPoint = e.ScrollY;
            translating = false;
        }

    }
}

