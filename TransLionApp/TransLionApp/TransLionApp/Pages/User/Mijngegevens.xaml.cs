using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransLionApp.Data;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransLionApp.Pages.User
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("UserLogin", "userlogin")]
    public partial class Mijngegevens : ContentPage
    {
        public string _userLogin;
        public string UserLogin
        {
            set
            {
                BindingContext = UserData.Users.FirstOrDefault(m => m.Login == Uri.UnescapeDataString(value));
                _userLogin = Uri.UnescapeDataString(value);
            }
            get
            {

                return _userLogin;
            }
        }
        public Mijngegevens()
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

    }
}
