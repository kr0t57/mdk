using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows;
using Microsoft.Win32;

namespace Task2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnClosing(object sender, CancelEventArgs e)
        {
            var result = MessageBox.Show("Do you want to close the application?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.No) 
                e.Cancel = true;
        }

        private void SaveButton_OnClick(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = @"(*.txt)|*.txt|(*.cs)|*.cs|(*.html)|*.html|(*.css)|*.css|(*.js)|*.js|(*.sql)|*.sql";

            if (!saveFileDialog.ShowDialog()!.Value)
                return;

            try
            {
                var path = saveFileDialog.FileName;
                File.WriteAllText(path, TextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}