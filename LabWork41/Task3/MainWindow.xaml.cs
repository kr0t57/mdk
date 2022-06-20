using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Task3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var fontSizeAnimation = new DoubleAnimation();
            fontSizeAnimation.From = MainButton.FontSize;
            fontSizeAnimation.To = MainButton.FontSize * 2;
            fontSizeAnimation.RepeatBehavior = new RepeatBehavior(2);
            fontSizeAnimation.AutoReverse = true;

            var widthAnimation = new DoubleAnimation();
            widthAnimation.From = MainButton.Width;
            widthAnimation.To = MainButton.Width * 2;
            widthAnimation.RepeatBehavior = new RepeatBehavior(2);
            widthAnimation.AutoReverse = true;

            var heightAnimation = new DoubleAnimation();
            heightAnimation.From = MainButton.Height;
            heightAnimation.To = MainButton.Height * 2;
            heightAnimation.RepeatBehavior = new RepeatBehavior(2);
            heightAnimation.AutoReverse = true;

            var brush = new SolidColorBrush(Colors.Red);
            var colorAnimation = new ColorAnimation();
            colorAnimation.From = brush.Color;
            colorAnimation.To = Colors.White;
            colorAnimation.RepeatBehavior = new RepeatBehavior(2);
            colorAnimation.AutoReverse = true;
            MainButton.Background = brush;

            MainButton.BeginAnimation(FontSizeProperty, fontSizeAnimation);
            MainButton.BeginAnimation(WidthProperty, widthAnimation);
            MainButton.BeginAnimation(HeightProperty, heightAnimation);
            brush.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);
        }
    }
}
