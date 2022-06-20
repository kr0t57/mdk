using System;
using System.IO;

namespace Task1
{
    internal sealed class Program
    {
        private static void Main()
        {
            Console.Write("Введите путь: ");
            var path = Console.ReadLine();

            try
            {
                Console.WriteLine(File.Exists(path) ? File.ReadAllText(path) : $"Файл {path} не существует.");
            }
            catch (Exception exp) 
            { 
                Console.WriteLine(exp.Message);
            }
        }
    }
}
