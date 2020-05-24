using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Plugin.Messaging;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TransLionApp;

namespace TransLionApp.Pages.User
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserDashboard : ContentPage
    {
        private double lastScrollPoint = 0;
        private bool translating = false;
        private bool isVisible = true;

        public UserDashboard()
        {
            string login = "kleshenkoaa";
            string name = "Anna";
            InitializeComponent();
            
            //string query1 = "CREATE TABLE Company(CompanyKey INTEGER NOT NULL,Name CHAR(30) NULL,Email CHAR(30) NULL,Adress CHAR(50) NULL,PersonName CHAR(30) NULL,Phone CHAR(11) NULL,Postcode CHAR(6) NULL,City CHAR(30) NULL);ALTER TABLE Company ADD CONSTRAINT XPKCompany PRIMARY KEY(CompanyKey);CREATE TABLE Entry(EntryKey CHAR(18) NOT NULL,Login CHAR(18) NULL,Password CHAR(18) NULL,UserKey INTEGER NOT NULL,AdminKey INTEGER NOT NULL); ALTER TABLE Entry ADD CONSTRAINT XPKEntry PRIMARY KEY(EntryKey, UserKey, AdminKey); CREATE TABLE StatusKey(StatusKey INTEGER NOT NULL,Name CHAR(18) NULL);ALTER TABLE StatusKey ADD CONSTRAINT XPKStatusKey PRIMARY KEY(StatusKey); CREATE TABLE UserInfo2(Doc1 CHAR(50) NULL,Doc2 CHAR(50) NULL,Doc3 CHAR(50) NULL,Password CHAR(18) NULL,Name CHAR(30) NULL, FirstDayOfSickness DATE NULL,LastDayOfSickness DATE NULL,LastGuidanceDay DATE NULL,CompanyName CHAR(30) NULL,CompanyDate DATE NULL,WIADate DATE NULL,WIAStatusKey INTEGER NULL,CompanyStatusKey INTEGER NULL,Login CHAR(30) NULL,UserKey INTEGER NOT NULL); ALTER TABLE UserInfo2 ADD CONSTRAINT XPKUserInfo2 PRIMARY KEY(UserKey); ALTER TABLE Entry ADD CONSTRAINT R_23 FOREIGN KEY(UserKey) REFERENCES UserInfo2(UserKey); ALTER TABLE UserInfo2 ADD CONSTRAINT R_16 FOREIGN KEY(WIAStatusKey) REFERENCES StatusKey(StatusKey); ALTER TABLE UserInfo2 ADD CONSTRAINT R_17 FOREIGN KEY(WIAStatusKey) REFERENCES StatusKey(StatusKey); ALTER TABLE UserInfo2 ADD CONSTRAINT R_18 FOREIGN KEY(CompanyStatusKey) REFERENCES StatusKey(StatusKey); ";
            string getinfo = "SELECT Name FROM UserInfo2 WHERE Login =" + login;

            //string myConnectionString = "Server=www.db4free.net;Port=3306;User Id=translion_annak;Password=09262000;Database=translion_db;OldGuids=True";
            //MySqlConnection conn = new MySqlConnection(myConnectionString);
            //conn.Open();
            //MySqlCommand command = new MySqlCommand(getinfo, conn); 
            //string name = command.ExecuteScalar().ToString();      
            //conn.Close();

           
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

        private async void bekijk_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("sollicitatiePage");
        }

        private async void wia_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///wiaaanvraag");
            //await Navigation.PushModalAsync(new UserWIAaanvraagPage());
        }
    }
}