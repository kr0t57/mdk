using System.Windows;
using System.Windows.Media;

namespace Task1
{
    public partial class ColorDialog : Window
    {
        public Brush SelectedColor { get; private set; }

        private ColorDialog()
        {
            InitializeComponent();
        }

        public ColorDialog(Brush currentColor) : this()
        {
            SelectedColor = currentColor;
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            if (colorPicker.SelectedColor != null)
            {
                SelectedColor = new SolidColorBrush(colorPicker.SelectedColor.Value);
            }
            Close();
        }
    }
}
