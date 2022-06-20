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
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageBox = System.Windows.MessageBox;

namespace Task2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var openFileDialog = new FolderBrowserDialog();
                openFileDialog.ShowDialog();
                var files = new DirectoryInfo(openFileDialog.SelectedPath).GetFiles("*", SearchOption.AllDirectories);
                Chart.ChartAreas.Add(new ChartArea("Default"));
                var chartArea = Chart.ChartAreas["Default"];

                Chart.Series.Add(new Series("Series"));
                var series = Chart.Series["Series"];
                series.ChartArea = "Default";
                series.ChartType = SeriesChartType.Radar;

                var extensions = files
                    .Select(item => item.Extension);
                foreach (var extension in extensions.Distinct())
                {
                    var count = extensions.Count(item => item == extension);
                    series.Points.AddXY($"{extension} count: {count}", count);
                }

                Chart.Legends.Add(new Legend 
                {
                    Name = "Legend",
                    Title = "Extensions"
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Close();
            }
        }
    }
}
