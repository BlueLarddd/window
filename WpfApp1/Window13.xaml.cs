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
    /// Логика взаимодействия для Window13.xaml
    /// </summary>
    public partial class Window13 : Window
    {
        public Window13()
        {
            InitializeComponent();
        }

        private void Mul1_Click(object sender, RoutedEventArgs e)
        {
            Window14 Window13 = new Window14();
            this.Close();
            Window13.Show();
        }

        private void Mul2_Click(object sender, RoutedEventArgs e)
        {
            Window15 Window13 = new Window15();
            this.Close();
            Window13.Show();
        }

        private void Mul3_Click(object sender, RoutedEventArgs e)
        {
            Window16 Window13 = new Window16();
            this.Close();
            Window13.Show();
        }

        private void Mul4_Click(object sender, RoutedEventArgs e)
        {
            Window17 Window13 = new Window17();
            this.Close();
            Window13.Show();
        }

        private void Mul5_Click(object sender, RoutedEventArgs e)
        {
            Window18 Window13 = new Window18();
            this.Close();
            Window13.Show();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Window1 = new MainWindow();
            this.Close();
            Window1.Show();
        }
    }
}
