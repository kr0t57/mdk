using System.Windows;

namespace Task5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeBackgroundButton_OnClick(object sender, RoutedEventArgs e)
        {
            var colorSelectorWindow = new ColorSelectorWindow();
            if (colorSelectorWindow.ShowDialog()!.Value)
                Background = colorSelectorWindow.SelectedColor;
        }
    }
}
