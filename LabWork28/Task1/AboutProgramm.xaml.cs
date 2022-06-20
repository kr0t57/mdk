using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Task1
{
    public partial class AboutProgramm : Window
    {
        public AboutProgramm()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var assemblyInfo = new AssemblyInfo(GetType().Assembly);
            infoTextBlock.Text = $"Продукт: {assemblyInfo.ProductName}\nОписание: {assemblyInfo.Description}\n" +
                $"Компания: {assemblyInfo.CompanyName}\nАвторские права: {assemblyInfo.Copyright}";
        }
    }
}
