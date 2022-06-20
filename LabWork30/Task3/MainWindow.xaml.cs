using System;
using System.Windows;
using System.Windows.Controls;

namespace Task3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            inputTextBox.FontSize = Convert.ToInt32(((RadioButton)sender).Content);
        }
    }
}
