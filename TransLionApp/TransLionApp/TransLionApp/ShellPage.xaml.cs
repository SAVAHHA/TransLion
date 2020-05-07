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
//using TransLionApp.Files;

using MySql.Data.MySqlClient;

namespace TransLionApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ShellPage : Shell
    {
        public ICommand PdfCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        //public ICommand NewPdfCommand => new Command<string>();
       

        
        public ShellPage()
        {
          
            InitializeComponent();
            BindingContext = this;
            //Verzuimbegeleiding verzuimbegeleiding = new Verzuimbegeleiding();
        }
    }

    
}
