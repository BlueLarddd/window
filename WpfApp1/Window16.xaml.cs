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
    /// Логика взаимодействия для Window16.xaml
    /// </summary>
    public partial class Window16 : Window
    {
        public Window16()
        {
            InitializeComponent();
        }

        private void Pers_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Мулан, Фа Сенха - бабушка Мулан. Мушу - дракончик, который был одним из хранителей семейства Фа. Кри-Ки - сверчок-талисман. Ли Шанг - молодой офицер. Яо, Линг и Чьен-По - сослуживцы Мулан.");
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Для великого народа наступили тяжелые времена: на страну напало воинственное племя гуннов. Переодевшись в мужскую одежду, Мулан присоединяется к другим воинам и отправляется в опасный поход к подножию заснеженных гор. Ее сопровождает забавный дракончик Мушу, который больше похож на маленькую собачку, чем на мифическое чудовище. Пытаясь скрыть тайну, они попадают в забавные ситуации и не подозревают, что их секрет вот - вот раскроется");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Window13 Window16 = new Window13();
            this.Close();
            Window16.Show();
        }
    }
}
