using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_databinding
{
    public class Player : INotifyPropertyChanged
    {
        private string _naam;
        public string Name {
            get { return _naam; }
            set {
                _naam = value;
               NotifyPropertyChanged("Name");
            }
        }
        private int _score;

       
        public event PropertyChangedEventHandler PropertyChanged;

        public int Score {
            get { return _score; }
            set { _score = value; NotifyPropertyChanged("Score"); 
            }

        }
        private void NotifyPropertyChanged(string propertyName) {
            if (null != PropertyChanged) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
