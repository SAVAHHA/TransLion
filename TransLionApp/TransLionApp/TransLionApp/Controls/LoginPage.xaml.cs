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

namespace TransLionApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        

        public LoginPage()
        {

            //WriteText(2);
            ReadText();

            InitializeComponent();
        }

        public async void ReadText()
        {
            string result = "";
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames()
            .Single(str => str.EndsWith("Enter.txt"));

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }

            await DisplayAlert("", result, "OK");
        }
        
        public void WriteText(int type)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames()
            .Single(str => str.EndsWith("Enter.txt"));

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine(10);
                //writer.Write(type.ToString());
            }
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            var login = loginEntry.Text;
            var password = passwordEntry.Text;

            try
            {
                string myConnectionString = "Server=www.db4free.net;Port=3306;User Id=translion;Password=translion2020;Database=translion;OldGuids=True";
                MySqlConnection connection = new MySqlConnection(myConnectionString);
                connection.Open();
                MySqlCommand newCommand = new MySqlCommand("SELECT * FROM Entry WHERE Login=@login", connection);
                newCommand.Parameters.AddWithValue("@login", login);
                MySqlDataReader mySqlDataReader = newCommand.ExecuteReader();
                if (mySqlDataReader.HasRows)
                {
                    while (mySqlDataReader.Read())
                    {
                        object id = mySqlDataReader.GetValue(0);
                        object loginGet = mySqlDataReader.GetValue(1);
                        object passwordGet = mySqlDataReader.GetValue(2);
                        object typeGet = mySqlDataReader.GetValue(3);
                        string type;

                        if (Int32.Parse(typeGet.ToString()) == 1)
                        {
                            type = "admin";
                        }
                        else
                        {
                            type = "user";
                        }

                        if (password == passwordGet.ToString())
                        {
                            await DisplayAlert("You logged as", type, "OK");
                            await Navigation.PopModalAsync();
                            LoginButton.Text = "Uitloggen";


                        }
                        else
                        {
                            await DisplayAlert("Rejected", "Incorrect password", "OK");
                            passwordEntry.Text = "";
                        }
                    }
                }
                else
                {
                    await DisplayAlert("Rejected", "No user with such login", "OK");
                    loginEntry.Text = "";
                    passwordEntry.Text = "";
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                await DisplayAlert("No Internet connection", ex.InnerException?.Message, "ok");
            }
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