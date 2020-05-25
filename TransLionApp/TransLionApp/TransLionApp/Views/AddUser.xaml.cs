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
            if (emailMessenger.CanSendEmail)
            {
                emailMessenger.SendEmail(_email, "тема письма", "текст письма");
            }
        }
    }
}