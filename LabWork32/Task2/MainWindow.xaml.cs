using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Task2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Users = new List<User>()
            {
                new User(0, "log", "pass"),
                new User(1, "logqetq", "p25dfass"),
                new User(2, "logyy5r", "pas2456s"),
                new User(3, "log4stwsdg", "paettss"),
                new User(4, "log24", "pasweggs")
            };
            DataContext = this;
        }

        public List<User> Users { get; set; }

        private void UsersListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            usersListView.ItemsSource = ((ListBox)sender).SelectedItems.Cast<User>().ToList();
        }
    }
}
