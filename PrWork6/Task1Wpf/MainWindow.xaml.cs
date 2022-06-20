using System.Windows;

namespace Task1Wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenCustomersButton_Click(object sender, RoutedEventArgs e) =>
            new CustomersWindow().ShowDialog();

        private void OpenBooksButton_Click(object sender, RoutedEventArgs e) => 
            new BooksWindow().ShowDialog();

        private void AddBook_Click(object sender, RoutedEventArgs e) =>
            new AddNewBookWindow().ShowDialog();
    }
}
