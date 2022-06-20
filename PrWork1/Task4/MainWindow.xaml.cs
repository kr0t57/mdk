using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Task4
{
    public partial class MainWindow : Window
    {
        private string _path = @"C:\Temp\ISPP01\mdk0101\PractWork1\Task4\users.txt";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введены некорректные данные");
                return;
            }

            var logins = new List<string>();

            try
            {
                using (var fs = new StreamReader(_path))
                {
                    while (true)
                    {
                        var user = fs.ReadLine();

                        if (string.IsNullOrEmpty(user))
                        {
                            break;
                        }

                        var data = user.Split(';');
                        logins.Add(data[0]);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            if (logins.Contains(login))
            {
                MessageBox.Show("Пользователь с таким логином уже зарегистрирован.");
                return;
            }

            try
            {
                File.AppendAllLines(_path, new List<string>() { $"{login};{password};{DateTime.Now}" });
                MessageBox.Show("Вы успешно зарегистрированы.");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
