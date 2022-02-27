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

namespace Zadanie1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void j_Click(object sender, RoutedEventArgs e)
        {
            a.Background = Brushes.Crimson;
            b.Background = Brushes.Tomato;
            c.Background = Brushes.Orange;
            d.Background = Brushes.SandyBrown;
            ee.Background = Brushes.Khaki;
            f.Background = Brushes.GreenYellow;
            g.Background = Brushes.MediumSpringGreen;
            h.Background = Brushes.SkyBlue;
            i.Background = Brushes.DodgerBlue;
            j.Background = Brushes.SlateBlue;
        }
    }
}
