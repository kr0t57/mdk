using System.Windows;
using System.Windows.Controls;

namespace Task2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AgreeCheckBoxStateChanged(object sender, RoutedEventArgs e)
        {
            var isShowed = ((CheckBox)sender).IsChecked.Value;

            if (isShowed)
            {
                passwordTextBox.Text = passwordBox.Password;
                passwordBox.Visibility = Visibility.Collapsed;
            }
            else
            {
                passwordBox.Password = passwordTextBox.Text;
                passwordBox.Visibility = Visibility.Visible;
            }
        }
    }
}
