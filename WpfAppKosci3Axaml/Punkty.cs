using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppKosci3Axaml
{
    public class Punkty:NotifyPropertyChanged
    {
        private string _nazwa;
        public string Nazwa
        {
            get { return _nazwa; }
            set { _nazwa = value; }
        }
        //public Nazwa {get;set; }
        private int _liczbaPunktow;
        public int LiczbaPunktow
        {
            get => _liczbaPunktow;
            set
            {
                _liczbaPunktow = value;
                OnPropertyChanged();
            }
        }

        private bool _zaznaczone;
        public bool Zaznaczone
        {
            get => _zaznaczone;
            set
            {
                _zaznaczone = value;
                OnPropertyChanged();
            }
        }

        public Punkty(string nazwa)
        {
            Nazwa = nazwa;
            LiczbaPunktow = 0;
            Zaznaczone = false;
        }
    }
}
