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

namespace TransLionApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        

        public LoginPage()
        {
            InitializeComponent();
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
                //await DisplayAlert("You entered", "", "ok");
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
                            //await Navigation.PushModalAsync(new MainPage(Int32.Parse(id.ToString()), name.ToString()));
                            //await Navigation.PushModalAsync(new TabbedMainPage());
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



            //var shellPage = new ShellPage();
            //shellPage.Enter = true;
            //var enter = new Enter() { HasEntered = 1 };
            
            //var enter = new Enter() { HasEntered = 1 };
            //shellPage.AddItem();

            //NavigationPage navPage = (NavigationPage)Application.Current.MainPage;
            //IReadOnlyList<Page> navStack = navPage.Navigation.NavigationStack;
            //ShellPage homePage = navStack[navPage.Navigation.NavigationStack.Count - 1] as ShellPage;

            //await DisplayAlert("h", "no", "oh");

            //if (homePage != null)
            //{
            //    homePage.enter.HasEntered = 1;
            //}
        }
    }
}