using System;
using System.Windows;
using Task1.Properties;

namespace Task1
{
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            LoginTextBox.Text = Settings.Default.Login;
            PasswordTextBox.Text = Settings.Default.Password;
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var isLoginCorrect = LoginTextBox.Text == Settings.Default.Login;
                var isPasswordCorrect = PasswordTextBox.Text == Settings.Default.Password;
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
