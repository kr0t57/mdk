using System.Windows;
using System.Windows.Controls;

namespace Task3
{
    public partial class FilterWindow : Window
    {
        public delegate void NameChanged(string name);
        public NameChanged nameChanged;

        public FilterWindow()
        {
            InitializeComponent();
        }

        private void filterTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            var textBox = (TextBox)sender;
            nameChanged?.Invoke(textBox.Text);
        }
    }
}
