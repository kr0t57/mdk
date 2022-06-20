using System.Windows;
using System.Windows.Controls;
using Task1Wpf.MarketDataSetTableAdapters;

namespace Task1Wpf
{
    public partial class CustomersWindow : Window
    {
        private readonly CustomerTableAdapter _customerAdapter = new CustomerTableAdapter();

        public CustomersWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var table = new MarketDataSet.CustomerDataTable();
            _customerAdapter.Fill(table);
            DataGrid.ItemsSource = table.DefaultView;
        }
    }
}
