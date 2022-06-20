using System;
using System.Linq;

namespace Task2
{
    internal sealed class Program
    {
        private static void Main()
        {
            Console.Write("Введите строку: ");
            string line = Console.ReadLine();

            Console.Write("Выберите действие. 0 - lowerCase, 1 - upperCase, 2 - invertedText: ");
            Int32.TryParse(Console.ReadLine(), out int action);

            Console.WriteLine(action switch
            {
                0 => line.ToLower(),
                1 => line.ToUpper(),
                2 => String.Join(string.Empty, line.Select(x => Char.IsUpper(x) ? Char.ToLower(x) : Char.ToUpper(x)))
            });
        }
    }
}
