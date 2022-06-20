using System.Windows;
using System.Windows.Controls;

namespace Task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AgreeCheckBoxStateChanged(object sender, RoutedEventArgs e)
        {
            subscribeButton.IsEnabled = ((CheckBox)sender).IsChecked.Value;
        }
    }
}
