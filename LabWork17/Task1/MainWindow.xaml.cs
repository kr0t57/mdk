using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Task1
{
    public partial class MainWindow : Window
    {
        private List<FileInfo> _files = new List<FileInfo>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Request_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPath.Text))
            {
                MessageBox.Show("Неверный путь!", string.Empty, MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            DirectoryInfo directory = new DirectoryInfo(textBoxPath.Text);
            _files = directory.GetFiles("", SearchOption.AllDirectories).ToList();
            dataGrid.ItemsSource = _files.Select(x => new { x.Name, x.Extension, x.DirectoryName, x.Length, x.CreationTime, x.LastWriteTime });
            DisplayInfo();
        }

        private void ClearFilterButton_Click(object sender, RoutedEventArgs e)
        {
            textBoxFilter.Text = string.Empty;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            dataGrid.ItemsSource = _files.Where(x => x.Name.ToUpper().Contains(textBoxFilter.Text.ToUpper()))
                .Select(x => new { x.Name, x.Extension, x.DirectoryName, x.Length, x.CreationTime, x.LastWriteTime });
            DisplayInfo();
        }

        private void DisplayInfo()
        {
            int numOfFoundFiles = dataGrid.Items.Count;
            textBlockFilterInfo.Text = numOfFoundFiles == 0 ? $"Файлов с названием: {textBoxFilter.Text} не найдено" : $"Показано: {numOfFoundFiles} из {_files.Count} файлов";
        }
    }
}
