using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public sealed class User
    {
        private string _login;
        private string _password;
        private string _passwordConfirmation;

        public User(string login, string password, string passwordConfirmation)
        {
            _login = login;
            _password = password;
            _passwordConfirmation = passwordConfirmation;
        }

        public static bool IsCorrectData(string login, string password, string passwordConfirmation)
        {
            var isLoginCorrect = !String.IsNullOrWhiteSpace(login);
            var isPasswordCorrect = !String.IsNullOrWhiteSpace(password);
            var isConfirmCorrect = password == passwordConfirmation;
            return isLoginCorrect && isPasswordCorrect && isConfirmCorrect;
        }
    }
}
