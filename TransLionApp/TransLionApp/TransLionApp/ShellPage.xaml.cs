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
using Newtonsoft.Json;
using MySql.Data.MySqlClient;
using System.IO;
using Org.BouncyCastle.Bcpg;

namespace TransLionApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ShellPage : Shell
    {
        public ICommand PdfCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public Enter enter = new Enter
        {
            HasEntered = 0
        };

       
        public ShellPage()
        {
            BackgroundColor = Color.White;
            
            InitializeComponent();
            CurrentItem = HomePage;
            BackgroundColor = Color.White;
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

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
                Route = "dashboard",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new UserSollicitatiePage()} }
                    }
                }

            });

            Items.Add(new FlyoutItem
            {
                Title = "Sollicitatieoverzicht",
                IsEnabled = false,
                Route = "sollicitatieoverzicht",
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
                Title = "WIA-aanvraag",
                IsEnabled = false,
                Route = "wiaaanvraag",
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
                Title = "Mijn gegevens",
                IsEnabled = false,
                Route = "mijngegevens",
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
                Title = "Sollicitatietips",
                IsEnabled = false,
                Route = "sollicitatietips",
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
                        Items = { new ShellContent {Content = new ContactPage()} }
                    }
                }

            });

            CurrentItem = HomePage;
        }

  
    }

    
}
