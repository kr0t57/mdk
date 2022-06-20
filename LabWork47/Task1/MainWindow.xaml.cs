using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using MessageBox = System.Windows.MessageBox;

namespace Task1
{
    public partial class MainWindow : Window
    {
        private FileInfo[] _files;
        private int _currentImage = 0;
        private readonly IEnumerable<string> _imageExtensions = new List<string>()
        {
            ".png",
            ".jpg"
        };

        public MainWindow()
        {
            InitializeComponent();
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
                    .Where(file => _imageExtensions.Contains(file.Extension))
                    .ToArray();
                ShowImage();
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
                if (_currentImage == 0)
                    _currentImage = _files.Length - 1;
                _currentImage--;
                ShowImage();
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
                if (_currentImage == _files.Length - 1)
                    _currentImage = 0;
                _currentImage++;
                ShowImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ShowImage()
        {
            try
            {
                Title = _files[_currentImage].Name;
                Image.Source = new BitmapImage(new Uri(_files[_currentImage].FullName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ChangeStretch_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                Image.Stretch = ((Slider)sender).Value == 0
                    ? Stretch.Uniform
                    : Stretch.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ChangeColorScheme_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                var format = ((Slider)sender).Value switch
                {
                    0 => PixelFormats.BlackWhite,
                    1 => PixelFormats.Gray32Float,
                    2 => PixelFormats.Indexed2,
                    _ => PixelFormats.Bgra32
                };
                Image.Source = new FormatConvertedBitmap(
                    new BitmapImage(new Uri(_files[_currentImage].FullName)),
                    format, null, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
