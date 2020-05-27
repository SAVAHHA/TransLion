using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransLionApp.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransLionApp.Pages.User
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("UserLogin", "userlogin")]
    public partial class Mijngegevens : ContentPage
    {
        public string _userLogin;
        public string UserLogin
        {
            set
            {
                BindingContext = UserData.Users.FirstOrDefault(m => m.Login == Uri.UnescapeDataString(value));
                _userLogin = Uri.UnescapeDataString(value);
            }
            get
            {

                return _userLogin;
            }
        }
        public Mijngegevens()
        {
            InitializeComponent();
        }
    }
}
