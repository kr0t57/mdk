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
using System.Windows.Shapes;

namespace Task4
{
    public partial class FilterWindow2 : Window
    {
        public delegate void TextChanged(string text);
        public event TextChanged OnTextChanged;

        public FilterWindow2()
        {
            InitializeComponent();
        }

        private void filterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            OnTextChanged?.Invoke(((TextBox)sender).Text);
        }
    }
}
