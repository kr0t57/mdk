using System.Windows;
using System.Windows.Controls;

namespace Task4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            inputTextBox.TextAlignment = ((RadioButton)sender).Content switch
            {
                "По левому краю" => TextAlignment.Left,
                "По центру" => TextAlignment.Center,
                "По правому краю" => TextAlignment.Right
            };
        }
    }
}
