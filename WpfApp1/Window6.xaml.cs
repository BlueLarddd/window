﻿using System;
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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void Pers_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Юдзуру Отонаси (яп. 音無 結弦 Отонаси Юдзуру) — главный герой аниме. Попав в Чистилище, не может вспомнить свою прошлую жизнь[1]. По просьбе Юри вступает в организацию «Фронт загробного мира». Вскоре Отонаси начинает вспоминать своё прошлое.Юри Накамура (яп. 仲村 ゆり Накамура Юри) — девушка, которая также известна как Юриппэ (яп. ゆりっぺ). Решительная, но вместе с тем чувствительная и заботливая. Попав в Чистилище, она решает бороться против ангелов и Бога.Канадэ Татибана (яп. 立華 かなで Татибана Канадэ) — президент школьного совета[1]. Обычно не проявляет эмоций и склонна говорить напрямую[2]. Члены «Фронта» называют её Ангелом (яп. 天使 Тэнси), не зная её настоящего имени; даже позднее узнав её настоящее имя, они продолжали называть её по-прежнему.Хидэки Хината (яп. 日向 秀樹 Хината Хидэки) — один из основателей «Фронта загробного мира» наряду с Юри. Очень добрый и надёжный парень, всегда старается помогать друзьям по мере возможности.");
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Главный герой, Отонаси Юдзуру, попадает в странный мир, где обитают души после смерти, — Чистилище. Там он встречает девушку по имени Юри, которая предлагает Отонаси присоединиться к их организации — «Фронт загробного мира» (яп. 死んだ世界戦線 Синда Сэкай Сэнсэн), которая сражается против Бога. Отонаси соглашается на предложение Юри. Постепенно парень входит в суть дел, творящихся в новом мире. А именно, Чистилище — мир, в котором подростки, лишённые радостей юности, могут восполнить данный пробел в своей жизни. Помимо них, здесь обитают «НИПы» (неигровой персонаж, от англ. non-player character — NPC) — существа, похожие на обычных людей, но лишённые сознания, целью которых является лишь имитация обычной школьной жизни, создание массовки.Ангел, чьё настоящее имя Канадэ Татибана, теряет место президента школьного совета, её заменяет вице - президент Наой.Наой использует гипноз для контроля над НИПами и борьбы против «Фронта». Отонаси останавливает Наоя, после чего последний присоединяется к «Фронту». Благодаря гипнозу к Отонаси возвращается память, позднее он становится другом Канадэ и предлагает ей присоединиться к «Фронту». Канадэ вновь становится президентом школьного совета и начинает помогать членам «Фронта».На членов «Фронта» начинают нападать таинственные теневые создания, одно из которых поглощает Такамацу.Отонаси обсуждает с товарищами возможность перехода в статус НИПов.Юри уничтожает компьютер, ответственный за создание теневых монстров, который был запрограммирован на активацию в случае, если в мире обнаруживается любовь.Отонаси, Юри, Канадэ, Хината и Наой участвуют в выпускной церемонии, где выражают друг другу благодарность за поддержку.Отонаси узнаёт о том, что после его смерти Канадэ пересадили его сердце и она сожалела о том, что не смогла поблагодарить его.Влюбившийся в неё Отонаси остаётся несчастным после того, как Канадэ исчезает, поблагодарив его — то есть найдя покой.В эпилоге возродившиеся Отонаси и Канадэ встречаются на улице в реальном мире.В альтернативном эпилоге Отонаси остаётся в Чистилище.");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window2 = new Window1();
            this.Close();
            Window2.Show();
        }
    }
}
