using System;

namespace Task1
{
    internal sealed class Program
    {
        private static User _user;

        private static void Main()
        {
            Console.WriteLine("Введите логин:");
            var login = Console.ReadLine();
            Console.WriteLine("Введите пароль:");
            var password = Console.ReadLine();
            Console.WriteLine("Введите пароль повторно:");
            var passwordConfirmation = Console.ReadLine();

            if (User.IsCorrectData(login, password, passwordConfirmation))
            {
                Console.WriteLine("Успешно!");
                _user = new User(login, password, passwordConfirmation);
            }
            else
            {
                Console.WriteLine("Данные не корректны!");
            }
        }
    }
}
