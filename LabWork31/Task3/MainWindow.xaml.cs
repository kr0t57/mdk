using System.Windows;

namespace Task3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            resultTextBlock.Text = $"Price: {priceSlider.Value:F2}\nPercent: {percentSlider.Value:F2}\nResult: {priceSlider.Value / 100 * percentSlider.Value:F2}";
        }
    }
}
