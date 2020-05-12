using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransLionApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {

        Label stackLabel;
        public TestPage()
        {
            Title = "test";

            stackLabel = new Label();
            //NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            var stack = this.Navigation.NavigationStack;
            stackLabel.Text = "";
            foreach (var p in stack)
            {
                stackLabel.Text += p.Title + "\n";
            }
            Content = new StackLayout { Children = { stackLabel } };
            //InitializeComponent();
        }

        protected internal void DisplayStack()
        {
            NavigationPage navPage = (NavigationPage)Application.Current.MainPage;
            stackLabel.Text = "";
            //foreach (Page p in navPage.Navigation.ModalStack)
            //{
            //    stackLabel.Text += p.Title + "\n";
            //}

           
        }
    }
}