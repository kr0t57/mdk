using System;
using System.Text.RegularExpressions;

namespace Task4
{
    internal sealed class Program
    {
        private static void Main()
        {
            Regex regex = new Regex(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[\?\.\!]).{6,}");
            string password = string.Empty;

            do
            {
                Console.Write("Введите пароль: ");
                password = Console.ReadLine();
            } while (!regex.IsMatch(password));
        }
    }
}
