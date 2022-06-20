using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Task4
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
            if (String.IsNullOrEmpty(textBox_Path.Text))
            {
                MessageBox.Show("Неверный путь!", string.Empty, MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            DirectoryInfo directory = new DirectoryInfo(textBox_Path.Text);
            _files = directory.GetFiles("", SearchOption.AllDirectories).ToList();
            dataGrid.ItemsSource = _files.Select(x => new { x.Name, x.Extension, x.DirectoryName, x.Length, x.CreationTime, x.LastWriteTime });
        }

        private void datePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DisplayInfo();
        }

        private void checkBox_ChangeState(object sender, RoutedEventArgs e)
        {
            DisplayInfo();
        }

        private void DisplayInfo()
        {
            if (_files == null)
            {
                return;
            }

            if (datePicker.Text.Length == 0)
            {
                MessageBox.Show("Укажите дату!", string.Empty, MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            DateTime.TryParse(datePicker.Text, out DateTime selectedDate);

            dataGrid.ItemsSource = (checkBox.IsChecked.Value switch
            {
                true => _files.Where(x => x.LastWriteTime > selectedDate),
                false => _files
            }).Select(x => new { x.Name, x.Extension, x.DirectoryName, x.Length, x.CreationTime, x.LastWriteTime });

            textBlockInfo.Text = dataGrid.Items.Count == 0 ? $"Файлов{(checkBox.IsChecked.Value ? "измененных после" : string.Empty)} {selectedDate.ToShortDateString()} не найдено" : string.Empty;
        }
    }
}
