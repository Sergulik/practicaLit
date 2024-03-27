using p2.clasese;
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

namespace p2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 reg = new Window1();
            reg.Show();

            this.Hide();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var login=LoginBox.Text;
            var password = PasswordBox.Text;    
            var context = new AppDbContext();
            var user = context.Users.SingleOrDefault(x => x.Login ==login && x.Password == password);
            if (user is null)
            {
                MessageBox.Show("ТЫ НЕ ПРОЙДЕШЬ!!!!!");
                return;
            }
            MessageBox.Show("Вы успешно зашли в акк");
        }


    }
}
