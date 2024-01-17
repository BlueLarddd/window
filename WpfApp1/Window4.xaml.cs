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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Pers_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Юи Хирасава (яп. 平沢 唯 Хирасава Юи) — участница «клуба лёгкой музыки», играет на электрогитаре Gibson Les Paul Standard in Heritage Cherry Sunburst. Из-за своего ребячества, легкомыслия и наивности в школе получает не самые лучшие оценки, а музыкальную теорию игнорирует, предпочитая всё изучать на практике.Мио Акияма (яп. 秋山 澪 Акияма Мио) — высокая тёмноволосая застенчивая девушка, играющая на бас-гитаре для левшей Fender Jazz Bass in 3-Color Sunburst с «черепаховым» пикгардом. Изначально хотела вступить в литературный клуб, но Рицу, её подруга детства, смогла переубедить девушку, и та вступила в «клуб лёгкой музыки».Рицу Таинака (яп. 田井中 律 Таинака Рицу) — президент «клуба лёгкой музыки», играет на ударной установке Yamaha HipGig Rick Marotta Signature. Именно благодаря её усилиям удалось собрать группу Ho-kago Tea Time.Цумуги Котобуки (яп. 琴吹 紬 Котобуки Цумуги), или же просто Муги — милая, добродушная, жизнерадостная и немного наивная девушка, из богатой семьи, играющая на синтезаторе Korg Triton Extreme 76 Key. Адзуса Накано (яп. 中野 梓 Накано Адзуса) — новая ученица, которая последней присоединяется к «клубу лёгкой музыки» и играет на гитаре Fender Mustang. На год младше всех остальных участников, учится в одном классе с сестрой Юи.");
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Начав обучение в старшей школе, беззаботная Юи Хирасава оказывается перед нелёгким выбором: все японские школьники должны вступить в какой-нибудь школьный клуб, чтобы не стать NEET. Тем временем движимые мечтой о собственной музыкальной группе старшеклассницы Таинака Рицу, Акияма Мио и примкнувшая к ним позднее Котобуки Цумуги пытаются возродить школьный «клуб лёгкой музыки». Однако, все бывшие участники выпустились со школы, а в клубе, согласно правилам, должны состоять не менее четырёх учеников. Чтобы спасти клуб от закрытия, уже отчаявшиеся кого-либо найти девушки принимают в свой клуб Юи, которая не умеет играть ни на одном музыкальном инструменте, ни даже читать ноты. Тем не менее, участницы клуба не теряют надежды и к выпускному обещают себе выступить на главной музыкальной арене Японии — Будокан.");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window2 = new Window1();
            this.Close();
            Window2.Show();
        }
    }
}
