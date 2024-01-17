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
    /// Логика взаимодействия для Window18.xaml
    /// </summary>
    public partial class Window18 : Window
    {
        public Window18()
        {
            InitializeComponent();
        }

        private void Pers_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Главными героями являются: Лингвини-молодой парнишка, сам Реми-небольшой крыс мечтавший стать шеф поваром, Колетт-самый суровый шеф повар, Антуан Эго-кулинарный критик, Живодэр-повар, Огюст Гюсто-куинарный гений Парижа, Эмиль-младший брат Реми, и Джанго-вожак племени крысиного.");
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Крыс Реми обладает уникальным вкусом. Он готов рисковать собственной жизнью, чтобы посмотреть любимое кулинарное шоу и раздобыть какую-нибудь приправку или просто свежий продукт. Реми живет со своими сородичами, которые его не понимают и не принимают его увлечения кулинарией. Когда Реми случайно попадает на кухню шикарного ресторана, он решает воспользоваться выпавшим ему шансом и проверить свои навыки. На эту же кухню попадает и юный Лингвини. Всё, на что он может рассчитывать — это должность уборщика. Но он тоже получает свой шанс.");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Window13 Window18 = new Window13();
            this.Close();
            Window18.Show();
        }
    }
}
