using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace Task2
{
    public partial class MainWindow : Window
    {
        private FileInfo[] _files;
        private int _currentVideo = 0;
        private readonly IEnumerable<string> _videoExtensions = new List<string>()
        {
            ".mp4",
            ".gif"
        };

        public MainWindow()
        {
            InitializeComponent();
            MediaElement.Source = new Uri(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Resources\wait.gif"));
        }

        private void OpenFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new FolderBrowserDialog();
                dialog.SelectedPath = @"C:\Temp\ISPP01\mdk0101\LabWork47\Multimedia";
                dialog.ShowDialog();
                _files = new DirectoryInfo(dialog.SelectedPath)
                    .GetFiles("*", SearchOption.AllDirectories)
                    .Where(file => _videoExtensions.Contains(file.Extension))
                    .ToArray();
                ShowVideo();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("В папке нет нужных файлов.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void PreviewButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_currentVideo == 0)
                    _currentVideo = _files.Length - 1;
                _currentVideo--;
                ShowVideo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_currentVideo == _files.Length - 1)
                    _currentVideo = 0;
                _currentVideo++;
                ShowVideo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ShowVideo()
        {
            try
            {
                Title = _files[_currentVideo].Name;
                MediaElement.Source = new Uri(_files[_currentVideo].FullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MediaElement.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MediaElement.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MediaElement.Pause();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
