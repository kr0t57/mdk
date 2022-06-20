using System.Configuration;
using System.Reflection;
using System.Windows;

namespace Task4
{
    public partial class SettingsWindow : Window
    {
        private string _login => ConfigurationManager.AppSettings["Login"];
        private string _password => ConfigurationManager.AppSettings["Password"];
        private string _database => ConfigurationManager.AppSettings["Database"];

        public SettingsWindow()
        {
            InitializeComponent();
            LoginTextBox.Text = _login;
            PasswordTextBox.Text = _password;
            DatabaseTextBox.Text = _database;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            ConfigurationManager.AppSettings.Set("Login", LoginTextBox.Text);
            ConfigurationManager.AppSettings.Set("Password", PasswordTextBox.Text);
            ConfigurationManager.AppSettings.Set("Database", DatabaseTextBox.Text);
            var config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            config.AppSettings.Settings["Login"].Value = LoginTextBox.Text;
            config.AppSettings.Settings["Password"].Value = PasswordTextBox.Text;
            config.AppSettings.Settings["Database"].Value = DatabaseTextBox.Text;
            config.Save(ConfigurationSaveMode.Modified);
            new AuthorizationWindow().Show();
            Close();
        }
    }
}
