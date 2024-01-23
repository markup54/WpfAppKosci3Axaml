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
        public int LiczbaKosci { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Rezultaty = new ObservableCollection<Kosc>();
            LiczbaKosci = 10;
            wyzerujRzut();
            DataContext = this;
            
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
