using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TransLionApp.Controls
{
    public class Enter: INotifyPropertyChanging
    {
        public int hasEntered;

        public List<Enter> enters = new List<Enter>();
        

        public int HasEntered
        {
            get { return hasEntered; }
            set
            {
                if (hasEntered != value)
                {
                    hasEntered = value;
                    OnPropertyChanged("HasEntered");
                }
            }
        }

        
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;

        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
