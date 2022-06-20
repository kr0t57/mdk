using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Task5
{
    public partial class MainWindow : Window
    {
        private List<FileInfo> _files;

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
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_files == null)
            {
                return;
            }

            DateTime now = DateTime.Now;

            dataGrid.ItemsSource = (comboBox.SelectedIndex switch
            {
                0 => _files.Where(x => x.CreationTime.Date == now.Date),
                1 => _files.Where(x => x.CreationTime.Date >= now.AddDays(-7).Date),
                2 => _files.Where(x => x.CreationTime.Month == now.Month)
            }).Select(x => new { x.Name, x.Extension, x.DirectoryName, x.Length, x.CreationTime, x.LastWriteTime });

            textBlockInfo.Text = dataGrid.Items.Count == 0 ? $"Записей не найдено" : string.Empty;
        }
    }
}
