using System;
using System.Text.RegularExpressions;

namespace Task1
{
    internal sealed class Program
    {
        private static void Main()
        {
            Console.WriteLine("Введите строку:");
            string line = Console.ReadLine();
            Console.WriteLine(Regex.IsMatch(line, @"^\+7\(9\d{2}\)-\d{3}-\d{2}-\d{2}$") ? "Строка является номером телефона" : "Строка не является номером телефона");
        }
    }
}
