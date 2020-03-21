using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TransLionApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            StackLayout stackLayout = new StackLayout();
            for (int i = 1; i < 20; i++)
            {
                Label label = new Label
                {
                    Text = "Метка " + i,
                    FontSize = 23
                };
                stackLayout.Children.Add(label);
            }
            ScrollView scrollView = new ScrollView();
            scrollView.Content = stackLayout;
            this.Content = scrollView;
            //InitializeComponent();
        }
    }
}
