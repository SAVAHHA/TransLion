using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransLionApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1eEn2eSpoor : ContentPage
    {
        public Page1eEn2eSpoor()
        {
            InitializeComponent();

        }
        private void HierTo2eButton_Clicked(object sender, EventArgs e)
        {
           var reitegratie2espoor = Navigation.PushModalAsync(new ReIntegratie2eSpoor());
        }
    }
}