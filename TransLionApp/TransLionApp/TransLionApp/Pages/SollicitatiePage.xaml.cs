using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransLionApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SollicitatiePage : ContentPage
    {
        public static List<List<string>> Tips;

        public SollicitatiePage()
        {
            InitializeComponent();
            List<List<string>> listTips = new List<List<string>>();
            //var exePath = AppDomain.CurrentDomain.BaseDirectory;//path to exe file
            //var path = @"C:\GitHub TransLion\TransLionApp\TransLionApp\TransLionApp\Files\TipsMockup.csv";
            //string pat = @"C:\GitHub TransLion\TransLionApp\TransLionApp\TransLionApp\Files\TipsMockup.csv";
            //StreamReader f = new StreamReader(pat);
            //int counter = 0;
            List<string> listtip = new List<string>();
            //while (!f.EndOfStream)
            //{
            //    counter += 1;
            //    string s = f.ReadLine();
            //    listtip.Add(s.Split(',')[0]);
            //    listtip.Add(s.Split(',')[1]);
            //    listTips.Add(listtip);
            //}
            //f.Close();
            listtip.Add("1");
            listtip.Add("blablabla");
            listTips.Add(listtip);
            listTips.Add(listtip);
            SollicitatieTipsCollectionView.ItemsSource = listTips;


        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
        //читаем из файла TipsMockup
        //public static List<List<string>> GetSollicitatieTips() 
        //{
        //    List<List<string>> listTips = new List<List<string>>();


        //    string path = "..\\Files";
        //    DirectoryInfo dirInfo = new DirectoryInfo(path);  
        //    StreamReader f = new StreamReader(path);
        //    int counter = 0;
        //    List<string> listtip = new List<string>();
        //    while (!f.EndOfStream)
        //    {
        //        counter += 1;
        //        string s = f.ReadLine();
        //        listtip.Add(s.Split(',')[0]);
        //        listtip.Add(s.Split(',')[1]);
        //        listTips.Add(listtip);
        //    }
        //    f.Close();

        //    SollicitatieTipsCollectionView.ItemsSource = listTips;


        //    return listTips;

        //}

    }
}