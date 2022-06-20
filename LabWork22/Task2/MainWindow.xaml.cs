using System;
using System.IO;
using System.Linq;
using System.Windows;

namespace Task2
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowFiles();
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            ShowFiles();
        }

        private void ShowFiles()
        {
            if (String.IsNullOrWhiteSpace(pathTextBox.Text))
            {
                return;
            }

            resultDataGrid.ItemsSource = new DirectoryInfo(pathTextBox.Text).GetFiles("*", SearchOption.AllDirectories)
                .Select(x => new FileInformation(x.Name, x.Extension, x.DirectoryName, x.Length, x.CreationTime, x.LastWriteTime)).ToList();
        }
    }
}
