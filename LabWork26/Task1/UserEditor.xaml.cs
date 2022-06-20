using System;
using System.Windows;

namespace Task1
{
    public partial class UserEditor : Window
    {
        public User ChangedUser { get; private set; }

        public UserEditor()
        {
            InitializeComponent();
        }

        public UserEditor(User user) : this()
        {
            loginTextBox.Text = user.Login;
            passwordTextBox.Text = user.Password;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            ChangedUser = new User() { Login = loginTextBox.Text, Password = passwordTextBox.Text };
        }
    }
}
