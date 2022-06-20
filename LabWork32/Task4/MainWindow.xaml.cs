using System;
using System.Windows;

namespace Task4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add(new Random().Next());
        }
    }
}
