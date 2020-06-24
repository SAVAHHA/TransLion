using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Essentials;
using Plugin.Messaging;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransLionApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SollicitatiePage : ContentPage
    {
        private double lastScrollPoint = 0;
        private bool translating = false;
        private bool isVisible = true;
        public static List<List<string>> Tips;

        public SollicitatiePage()
        {
            InitializeComponent();
            List<List<string>> listTips = new List<List<string>>();
            List<string> listtip = new List<string>();
            listtip.Add("1");
            listtip.Add("blablabla");
            listTips.Add(listtip);
            listTips.Add(listtip);
            SollicitatieTipsCollectionView.ItemsSource = listTips;
            
            
        }

        

        public void buttonmore_Clicked(object sender, EventArgs e)
        {
           
        }
        //читаем из файла TipsMockup
        //public static List<List<string>> GetSollicitatieTips() 
        //{
        //    List<List<string>> listTips = new List<List<string>>();


        //    string path = "..\\Files";
        //    DirectoryInfo dirInfo = new DirectoryInfo(path);  
        //    StreamReader f = new StreamReader(path);
        //    int counter = 0;
        //    List<string> listtip = new List<string>();
        //    while (!f.EndOfStream)
        //    {
        //        counter += 1;
        //        string s = f.ReadLine();
        //        listtip.Add(s.Split(',')[0]);
        //        listtip.Add(s.Split(',')[1]);
        //        listTips.Add(listtip);
        //    }
        //    f.Close();

        //    SollicitatieTipsCollectionView.ItemsSource = listTips;


        //    return listTips;

        //}
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
