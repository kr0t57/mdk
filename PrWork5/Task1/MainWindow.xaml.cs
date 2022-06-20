using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace Task1
{
    public partial class MainWindow : Window
    {
        public MainWindow() =>
            InitializeComponent();

        private void OpenLineMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HideAllElements();
            TextBox.Visibility = Visibility.Visible;
            TextBox.Text = Properties.Resources.Line;
        }

        private void OpenImageMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HideAllElements();
            Image.Visibility = Visibility.Visible;
            using var stream = new MemoryStream(Properties.Resources.Image);
            var bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = null;
            bitmap.StreamSource = stream;
            bitmap.CacheOption = BitmapCacheOption.OnLoad;
            bitmap.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
            bitmap.EndInit();
            Image.Source = bitmap;
        }

        private void OpenFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HideAllElements();
            TextBox.Visibility = Visibility.Visible;
            TextBox.Text = Properties.Resources.document;
        }

        private void OpenSiteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HideAllElements();
            WebBrowser.Visibility = Visibility.Visible;
            WebBrowser.NavigateToString(Properties.Resources.main);
        }

        private void HideAllElements()
        {
            TextBox.Visibility = Visibility.Collapsed;
            Image.Visibility = Visibility.Collapsed;
            WebBrowser.Visibility = Visibility.Collapsed;
        }
    }
}
