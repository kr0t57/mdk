using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Windows;

namespace Task3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            var path = openFileDialog.FileName;

            if (!File.Exists(path))
            {
                MessageBox.Show($"Файл {path} не существует.");
            }

            var sb = new StringBuilder();

            try
            {
                using (var fs = new StreamReader(path))
                {
                    while (true)
                    {
                        var line = fs.ReadLine();

                        if (String.IsNullOrEmpty(line))
                        {
                            break;
                        }

                        if (line.Contains(searchTextBox.Text))
                        {
                            sb.AppendLine(line);
                        }
                    }
                }
            }
            catch(Exception exc) 
            {
                MessageBox.Show(exc.Message);
            }

            resultTextBlock.Text = sb.ToString();
        }
    }
}
