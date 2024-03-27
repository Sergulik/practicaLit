
using p2.clasese;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace p2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object PovtorPass { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);    
        }

        private void voiti_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            var login = LoginBox.Text;
            var pass = PasswordBox.Text;
            var ppass = PovtorPassBox.Text;
            var context = new AppDbContext();
            var user_exists = context.Users.FirstOrDefault(X => X.LoginBox == login);
            if (user_exists is not null)
            {
                MessageBox.Show("Такой пользoватель уже в клубе топ челиков");
                return;
            }
            var user = new User {  Login = login, Password = pass };
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("Welcome to the club, buddy");
        }

    }

}