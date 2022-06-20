using System;
using System.Windows;
using System.Windows.Media;

namespace Task5
{
    public partial class ColorSelectorWindow : Window
    {
        public ColorSelectorWindow()
        {
            InitializeComponent();
        }

        public Brush SelectedColor => new SolidColorBrush(Color.FromRgb(Convert.ToByte(GreenSlider.Value), Convert.ToByte(RedSlider.Value), Convert.ToByte(BlueSlider.Value)));

        private void OkButton_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void Slider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Background = SelectedColor;
        }
    }
}
