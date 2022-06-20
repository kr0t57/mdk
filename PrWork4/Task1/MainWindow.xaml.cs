using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MessageBox = System.Windows.MessageBox;

namespace Task2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            Chart.ChartAreas.Add(new ChartArea("Default"));
            Chart.ChartAreas["Default"].AxisX.Interval = 1;
            OpenFileMenuItem_OnClick(sender, e);
        }

        private void OpenFileMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                AnalysisDirectory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SaveFileMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new SaveFileDialog()
                {
                    Filter = "png (*.png)|*.png|bmp (*.bmp)|*.bmp"
                };
                dialog.ShowDialog();
                var fileInfo = new FileInfo(dialog.FileName);
                var extension = fileInfo.Extension == ".png" 
                    ? ChartImageFormat.Png 
                    : ChartImageFormat.Bmp;
                Chart.SaveImage(fileInfo.FullName, extension);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AnalysisDirectory()
        {
            var dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            if (!Directory.Exists(dialog.SelectedPath)) 
                throw new FileNotFoundException();
            var files = new DirectoryInfo(dialog.SelectedPath)
                .GetFiles("*", SearchOption.AllDirectories)
                .OrderBy(file => file.Extension);
            var extensions = files
                .Select(file => file.Extension)
                .Distinct();
            var counts = files
                .GroupBy(file => file.Extension)
                .Select(file => file.Count());
            Chart.Series.Clear();
            Chart.Legends.Clear();
            Chart.Series.Add(new Series("Series"));
            var series = Chart.Series["Series"];
            series.ChartArea = "Default";
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            series.Points.DataBindXY(extensions.ToArray(), counts.ToArray());
            Chart.Legends.Add("Legend");
        }
    }
}
