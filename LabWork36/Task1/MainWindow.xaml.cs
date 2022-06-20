using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace Task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnClosing(object sender, CancelEventArgs e)
        {
            e.Cancel = new ConfirmExitWindow().ShowDialog()!.Value;
        }

        private void OpenButton_OnClick(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"(*.png)|*.png|(*.jpg)|*.jpg|(*.bmp)|*.bmp";

            if (openFileDialog.ShowDialog()!.Value) 
                Image.Source = new BitmapImage(new Uri(openFileDialog.FileName));
        }
    }
}