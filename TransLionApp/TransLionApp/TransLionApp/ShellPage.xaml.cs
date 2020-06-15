using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Plugin.Messaging;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using TransLionApp.Controls;
using TransLionApp.Pages;
using TransLionApp.Pages.User;
using TransLionApp.Pages.Admin;
using TransLionApp.Views;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;
using System.IO;
//using Org.BouncyCastle.Bcpg;

namespace TransLionApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ShellPage : Shell
    {
        public ICommand PdfCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public ShellPage()
        {
            BackgroundColor = Color.White;
            Routing.RegisterRoute("sollicitatiePage", typeof(SollicitatiePage));
            Routing.RegisterRoute("userdetail", typeof(UserDetailPage));
            Routing.RegisterRoute("useredit", typeof(UserEdit));
            Routing.RegisterRoute("adduser", typeof(AddUser));
            Routing.RegisterRoute("wiadetail", typeof(WIADetailPage));
            Routing.RegisterRoute("companydetail", typeof(CompanyDetailPage));
            Routing.RegisterRoute("companyedit", typeof(CompanyEdit));
            Routing.RegisterRoute("bedrijf", typeof(BedrijfPage));
            InitializeComponent();

            if (App.Login != "")
            {
                if (App.Type == "user")
                {
                    UserPart();
                }
                else
                {
                    AdminPart();
                }
            }

            CurrentItem = HomePage;
            BackgroundColor = Color.White;
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (App.Login != "")
            {
                if (App.Type == "user")
                {
                    UserPart();
                }
                else
                {
                    AdminPart();
                }
            }

        }

        public void UserPart()
        {
            Items.Clear();


            Items.Add(new FlyoutItem
            {
                Title = "Account",
                IsEnabled = false,
                Route = "headerAccount",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new HomePage()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {

                Title = "Dashboard",
                IsEnabled = true,
                Route = "dashboardUser",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new UserDashboard()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Sollicitatieoverzicht",
                IsEnabled = true,
                Route = "sollicitatieoverzicht",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new Sollicitatieoverzicht()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "WIA-aanvraag",
                IsEnabled = true,
                Route = "wiaaanvraag",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new UserWIAaanvraag()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Mijn gegevens",
                IsEnabled = true,
                Route = "mijngegevens",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new Mijngegevens()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Sollicitatietips",
                IsEnabled = true,
                Route = "sollicitatietips",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new SollicitatiePage()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Menu",
                IsEnabled = false,
                Route = "headerMenu",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new HomePage()} }
                    }
                }

            });
            Items.Add(new FlyoutItem
            {
                Title = "Home page",
                IsEnabled = true,
                Route = "homepage",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new HomePage(), } }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Verzzuimbegeleiding",
                IsEnabled = true,
                Route = "verzuimbegeleiding",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new Verzuimbegeleiding()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Jobhunting",
                IsEnabled = true,
                Route = "jobhunting",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new Jobhunting()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Re-integratie 2e spoor",
                IsEnabled = true,
                Route = "reintegratie",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new ReIntegratie2eSpoor()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "UWV",
                IsEnabled = true,
                Route = "uwv",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new UWVPage()} }
                    }
                }

            });

            Items.Add(new MenuItem
            {
                Text = "Werkwijzer wet verbetering",
                Command = PdfCommand,
                CommandParameter = "https://www.translion.nl/images/werkwijzer-poortwachter.pdf"
            });

            Items.Add(new MenuItem
            {
                Text = "Sollicitatiehandleiding",
                Command = PdfCommand,
                CommandParameter = "https://drive.google.com/file/d/1ItV4pJSyAu9ZSjdAd3PsbDpK2ot4aKPQ/view?usp=sharing"
            });

            Items.Add(new FlyoutItem
            {
                Title = "Wie zijn wij",
                IsEnabled = true,
                Route = "wiezijnwij",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new WieZijnWij()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "1e en 2e spoor",
                IsEnabled = true,
                Route = "spoor",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new Page1eEn2eSpoor()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Schema wetverbetering",
                IsEnabled = true,
                Route = "schemawetverbetering",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new SchemaWetVerbeteringPoortwachter()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Contact",
                IsEnabled = true,
                Route = "headerContact",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent { Content = new ContactPage() } }
                    }
                }

            });
        }

        public void AdminPart()
        {
            Items.Clear();

            Items.Add(new FlyoutItem
            {
                Title = "Account",
                IsEnabled = false,
                Route = "headerAccount",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new HomePage()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Dashboard",
                IsEnabled = true,
                Route = "dashboardAdmin",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new AdminDashboardPage()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Clienten",
                IsEnabled = true,
                Route = "clienten",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new ClientenPage()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Bedrijven",
                IsEnabled = true,
                Route = "bedrijven",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new BedrijvenPage()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Sollicitatieoverzicht",
                IsEnabled = true,
                Route = "sollicitatieoverzicht",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new Sollicitatieoverzicht()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "WIA-aanvragen",
                IsEnabled = true,
                Route = "wiaaanvragen",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new AdminWIAaanvraagPage()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Menu",
                IsEnabled = false,
                Route = "headerMenu",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new HomePage()} }
                    }
                }

            });
            Items.Add(new FlyoutItem
            {
                Title = "Home page",
                IsEnabled = true,
                Route = "homepage",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new HomePage(), } }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Verzzuimbegeleiding",
                IsEnabled = true,
                Route = "verzuimbegeleiding",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new Verzuimbegeleiding()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Jobhunting",
                IsEnabled = true,
                Route = "jobhunting",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new Jobhunting()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Re-integratie 2e spoor",
                IsEnabled = true,
                Route = "reintegratie",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new ReIntegratie2eSpoor()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "UWV",
                IsEnabled = true,
                Route = "uwv",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new UWVPage()} }
                    }
                }

            });

            Items.Add(new MenuItem
            {
                Text = "Werkwijzer wet verbetering",
                Command = PdfCommand,
                CommandParameter = "https://www.translion.nl/images/werkwijzer-poortwachter.pdf"
            });

            Items.Add(new MenuItem
            {
                Text = "Sollicitatiehandleiding",
                Command = PdfCommand,
                CommandParameter = "https://drive.google.com/file/d/1ItV4pJSyAu9ZSjdAd3PsbDpK2ot4aKPQ/view?usp=sharing"
            });

            Items.Add(new FlyoutItem
            {
                Title = "Wie zijn wij",
                IsEnabled = true,
                Route = "wiezijnwij",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new WieZijnWij()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "1e en 2e spoor",
                IsEnabled = true,
                Route = "spoor",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new Page1eEn2eSpoor()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Schema wetverbetering",
                IsEnabled = true,
                Route = "schemawetverbetering",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new SchemaWetVerbeteringPoortwachter()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Contact",
                IsEnabled = true,
                Route = "headerContact",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent { Content = new ContactPage() } }
                    }
                }

            });
        }
    }

    
}
