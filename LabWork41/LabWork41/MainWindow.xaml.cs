using System.Windows;
using System.Windows.Media.Animation;

namespace Task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var animation = new DoubleAnimation();
            animation.From = MainButton.FontSize;
            animation.To = MainButton.FontSize * 2;
            animation.RepeatBehavior = new RepeatBehavior(2);
            animation.AutoReverse = true;
            MainButton.BeginAnimation(FontSizeProperty, animation);
        }
    }
}
