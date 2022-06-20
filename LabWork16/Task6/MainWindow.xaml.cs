using System;
using System.IO;
using System.Linq;
using System.Windows;

namespace Task6
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

            Int32.TryParse(textBox.Text, out int year);

            label.Content = $"Количество файлов созданных в {year}: {files.Count(x => x.CreationTime.Year == year)}";
        }
    }
}
