using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Plugin.Messaging;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace TransLionApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Button callButton;
        Button emailButton;
        StackLayout stackLayoutRow1;
        

        public MainPage()
        {
            callButton = new Button { Text = "Call", FontSize = 8, TextColor = Color.White, WidthRequest = 100, BackgroundColor = Color.FromRgb(77, 192, 143), HorizontalOptions = LayoutOptions.End, Margin = new Thickness(0, 5, 10, 5)};
            callButton.Clicked += (o, e) =>
            {
                var phoneDialer = CrossMessaging.Current.PhoneDialer;
                if (phoneDialer.CanMakePhoneCall)
                {
                    phoneDialer.MakePhoneCall("89160249905");
                }
            };

            emailButton = new Button { Text = "Contact", FontSize = 8, TextColor = Color.White, BackgroundColor = Color.Transparent, WidthRequest = 100, HorizontalOptions = LayoutOptions.Center, Margin = new Thickness(0, 5, 0, 5) };
            emailButton.Clicked += (o, e) =>
            {
                var emailMessenger = CrossMessaging.Current.EmailMessenger;
                if (emailMessenger.CanSendEmail)
                {
                    emailMessenger.SendEmail("info@translion.nl");
                }
            };

            Image menuImage = new Image { Source = "menu", HorizontalOptions = LayoutOptions.End, VerticalOptions = LayoutOptions.Center, Margin = new Thickness(0, 0, 10, 0) };

            Grid grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = 40},
                    new RowDefinition { Height = 60},
                    new RowDefinition { Height = GridLength.Auto}
                }
            };

            Label LabelContact = new Label { Text = "Contact", TextColor = Color.White, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center};
            grid.Children.Add(new BoxView { Color = Color.FromRgb(46, 46, 46) }, 0, 0);
            grid.Children.Add(new Label { Text = "info@translion.nl", TextColor = Color.White, Margin = new Thickness(10), VerticalTextAlignment = TextAlignment.Center });
            grid.Children.Add(emailButton, 0, 0);
            grid.Children.Add(callButton, 0, 0);

            Grid gridRow1 = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition {  Width = new GridLength(10, GridUnitType.Star) },
                    new ColumnDefinition {  Width = new GridLength(1, GridUnitType.Star) }
                }
            };

            stackLayoutRow1 = new StackLayout { Spacing = 0};
            stackLayoutRow1.Children.Add(new Label { Text = "Trans Lion", FontSize = 20, TextColor = Color.Silver, Margin = new Thickness(20, 10, 0, 0)});
            stackLayoutRow1.Children.Add(new Label { Text = "De HRM dienstverlener", FontSize = 9, TextColor = Color.FromRgb(96, 149, 190), Margin = new Thickness(22, 0, 0, 0)});
            gridRow1.Children.Add(stackLayoutRow1, 0, 0);
            gridRow1.Children.Add(menuImage, 1, 0);
            //gridRow1.Children.Add(new BoxView { Color = Color.AliceBlue }, 1, 0);

            grid.Children.Add(gridRow1, 0, 1);
            grid.Children.Add(new BoxView { Color = Color.AliceBlue, HeightRequest = 455}, 0, 2);
            //stackLayoutTop.Children.Add(new BoxView { Color = Color.FromRgb(46, 46, 46), HorizontalOptions = LayoutOptions.Start });
            //stackLayoutTop = new StackLayout { BackgroundColor = Color.FromRgb(46, 46, 46) };
            //stackLayoutTop.Children.Add(new Label { Text = "info@translion.nl", TextColor = Color.White, Margin = new Thickness(10), VerticalTextAlignment = TextAlignment.Center });
            //stackLayoutTop.Children.Add(callButton);
            //stackLayoutTop.Children.Add(LabelContact);

            //grid.Children.Add(stackLayoutTop, 0, 0);

            Content = grid;

            //StackLayout stackLayout = new StackLayout();
            //for (int i = 1; i < 20; i++)
            //{
            //    Label label = new Label
            //    {
            //        Text = "Метка " + i,
            //        FontSize = 23
            //    };
            //    stackLayout.Children.Add(label);
            //}
            //ScrollView scrollView = new ScrollView();
            //scrollView.Content = stackLayout;
            //this.Content = scrollView;
            //InitializeComponent();
        }
    }
}
