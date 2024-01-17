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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Window1 = new MainWindow();
            this.Close();
            Window1.Show();
        }

        private void Anime1_Click(object sender, RoutedEventArgs e)
        {
            Window2 Window1 = new Window2();
            this.Close();
            Window1.Show();
        }

        private void Anime2_Click(object sender, RoutedEventArgs e)
        {
            Window3 Window1 = new Window3();
            this.Close();
            Window1.Show();
        }

        private void Anime3_Click(object sender, RoutedEventArgs e)
        {
            Window4 Window1 = new Window4();
            this.Close();
            Window1.Show();
        }

        private void Anime4_Click(object sender, RoutedEventArgs e)
        {
            Window5 Window1 = new Window5();
            this.Close();
            Window1.Show();
        }

        private void Anime5_Click(object sender, RoutedEventArgs e)
        {
            Window6 Window1 = new Window6();
            this.Close();
            Window1.Show();
        }
    }
}
