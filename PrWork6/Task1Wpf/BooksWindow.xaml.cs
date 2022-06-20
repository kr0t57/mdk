using System.Windows;
using System.Windows.Controls;
using Task1Wpf.MarketDataSetTableAdapters;

namespace Task1Wpf
{
    public partial class BooksWindow : Window
    {
        private readonly BookTableAdapter _bookAdapter = new BookTableAdapter();

        public BooksWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var table = new MarketDataSet.BookDataTable();
            _bookAdapter.Fill(table);
            DataGrid.ItemsSource = table;
        }
    }
}
