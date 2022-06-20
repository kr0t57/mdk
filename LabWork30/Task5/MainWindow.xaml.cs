using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetBackground();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SetBackground();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            redSplitter.IsEnabled = redCheckBox.IsChecked.Value;
            greenSplitter.IsEnabled = greenCheckBox.IsChecked.Value;
            blueSplitter.IsEnabled = blueCheckBox.IsChecked.Value;
            SetBackground();
        }

        private void SetBackground()
        {
            var red = Convert.ToByte(redSplitter.IsEnabled ? redSplitter.Value : 0);
            var green = Convert.ToByte(greenSplitter.IsEnabled ? greenSplitter.Value : 0);
            var blue = Convert.ToByte(blueSplitter.IsEnabled ? blueSplitter.Value : 0);
            Background = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }
    }
}
