using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal sealed class User
    {
        private string _login;
        private string _password;

        public EventHandler OnChanged;

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
