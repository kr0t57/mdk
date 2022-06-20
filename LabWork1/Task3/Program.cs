using System;

namespace Task3
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            int[] array = new int[] { 7, 0, -4, 3, 1, -2, 5 };
            array = Sort(array);
            Console.WriteLine(string.Join(", ", array));
        }

        /// <summary>
        /// Сортировка методом прямого включения
        /// </summary>
        /// <param name="array">Массив для сортировки</param>
        /// <returns>Возвращается отсортированный массив</returns>
        private static int[] Sort(int[] array)
        {
            int i, j, temp;
            for (i = 1; i < array.Length; i++)
            {
                temp = array[i];
                for (j = i - 1; j >= 0 && array[j] > temp; j--)
                {
                    array[j + 1] = array[j];
                }
                array[j + 1] = temp;
            }

            return array;
        }
    }
}
