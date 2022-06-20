using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Task1
{
    public sealed class User : INotifyPropertyChanged
    {
        private string _login;
        private string _password;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
