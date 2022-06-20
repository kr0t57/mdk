using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal sealed class User
    {
        private string _login;
        private string _password;

        public EventHandler<DataEventArgs> OnChanged;

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(this);
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(this);
            }
        }

        private void OnPropertyChanged(object sender, [CallerMemberName] string name = "")
        {
            OnChanged?.Invoke(sender, new DataEventArgs() { Parameter = name, Date = DateTime.Now });
        }
    }
}
