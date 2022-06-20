using System;
using System.Configuration;
using System.Windows;

namespace Task4
{
    public partial class AuthorizationWindow : Window
    {
        private string _login => ConfigurationManager.AppSettings["Login"];
        private string _password => ConfigurationManager.AppSettings["Password"];

        public AuthorizationWindow()
        {
            InitializeComponent();
            LoginTextBox.Text = _login;
            PasswordTextBox.Text = _password;
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var isLoginCorrect = LoginTextBox.Text == _login;
                var isPasswordCorrect = PasswordTextBox.Text == _password;
                if (isLoginCorrect && isPasswordCorrect) 
                    new MainWindow().Show();
                else 
                    new SettingsWindow().Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
