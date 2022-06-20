using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    internal sealed class Program
    {
        private static void Main()
        {
            //2
            Dictionary<string, short> ageByLogin = new Dictionary<string, short>
            {
                {"login", 15},
                {"myLogin", 32},
                {"LoGinnn", 19},
                {"MyLoGin", 15}
            };

            Console.WriteLine("Введите n:");
            int.TryParse(Console.ReadLine(), out int n);

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите возраст: ");
                Int16.TryParse(Console.ReadLine(), out short age);
                ageByLogin.Add(login, age);
            }

            Console.WriteLine($"Количество элементов: {ageByLogin.Count}");
            DisplayDictionary(ageByLogin);

            //3
            Console.WriteLine("\n\n");

            Console.Write("Введите ключ: ");
            string key = Console.ReadLine();

            Console.WriteLine(ageByLogin.ContainsKey(key) ? $"Ключ найден. Значение: {ageByLogin.GetValueOrDefault(key)}" : "Ключ в словаре отсутствует.");

            Console.WriteLine("Введите значение:");
            Int16.TryParse(Console.ReadLine(), out short value);

            Console.WriteLine($"Количество совпадений значения: {ageByLogin.Values.Count(x => x == value)}");

            Console.Write("Введите ключ для удаления: ");
            string keyForDelete = Console.ReadLine();

            ageByLogin.Remove(keyForDelete);
            DisplayDictionary(ageByLogin);
        }

        private static void DisplayDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
        {
            Console.WriteLine(string.Join("\n", dictionary));
        }
    }
}
