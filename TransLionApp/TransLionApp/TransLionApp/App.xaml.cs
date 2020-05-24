using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TransLionApp.Controls;
using TransLionApp.Data;
using System.IO;
using System.Threading.Tasks;

namespace TransLionApp
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "tablepeople.db";
        static TablePeople database;
        public static TablePeople Database
        {
            get
            {
                if (database == null)
                {
                    database = new TablePeople(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }



        public static int ID
        {
            get
            {
                if (App.Database.GetUsersAsync().Result.Count != 0)
                {
                    var users = App.Database.GetUsersAsync().Result;
                    return users[0].ID_inApp;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static string Login
        {
            get
            {
                if (App.ID != 0)
                {
                    var users = App.Database.GetUsersAsync().Result;
                    return users[0].Login;
                }
                else
                {
                    return "";
                }
            }
        }

        public static string Type
        {
            get
            {
                if (App.ID != 0)
                {
                    var users = App.Database.GetUsersAsync().Result;
                    return users[0].Type;
                }
                else
                {
                    return "";
                }
            }
        }

        public static string NamePerson
        {
            get
            {
                if (App.ID != 0)
                {
                    var users = App.Database.GetUsersAsync().Result;
                    return users[0].NamePerson;
                }
                else
                {
                    return "";
                }
            }
        }

        public App()
        {
            InitializeComponent();
            //MainPage = new Pages.User.UserDashboardPage();
            MainPage = new ShellPage();
            
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
