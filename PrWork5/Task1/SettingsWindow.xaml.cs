using System.Windows;
using Task1.Properties;

namespace Task1
{
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
            LoginTextBox.Text = Settings.Default.Login;
            PasswordTextBox.Text = Settings.Default.Password;
            DatabaseTextBox.Text = Settings.Default.Database;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.Login = LoginTextBox.Text;
            Settings.Default.Password = PasswordTextBox.Text;
            Settings.Default.Database = DatabaseTextBox.Text;
            Settings.Default.Save();
            new AuthorizationWindow().Show();
            Close();
        }
    }
}
