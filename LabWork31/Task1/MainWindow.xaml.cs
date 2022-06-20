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

namespace Task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            datePicker.DisplayDateEnd = DateTime.Now.Date;
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var isLoginCorrect = !String.IsNullOrWhiteSpace(loginTextBox.Text);
            var isPasswordCorrect = !String.IsNullOrWhiteSpace(passwordTextBox.Text);
            var isSamePassword = passwordTextBox.Text == passwordConfirmTextBox.Text;

            if (isLoginCorrect && isPasswordCorrect && isSamePassword)
            {
                MessageBox.Show($"{loginTextBox.Text}, вы зарегистрированы");
            }
        }

        private void datePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedDate = datePicker.SelectedDate.Value;
            var age = DateTime.Now.Year - selectedDate.Year;
            ageLabel.Content = $"Возраст: {(selectedDate.DayOfYear < DateTime.Now.DayOfYear ? age : age - 1)}";
        }
    }
}
