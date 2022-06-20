using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Task2
{
    public partial class MainWindow : Window
    {
        private List<FileInfo> _files;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_Size_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (char.IsNumber(e.Text, 0) == false)
            {
                e.Handled = true;
            }
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (_files == null || textBoxSize.Text.Length == 0)
            {
                return;
            }

            long size = Int64.Parse(textBoxSize.Text);

            RadioButton radioButton = (RadioButton)sender;
            dataGrid.ItemsSource = (Int32.Parse(radioButton.Uid) switch
            {
                0 => _files.Where(x => x.Length <= size),
                1 => _files.Where(x => x.Length >= size)
            }).Select(x => new { x.Name, x.Extension, x.DirectoryName, x.Length, x.CreationTime, x.LastWriteTime });

            textBlockInfo.Text = dataGrid.Items.Count == 0 ? $"Записей с размером: {size} не найдено!" : string.Empty;
        }

        private void ClearFilters_Click(object sender, RoutedEventArgs e)
        {
            childrenGrid.Children.OfType<RadioButton>().Select(x => x.IsChecked = false);
            dataGrid.ItemsSource = _files.Select(x => new { x.Name, x.Extension, x.DirectoryName, x.Length, x.CreationTime, x.LastWriteTime });
        }
    }
}
