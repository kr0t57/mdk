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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Task1
{
    public partial class MainWindow : Window
    {
        private DateTime _startTime;

        public MainWindow()
        {
            InitializeComponent();
            _startTime = DateTime.Now;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            new DispatcherTimer(TimeSpan.FromSeconds(1), DispatcherPriority.Normal, (object? sender, EventArgs e) 
                => infoTextBlock.Text = $"Started: {_startTime}   Current Time: {DateTime.Now.ToLongTimeString()}", Dispatcher).Start();
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AboutProgramMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Developers: ", "About program", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void StatusBarMenuItemChangeState(object sender, RoutedEventArgs e)
        {
            statusBar.Visibility = ((MenuItem)sender).IsChecked ? Visibility.Visible : Visibility.Hidden;
        }

        private void Menu_MouseEnter(object sender, MouseEventArgs e)
        {
            var menu = sender as Menu;

            if (menu == null)
            {
                return;
            }

            menu.Width = menu.Items.OfType<MenuItem>().Max(x => x.Width);
        }

        private void Menu_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Menu).Width = 25;
        }
    }
}
