using System;
using System.IO;
using System.Linq;
using System.Windows;

namespace Task4
{
    public partial class MainWindow : Window
    {
        private readonly long oneMbInBytes = 1048576;
        private readonly long oneKbInBytes = 1024;

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

            dataGrid.ItemsSource = files.Select(x => new
            {
                x.Name,
                x.Extension,
                x.DirectoryName,
                Length = x.Length < oneMbInBytes ? $"{x.Length / oneKbInBytes} КБ" : $"{x.Length / oneMbInBytes} МБ"
            });
        }
    }
}
