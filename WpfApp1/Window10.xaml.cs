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
    /// Логика взаимодействия для Window10.xaml
    /// </summary>
    public partial class Window10 : Window
    {
        public Window10()
        {
            InitializeComponent();
        }

        private void Pers_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Геральт, Йеннифер, Трисс, Цири, Лютик и верная Плотва. А также император Эмгыр, вампир Регис, рыцарь Кагыр, колдун Вильгефорц, лучница Мильва, охотник за головами Лео Бонарт, дракон (!) Виллентретенмерт и Ангулема.");
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ведьмак Геральт из Ривии, мутант и убийца чудовищ, изо всех сил старается найти своё место в мире, где люди часто оказываются намного хуже монстров[3]. Сюжет первого сезона большей частью представляет собой вольную интерпретацию некоторых рассказов первых двух книг саги о Ведьмаке — «Последнее желание» и «Меч Предназначения». Сюжет второго сезона обещает стать адаптацией книги «Кровь эльфов», попутно экранизировавшей ранее пропущенные истории из вышеназванных сборников.");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Window7 Window10 = new Window7();
            this.Close();
            Window10.Show();
        }
    }
}
