using System;
using System.IO;
using System.Linq;
using System.Windows;

namespace Task5
{
    public partial class MainWindow : Window
    {
        private readonly long oneMbInBytes = 1048576;

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

            label.Content = $"Количество файлов: {files.Count()}\nОбщий объём: {files.Sum(x => x.Length) / oneMbInBytes} MB";
        }
    }
}
