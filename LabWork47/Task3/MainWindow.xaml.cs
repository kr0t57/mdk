using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace Task3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PlayAudio(System.IO.Path.Combine(Environment.CurrentDirectory, @"..\..\..\Resources\deny.mp3"));
        }

        private void OpenFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new OpenFileDialog();
                dialog.InitialDirectory = @"C:\Temp\ISPP01\mdk0101\LabWork47\Multimedia";
                dialog.ShowDialog();
                PlayAudio(dialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            MediaElement.Position = new TimeSpan(0, 0, 0);
            MediaElement.Play();
        }

        private void PlayAudio(string path)
        {
            MediaElement.Source = new Uri(path);
            MediaElement.Play();
        }

        private void PlayAudio_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            PlayAudio(System.IO.Path.Combine(Environment.CurrentDirectory, @"..\..\..\Resources\deny.mp3"));
        }

        private void StopAudio_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MediaElement.Pause();
        }
    }
}
