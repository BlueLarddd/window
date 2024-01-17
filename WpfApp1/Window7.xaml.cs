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
    /// Логика взаимодействия для Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }

        private void Ser1_Click(object sender, RoutedEventArgs e)
        {
            Window8 Window7 = new Window8();
            this.Close();
            Window7.Show();
        }

        private void Ser2_Click(object sender, RoutedEventArgs e)
        {
            Window9 Window7 = new Window9();
            this.Close();
            Window7.Show();
        }

        private void Ser3_Click(object sender, RoutedEventArgs e)
        {
            Window10 Window7 = new Window10();
            this.Close();
            Window7.Show();
        }

        private void Ser4_Click(object sender, RoutedEventArgs e)
        {
            Window11 Window7 = new Window11();
            this.Close();
            Window7.Show();
        }

        private void Ser5_Click(object sender, RoutedEventArgs e)
        {
            Window12 Window7 = new Window12();
            this.Close();
            Window7.Show();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Window1 = new MainWindow();
            this.Close();
            Window1.Show();
        }
    }
}
