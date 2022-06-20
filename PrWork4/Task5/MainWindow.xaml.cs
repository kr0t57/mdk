using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MenuItem = System.Windows.Controls.MenuItem;
using MessageBox = System.Windows.MessageBox;

namespace Task5
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

        private void ChangeDiagramStyleMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            if (!(sender is MenuItem menuItem)) 
                return;
            var series = Chart.Series["Series"];
            var type = series.ChartType;
            switch (menuItem.Header)
            {
                case "VerticalColumn":
                    type = SeriesChartType.Column;
                    break;
                case "HorizontalColumn":
                    type = SeriesChartType.Bar;
                    break;
                case "Point":
                    type = SeriesChartType.Point;
                    break;
            }
            series.ChartType = type;
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
            var names = files
                .Select(file => file.Name)
                .ToArray();
            var lengths = files
                .Select(file => file.Length)
                .ToArray();
            Chart.Series.Clear();
            Chart.Legends.Clear();
            Chart.Series.Add(new Series("Series"));
            var series = Chart.Series["Series"];
            series.ChartArea = "Default";
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.Points.DataBindXY(names, lengths);
            Chart.Legends.Add("Legend");
        }
    }
}
