using System;
using System.Text.RegularExpressions;

namespace Task3
{
    internal sealed class Program
    {
        private static void Main()
        {
            Console.WriteLine("Введите строку:");
            string line = Console.ReadLine();

            Regex regex = new Regex(@"^[a-z\d\-_]+@([a-z\d]+\.)+[a-z]{2,}$", RegexOptions.IgnoreCase);

            Console.WriteLine(regex.IsMatch(line) ? "Это email" : "Не email");
        }
    }
}
