using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Task1
{
    public partial class MainWindow : Window
    {
        private List<User> _users = new();

        private int _selectedRowIndex = -1;

        public MainWindow()
        {
            InitializeComponent();
            usersDataGrid.LoadingRow += UsersDataGrid_LoadingRow;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _users = new List<User>()
            {
                new User() { Login = "login", Password = "password" },
                new User() { Login = "Lkwetorglg", Password = "pass" },
                new User() { Login = "Poetpwto", Password = "!qiruQUWIyrq" },
                new User() { Login = "login", Password = "password" },
                new User() { Login = "Lkwetorglg", Password = "pass" },
                new User() { Login = "Poetpwto", Password = "!qiruQUWIyrq" },
                new User() { Login = "login", Password = "password" },
                new User() { Login = "Lkwetorglg", Password = "pass" },
                new User() { Login = "Poetpwto", Password = "!qiruQUWIyrq" }
            };
            ShowUsers();
        }

        private void UsersDataGrid_LoadingRow(object? sender, DataGridRowEventArgs e)
        {
            if (_selectedRowIndex == e.Row.GetIndex())
            {
                e.Row.Background = new BrushConverter().ConvertFromString("#FFCC66") as Brush;
            }
            else if (((User)e.Row.DataContext).Password.Length < 6)
            {
                e.Row.Background = new SolidColorBrush(Color.FromRgb(200, 10, 0));
            }
        }

        private void DataGridCell_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var user = (User)((DataGridRow)sender).DataContext;
            _selectedRowIndex = _users.IndexOf(user);
            var userEditor = new UserEditor(user);
            userEditor.ShowDialog();
            _users[_selectedRowIndex] = userEditor.ChangedUser;
            ShowUsers();
        }

        private void ShowUsers()
        {
            usersDataGrid.ItemsSource = null;
            usersDataGrid.ItemsSource = _users;
        }
    }
}
