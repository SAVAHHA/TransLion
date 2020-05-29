using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Plugin.Messaging;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TransLionApp;
using TransLionApp.Data;
using System.Linq;

namespace TransLionApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sollicitatieoverzicht : ContentPage
    {
        public IList<CompanyInfo> SortedCompanies { get; set; }

        private double lastScrollPoint = 0;
        private bool translating = false;
        private bool isVisible = true;
        public Sollicitatieoverzicht()
        {
            InitializeComponent();
            //var Companies = from _company in CompanyData.Companies    
            //                  select _company;

            //List<CompanyInfo> companiesList = new List<CompanyInfo>();

            //for (int i = 1; i < Companies.Count(); i++)
            //{
            //    var _company = Companies.ElementAt(i);
            //    companiesList.Add(_company);
            //}

            //SollicitatieOverzichtCollectionView.ItemsSource = companiesList;

            var lastCompany = new CompanyInfo();
            var CompanySorted = from _company in CompanyData.Companies
                          orderby _company.UserDate descending
                          select _company;
            foreach (var _company in CompanySorted)
            {
                lastCompany = _company;
                break;
            }
            latestUserNameLabel.Text = lastUser.NamePerson;
            lastUserDateLabel.Text = lastUser.LastDateOfWatching.ToString();

            SortedCompanies = new List<CompanyInfo>();

            for (int i = 1; i < UsersSorted.Count(); i++)
            {
                var _user = UsersSorted.ElementAt(i);
                SortedUsers.Add(_user);
            }

            WIAusersCollectionView.ItemsSource = SortedUsers;

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

        private async void bedrijfButton_Clicked(object sender, EventArgs e)
        {
            //string Name = (e.CurrentSelection.FirstOrDefault() as CompanyInfo).Name;
           // await Shell.Current.GoToAsync("bedrijf?");
        }

        private async void SollicitatieOverzichtCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string Name = (e.CurrentSelection.FirstOrDefault() as CompanyInfo).Name;
            //await DisplayAlert(Name, "", "O");
            //var Company = e.CurrentSelection as CompanyInfo;
            //string Name = Company.Name; 
            await Shell.Current.GoToAsync($"bedrijf?companyname={Name}"); 


        }
    }


}
