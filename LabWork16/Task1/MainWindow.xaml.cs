using System;
using System.IO;
using System.Linq;
using System.Windows;

namespace Task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonRequest_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPath.Text))
            {
                MessageBox.Show("Неверный путь!", string.Empty, MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            DirectoryInfo directory = new DirectoryInfo(textBoxPath.Text);
            FileInfo[] files = directory.GetFiles("", SearchOption.AllDirectories);

            dataGrid.ItemsSource = files.Select(x => new { x.Name, x.DirectoryName, x.Extension, x.Length, x.CreationTime });
        }
    }
}
