using System;

namespace Task1
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(IndexOf(new int[] { 1, 6, 3, 2, 8 }, 8));
            Console.WriteLine(IndexOf(new int[] { 1, 36, 23, 25, 8 }, 13));
        }

        /// <summary>
        /// Поиск элемента в массиве
        /// </summary>
        /// <param name="array">Массив для поиска элемента</param>
        /// <param name="value">Значение для поиска в массиве</param>
        /// <returns>Возвращает индекс элемента в массиве, если элемент отсутсвует возвращается -1</returns>
        private static int IndexOf(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
