using System;
using System.Linq;

namespace Task5
{
    internal sealed class Program
    {
        private static void Main()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            string[] lines = new string[]
            {
                "программу, выводящую на экран все строки",
                "с указанного пользователем текста",
                "Если совпадение не найдено, сообщить об этом"
            };

            string[] foundLines = lines.Where(x => x.StartsWith(text)).ToArray();

            Console.WriteLine(foundLines.Length > 0 ? String.Join("\n", foundLines) : $"Строк начинающихся с: {text} не найдено.");
        }
    }
}
