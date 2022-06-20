using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using Task1Wpf.MarketDataSetTableAdapters;

namespace Task1Wpf
{
    public partial class AddNewBookWindow : Window
    {
        private readonly AuthorTableAdapter _authorAdapter = new AuthorTableAdapter();
        private readonly BookTableAdapter _bookAdapter = new BookTableAdapter();

        public AddNewBookWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var table = new MarketDataSet.AuthorDataTable();
            _authorAdapter.Fill(table);
            AuthorComboBox.ItemsSource = table;
            AuthorComboBox.DisplayMemberPath = "LastName";
            YearSlider.Maximum = DateTime.Now.Year;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = (Slider)sender;
            slider.ToolTip = Math.Round(slider.Value, 4);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var table = new MarketDataSet.BookDataTable();
                var row = table.NewBookRow();
                row.Genre = GenreTextBox.Text;
                row.Title = TitleTextBox.Text;
                row.Price = Convert.ToDecimal(PriceSlider.Value);
                row.Weight = Convert.ToDecimal(MassSlider.Value);
                var authorId = ((MarketDataSet.AuthorRow)((DataRowView)AuthorComboBox.SelectedItem).Row).IdAuthor;
                row.IdAuthor = authorId;
                row.ReleaseYear = Convert.ToInt16(YearSlider.Value);
                row.Pages = 20;
                table.Rows.Add(row);
                _bookAdapter.Update(table);
                MessageBox.Show($"Добавлена запись с id {row.IdBook}", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
