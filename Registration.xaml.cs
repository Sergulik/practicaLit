﻿using p2.clasese;
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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void ToAuthBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            var login = LogingTB.Text;
            var email = EmailTB.Text;
            var pass = PasswordTB.Text;
            var context = new AppDbContext();
            var user_exists = context.Users.FirstOrDefault(X => X.Login == login);
            if (user_exists is not null)
            {
                MessageBox.Show("Такой пользoватель уже в клубе топ челиков");
                return;
            }
            var User = new User { Login = login, Password = pass, Email = email };
            context.Users.Add(User);
            context.SaveChanges();
            MessageBox.Show("Welcome to the club, buddy");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
