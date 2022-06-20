using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task4
{
    public partial class MainWindow : Window
    {
        private List<FileInfo> _files = new List<FileInfo>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            var filterWindow = new FilterWindow();
            filterWindow.filterTextBox.TextChanged += ApplyFilter;
            filterWindow.ShowDialog();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(pathTextBox.Text))
            {
                MessageBox.Show("Указанный путь не существует!");
                return;
            }

            _files = new DirectoryInfo(pathTextBox.Text).GetFiles("*", SearchOption.AllDirectories).ToList();
            DisplayByName();
        }

        private void ApplyFilter(object sender, TextChangedEventArgs e)
        {
            DisplayByName(((TextBox)sender).Text);
        }

        private void DisplayByName(string name = "")
        {
            dataGrid.ItemsSource = _files.Where(x => x.Name.Contains(name));
        }
    }
}
