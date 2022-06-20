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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Path.Text))
            {
                MessageBox.Show("Неверный путь!", string.Empty, MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            DirectoryInfo directory = new DirectoryInfo(textBox_Path.Text);
            FileInfo[] files = directory.GetFiles("", SearchOption.AllDirectories);

            dataGrid.ItemsSource = files.Select(x => new { x.Name, x.FullName, x.Length, x.CreationTime })
                .OrderBy(x => x.Name).ThenByDescending(x => x.CreationTime);
        }
    }
}
