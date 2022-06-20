using System;

namespace Task3
{
    internal sealed class Program
    {
        private static void Main()
        {
            var user = new User();
            user.OnChanged += (object sender, DataEventArgs e) => Console.WriteLine($"{e?.Date} у пользователя {((User)sender).Login} изменено {e.Parameter}");
            user.Login = "login";
            user.Password = "password";
        }
    }
}
