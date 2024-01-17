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
    /// Логика взаимодействия для Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Действие первого и второго сезонов разворачивается в Мадриде вокруг группы авантюристов, использующих названия городов в качестве кодовых имён, во главе с таинственным Профессором. Их план заключается в том, чтобы вынести 2,4 миллиарда евро из Испанского королевского монетного двора  (исп.)рус.. Взявшей в заложники 67 человек команде предстоит в течение 11 дней напечатать деньги, противостоя при этом элитным силам полиции.После этого участники команды вынуждены залечь на дно на два года, а затем организовать второе ограбление, на этот раз — Банка Испании.");
        }

        private void Pers_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Силена Оливейра, Токио. Серхио Маркина, Профессор Ракель Мурильо, Лиссабон. Андрес де Фонойоса, Берлин Анибаль Кортес, Рио Даниэль Рамос, Денвер Эстер Асебо Esther Acebo Энрике Арсе Enrique Arce Дарко Перич Darko Peric Альба Флорес Alba Flores Фернандо Сото Fernando Soto Марио де ла Роса.");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Window7 Window8 = new Window7();
            this.Close();
            Window8.Show();
        }
    }
}
