using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void showListBoxValuesButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var values = String.Join("\n", listBox.Items
               .Cast<CheckBox>()
               .Where(c => c.IsChecked.Value)
               .Select(c => c.Content));
                MessageBox.Show($"Значения:\n{values}");
            }
            catch { }
        }
    }
}
