using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Messaging;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransLionApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddUser : ContentPage
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void registrationButton_Clicked(object sender, EventArgs e)
        {
            string _email = emailEntry.Text;
            var emailMessenger = CrossMessaging.Current.EmailMessenger;

            string login = _email.Split('@')[0];
            Random random = new Random();
            string password = "";
            for (int i = 0; i < 5; i++)
            {
                var element = (char)random.Next('a', 'z');
                password += element.ToString();
            }

            for (int i = 0; i < 3; i++)
            {
                var element = (int)random.Next(0, 9);
                password += element.ToString();
            }

            string text = "Login: " + login + "\nPassword: " + password;

            if (emailMessenger.CanSendEmail)
            {
                emailMessenger.SendEmail(_email, "TransLion", text);
            }
        }
    }
}