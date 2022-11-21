using System;
using System.Collections.Generic;
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

namespace Losowanie4a
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void wygeneruj_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(liczba1.Text,out int a))
            {
                if(int.TryParse(liczba2.Text,out int b))
                {
                    if(a > b)
                    {
                        int pomoc = a;
                        a = b;
                        b = pomoc;
                    }
                    int liczba = random.Next(a,b+1);
                    MessageBox.Show(liczba.ToString());
                    zmianawidoku();
                    return;
                }
            }
            MessageBox.Show("Musi być poprawnie wypełniony formularz",
                "Ostrzeżenie", MessageBoxButton.OK, MessageBoxImage.Warning);
           
        }

        void zmianawidoku()
        {
            liczba1.Visibility = Visibility.Collapsed;
            liczba2.Visibility = Visibility.Collapsed;
        }
    }
}
