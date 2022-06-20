using System.Windows;
using System.Windows.Media.Animation;

namespace Task2
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

            MainButton.BeginAnimation(FontSizeProperty, fontSizeAnimation);
            MainButton.BeginAnimation(WidthProperty, widthAnimation);
            MainButton.BeginAnimation(HeightProperty, heightAnimation);
        }
    }
}
