using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TransLionApp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MySql.Data.MySqlClient;
using System.IO;
using System.Reflection;
using TransLionApp.Data;

namespace TransLionApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        //public string Type { get; set; }

        public LoginPage()
        {

            //WriteText(2);
           //ReadText();
           
            InitializeComponent();
            TestMessage();
        }

        

        public async void TestMessage()
        {
            await DisplayAlert("IMPORTANT THING:", "To log in as a user enter login:user password:1111, to log in as an admin enter login:admin password:2222 ", "I see");
        }

        //public async void ReadText()
        //{
        //    string result = "";
        //    var assembly = Assembly.GetExecutingAssembly();
        //    string resourceName = assembly.GetManifestResourceNames()
        //    .Single(str => str.EndsWith("Enter.txt"));

        //    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
        //    using (StreamReader reader = new StreamReader(stream))
        //    {
        //        result = reader.ReadToEnd();
        //    }

        //    await DisplayAlert("", result, "OK");
        //}

        //public void WriteText(int type)
        //{
        //    var assembly = Assembly.GetExecutingAssembly();
        //    string resourceName = assembly.GetManifestResourceNames()
        //    .Single(str => str.EndsWith("Enter.txt"));

        //    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
        //    using (StreamWriter writer = new StreamWriter(stream))
        //    {
        //        writer.WriteLine(10);
        //        //writer.Write(type.ToString());
        //    }
        //}

        //private async void LoginButton_Clicked(object sender, EventArgs e)
        //{
        //    var login = loginEntry.Text;
        //    var password = passwordEntry.Text;

        //    try
        //    {
        //        string myConnectionString = "Server=www.db4free.net;Port=3306;User Id=translion;Password=translion2020;Database=translion;OldGuids=True";
        //        MySqlConnection connection = new MySqlConnection(myConnectionString);
        //        connection.Open();
        //        MySqlCommand newCommand = new MySqlCommand("SELECT * FROM Entry WHERE Login=@login", connection);
        //        newCommand.Parameters.AddWithValue("@login", login);
        //        MySqlDataReader mySqlDataReader = newCommand.ExecuteReader();
        //        if (mySqlDataReader.HasRows)
        //        {
        //            while (mySqlDataReader.Read())
        //            {
        //                object id = mySqlDataReader.GetValue(0);
        //                object loginGet = mySqlDataReader.GetValue(1);
        //                object passwordGet = mySqlDataReader.GetValue(2);
        //                object typeGet = mySqlDataReader.GetValue(3);
        //                string type;

        //                if (Int32.Parse(typeGet.ToString()) == 1)
        //                {
        //                    type = "admin";
        //                }
        //                else
        //                {
        //                    type = "user";
        //                }

        //                if (password == passwordGet.ToString())
        //                {
        //                    await DisplayAlert("You logged as", type, "OK");
        //                    if (type == "user")
        //                    {

        //                        await Shell.Current.GoToAsync("//shellpage/homepage/home");
        //                        //Shell.Current.FlyoutIsPresented = false;
        //                    }
        //                    else
        //                    {
        //                        await DisplayAlert("", "u'r an admin", "wait");
        //                    }



        //                }
        //                else
        //                {
        //                    await DisplayAlert("Rejected", "Incorrect password", "OK");
        //                    passwordEntry.Text = "";
        //                }
        //            }
        //        }
        //        else
        //        {
        //            await DisplayAlert("Rejected", "No user with such login", "OK");
        //            loginEntry.Text = "";
        //            passwordEntry.Text = "";
        //        }
        //        connection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        await DisplayAlert("No Internet connection", ex.InnerException?.Message, "ok");
        //    }
        //}

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            var login = loginEntry.Text;
            var password = passwordEntry.Text;
            //var type = 2;

            if (login == "user")
            {
                await App.Database.SaveUserAsync(new Person { Login = "user", NamePerson = "User", Password = "1111", Type = "user" });
            }
            if (login == "admin")
            {
                await App.Database.SaveUserAsync(new Person { Login = "admin", NamePerson = "Admin", Password = "2222", Type = "admin" });
            }

            //Person person = new Person { Type = type, Password = password, Login = login };
            //await DisplayAlert("", "created", "ok");
            //People _people = new People(login, password, type);

            //People.people.Add(person);


            //await DisplayAlert("", "added", "ok");


            App.Current.MainPage = new ShellPage();

            //await Shell.Current.GoToAsync("//shellpage/homepage/home");
            //Shell.Current.FlyoutIsPresented = false;
        }

        private void loginEntry_Focused(object sender, FocusEventArgs e)
        {
            loginEntry.Text = "";
        }

        private void passwordEntry_Focused(object sender, FocusEventArgs e)
        {
            passwordEntry.Text = "";
            passwordEntry.IsPassword = true;
        }
    }
}