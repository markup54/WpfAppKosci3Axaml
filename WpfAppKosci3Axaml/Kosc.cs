using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppKosci3Axaml
{
    public class Kosc:INotifyPropertyChanged
    {
        private int _wartosc;
        public int Wartosc
        {
            get
            {
                return _wartosc;
            }
            //get => _wartosc;
            set
            {
                _wartosc = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Wartosc)));
                }

            }
        }
        private bool _zaznaczona;
        public bool Zaznaczona
        {
            get => _zaznaczona;
            set
            {
                _zaznaczona = value;
                if(PropertyChanged != null) { 
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Zaznaczona)));
                }
            }
        }

        public Kosc()
        {
            Wartosc = 0;
            Zaznaczona = false;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
