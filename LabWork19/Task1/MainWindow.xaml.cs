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
        private readonly string _path = @"C:\Temp";
        private List<FileInfo> _files = new List<FileInfo>();
        private List<DirectoryInfo> _directories = new List<DirectoryInfo>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var directoryInfo = new DirectoryInfo(_path);
            _files = directoryInfo.GetFiles("*", SearchOption.AllDirectories).ToList();
            _directories = directoryInfo.GetDirectories("*", SearchOption.AllDirectories).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;

            dataGrid.ItemsSource = Int32.Parse(button.Uid) switch
            {
                0 => _files.GroupBy(g => g.Extension).Select(x => new { Extension = x.Key, Count = x.Count(), Length = x.Sum(x => x.Length) }),
                1 => _files.GroupBy(g => new { g.CreationTime.Year, g.CreationTime.Month })
                        .Select(x => new { Year = x.Key.Year, Mount = x.Key.Month, Count = x.Count() }),
                2 => _files.Select(x => new { x.FullName, x.CreationTime }).Union(_directories.Select(x => new { x.FullName, x.CreationTime })),
                3 => _directories.GroupJoin(_files, g => g.FullName, c => c.DirectoryName, (g, c) => new { g.FullName, Count = g.GetFiles().Count() }),
                4 => _directories.Where(x => x.CreationTime.Date == DateTime.Now.Date)
                        .Join(_files, g => g.FullName, c => c.DirectoryName, (g, c) => new { c.FullName })
            };
        }
    }
}
