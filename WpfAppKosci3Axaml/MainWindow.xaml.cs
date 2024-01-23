using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppKosci3Axaml
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Kosc> Rezultaty { get; set; }
        public ObservableCollection<Punkty> Punkciki { get; set; }
        public int LiczbaKosci { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Rezultaty = new ObservableCollection<Kosc>();
            LiczbaKosci = 10;
            wyzerujRzut();
            DataContext = this;
            przygotujPunkty();

        }

        private void przygotujPunkty()
        {
            Punkciki = new ObservableCollection<Punkty>();
            Punkciki.Add(new Punkty("szkola jedynki"));
            Punkciki.Add(new Punkty("szkola dwójki"));
            Punkciki.Add(new Punkty("szkola trójki"));
            Punkciki.Add(new Punkty("szkola czwórki"));
            Punkciki.Add(new Punkty("szkola piątki"));
            Punkciki.Add(new Punkty("szkola szóstki"));
            Punkciki.Add(new Punkty("para"));
            Punkciki.Add(new Punkty("dwie pary"));
            Punkciki.Add(new Punkty("trójka"));
            Punkciki.Add(new Punkty("full"));
            Punkciki.Add(new Punkty("kareta"));
            Punkciki.Add(new Punkty("poker"));
            Punkciki.Add(new Punkty("mały strit"));
            Punkciki.Add(new Punkty("duży strit"));
            Punkciki.Add(new Punkty("szansa"));
        }
        private void wyzerujRzut()
        {
            
            Rezultaty.Clear();
            for (int i = 0; i < LiczbaKosci; i++)
            {
                Rezultaty.Add(new Kosc());
            }
        }

        private void btn_wyczysc_Click(object sender, RoutedEventArgs e)
        {
            wyzerujRzut();
        }

        private void btn_rzuc_Click(object sender, RoutedEventArgs e)
        {
            
            Random random = new Random();
            foreach (Kosc k in Rezultaty)
            {
                if(k.Zaznaczona == false)
                {
                    k.Wartosc = random.Next(1, 7);
                }
            }
            pokazPunkty();
        }
        private int sumaWszystkichOczek()
        {
            int suma = 0;
            foreach(Kosc k in Rezultaty)
            {
                suma = suma + k.Wartosc;
            }
            return suma;
        }
        private  void pokazPunkty()
        {
            if (Punkciki[14].Zaznaczone == false) {
                Punkciki[14].LiczbaPunktow = sumaWszystkichOczek();
                    }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
           // Button btn = sender as Button;
           Kosc kosc = btn.DataContext as Kosc;
            kosc.Zaznaczona = ! kosc.Zaznaczona;
        }
    }
}
