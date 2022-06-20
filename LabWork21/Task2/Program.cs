using System;
using System.Threading;

namespace Task2
{
    internal sealed class Program
    {
        private static void Main()
        {
            var user = new User();
            user.OnChanged += (object sender, EventArgs e) => Console.WriteLine($"Изменены данные пользователя со следующим логином: {((User)sender).Login}");
            user.Login = "123";
            user.Password = "123";
        }
    }
}
