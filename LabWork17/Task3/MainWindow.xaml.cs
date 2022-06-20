using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Task3
{
    public partial class MainWindow : Window
    {
        private List<FileInfo> _files = new();

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

        private void CheckBox_ChangeCheckedState(object sender, RoutedEventArgs e)
        {
            List<CheckBox> checkBoxes = childrenGrid.Children.OfType<CheckBox>().ToList();

            var result = _files.Select(x => new { x.Name, x.Extension, x.DirectoryName, x.Length, x.CreationTime, x.LastWriteTime });

            foreach (CheckBox checkBox in checkBoxes)
            {
                result = checkBox.IsChecked.Value ? Int32.Parse(checkBox.Uid) switch
                {
                    0 => result.Where(x => x.Extension == ".exe"),
                    1 => result.Where(x => x.Length < 10240) // 10240 - 10 КБ в байтах
                } : result;
            }

            textBlockInfo.Text = result.Count() == 0 ? $"Записей с выбранными фильтрами не найдено." : string.Empty;

            dataGrid.ItemsSource = result;
        }
    }
}
