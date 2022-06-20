using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private const int PriceOfHelp = 10;
        private int _numberOfCookies = 0;
        private int _numberOfGrandmothers = 0;
        private DispatcherTimer _timer = new();

        public MainWindow()
        {
            InitializeComponent();
            _timer.Tick += (object sender, EventArgs e) => AddCookies(1);
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            _timer.Start();
        }

        private void CookiesRectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AddCookies(1);
        }

        private void GrandmotherRectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WithdrawCookies(PriceOfHelp);
            _numberOfGrandmothers++;
            GrandmothersCountLabel.Content = _numberOfGrandmothers.ToString();
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / (_numberOfGrandmothers + 1));
            _timer.Start();
        }

        private void AddCookies(int count)
        {
            _numberOfCookies += count;
            DrawCookiesCount();

            if (_numberOfCookies >= PriceOfHelp)
            {
                GrandmotherRectangle.IsEnabled = true;
                GrandmotherRectangle.Opacity = 1;
            }
        }

        private void WithdrawCookies(int count)
        {
            _numberOfCookies -= count;
            DrawCookiesCount();

            if (_numberOfCookies < PriceOfHelp)
            {
                GrandmotherRectangle.IsEnabled = false;
                GrandmotherRectangle.Opacity = 0.5;
            }
        }

        private void DrawCookiesCount()
        {
            CookiesCountLabel.Content = _numberOfCookies.ToString();
        }
    }
}
