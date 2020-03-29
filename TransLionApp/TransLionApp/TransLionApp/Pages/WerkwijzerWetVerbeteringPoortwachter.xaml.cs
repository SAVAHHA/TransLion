using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.PdfViewer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransLionApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WerkwijzerWetVerbeteringPoortwachter : ContentPage
    {
        public WerkwijzerWetVerbeteringPoortwachter()
        {
            InitializeComponent();
            Uri siteUri = new Uri("https://www.translion.nl/images/werkwijzer-poortwachter.pdf");
            Device.OpenUri(siteUri);
        }
    }
}