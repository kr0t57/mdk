using System.Windows;

namespace Task1
{
    public partial class ConfirmExitWindow : Window
    {
        public ConfirmExitWindow()
        {
            InitializeComponent();
        }

        private void YesButton_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void NoButton_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}