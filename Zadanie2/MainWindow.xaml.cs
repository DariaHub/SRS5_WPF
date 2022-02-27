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

namespace Zadanie2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Sl.Minimum = 0;
        }
        private void Sl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
          
            lb.Content = Convert.ToUInt64(Sl.Value);
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string str = tbx.Text;
            if (tbx.Text == "")
            {
                tbx.Text = "0";
            }
            if (Char.IsDigit(tbx.Text, 0) && str.Length < 19)
            {
                Sl.Minimum = Convert.ToDouble(tbx.Text) * 4;
                Sl.Maximum = Convert.ToDouble(tbx.Text) * 16;
            }
            else
            {
                tbx.Text = "0";
            }
        }

     
    }
}
