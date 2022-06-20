using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Task1
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private List<FileInfo> _files = new List<FileInfo>();

        private int _numberOfRecods = 5;
        private int _currentPage = 1;
        private int _countOfPages = 1;

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
        }

        internal int NumberOfRecords
        {
            get => _numberOfRecods;
            set
            {
                if (value != _numberOfRecods)
                {
                    _numberOfRecods = value;
                }
                NotifyPropertyChange();
            }
        }

        internal int CurrentPage
        {
            get => _currentPage;
            set
            {
                if (value != _currentPage)
                {
                    int lastPage = GetLastPage();
                    _currentPage = value < 1 ? 1 : value > lastPage ? lastPage : value;
                }
                NotifyPropertyChange();
            }
        }

        internal int CountOfPages
        {
            get => _countOfPages;
            set
            {
                _countOfPages = value;
                NotifyPropertyChange();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PropertyChanged += Property_Changed;
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Volk2\Desktop\Папка");
            _files = directory.GetFiles("*", SearchOption.AllDirectories).OrderBy(x => x.Name).ToList();
            ShowRecords();
            EnabledOrDisabledButtons();
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text[0]))
            {
                e.Handled = true;
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            Int32.TryParse(textBox.Text, out var value);
            Int32.TryParse(textBox.Uid, out var uid);

            switch (uid)
            {
                case 0:
                    NumberOfRecords = value;
                    break;
                case 1:
                    CurrentPage = value;
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            Int32.TryParse(button.Uid, out var uid);

            switch (uid)
            {
                case 0:
                    CurrentPage = 1;
                    break;
                case 1:
                    CurrentPage--;
                    break;
                case 2:
                    CountOfPages++;
                    return;
                case 3:
                    CurrentPage++;
                    break;
                case 4:
                    CurrentPage = GetLastPage();
                    break;
            }
            CountOfPages = 1;
        }

        private void ShowRecords()
        {
            int numberOfRecordsForSkip = (_currentPage - 1) * _numberOfRecods;
            dataGrid.ItemsSource = _files.Select(x => new { x.Name, x.FullName, x.Length, x.CreationTime })
                .Skip(numberOfRecordsForSkip).Take(_numberOfRecods * _countOfPages);
            entriesShownLabel.Content = $"Показано {dataGrid.Items.Count} из {_files.Count}";
        }

        private int GetLastPage()
        {
            return Convert.ToInt32(Math.Ceiling((double)_files.Count / _numberOfRecods));
        }

        private void Property_Changed(object sender, PropertyChangedEventArgs e)
        {
            ShowRecords();
            switch (e?.PropertyName)
            {
                case nameof(NumberOfRecords):
                    numberOfRecordsTextBox.Text = $"{_numberOfRecods}";
                    break;
                case nameof(CurrentPage):
                    pageTextBox.Text = $"{_currentPage}";
                    break;
            }
            EnabledOrDisabledButtons();
        }

        private void EnabledOrDisabledButtons()
        {
            bool showedAllRecords = _files.Count - (_currentPage - 1) * _numberOfRecods == dataGrid.Items.Count;
            bool enabledFirstButtons = !(_currentPage == 1);
            bool enabledLastButtons = !(_currentPage + _countOfPages - 1 >= GetLastPage());

            firstPageButton.IsEnabled = enabledFirstButtons;
            previousPageButton.IsEnabled = enabledFirstButtons;
            nextPageButton.IsEnabled = enabledLastButtons;
            lastPageButton.IsEnabled = enabledLastButtons;
            showMoreButton.IsEnabled = !showedAllRecords;
        }

        private void NotifyPropertyChange([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(null, new PropertyChangedEventArgs(name));
        }
    }
}
