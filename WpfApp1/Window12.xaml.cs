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
    /// Логика взаимодействия для Window12.xaml
    /// </summary>
    public partial class Window12 : Window
    {
        public Window12()
        {
            InitializeComponent();
        }

        private void Pers_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Алек, Алекс Кэирнс,Анна,БакстерБетани Грей (Бет),Блу Колсон,Брайан,Ванесса Дал.");
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Первые два сезона были выпущены продюсерской фирмой Чарли Брукера Zeppotron по заказу компании Endemol. В пресс-релизе Endemol назвал «Чёрное зеркало» «гибридом „Сумеречной зоны“ и „Непридуманных историй“», который эксплуатирует тему нашего постоянного беспокойства по поводу современного мира и охватившей его техно-паранойи. Телеканал Channel 4, на котором шла трансляция сериала, охарактеризовал первый эпизод, «Национальный гимн», как «лихо закрученную притчу в эпоху Twitter». Первый сезон «Чёрного зеркала» транслировался на телеканале Channel 4 с 4 по 18 декабря 2011 года, второй — с 11 по 25 февраля 2013 года.В сентябре 2015 года американский стриминговый сервис Netflix заказал 12 новых эпизодов «Чёрного зеркала», которые планировалось разбить на два сезона. В марте 2016 года Netflix купил права на трансляцию сериала за 40 млн долларов. Названия шести серий третьего сезона были объявлены в июле 2016 года.");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Window7 Window12 = new Window7();
            this.Close();
            Window12.Show();
        }
    }
}
