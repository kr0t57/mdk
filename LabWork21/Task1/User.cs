using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal sealed class User
    {
        private string _login;
        private string _password;

        public event Action<string> MyEvent;

        public string Login
        {
            get => _login;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    MyEvent?.Invoke("Невозможно изменить логин на пустую строку");
                }
                else
                {
                    _login = value;
                    MyEvent?.Invoke($"Логин изменён на {value}");
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (value.Length < 6 || value.Length > 20)
                {
                    MyEvent?.Invoke("Длина пароля должна быть от 6 до 20 символов");
                }
                else
                {
                    _password = value;
                    MyEvent?.Invoke($"Пароль изменён на {value}");
                }
            }
        }
    }
}
