using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
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
        /// Сортировка методом простого выбора
        /// </summary>
        /// <param name="array">Массив для сортировки</param>
        /// <returns>Возвращается отсортированный массив</returns>
        private static int[] Sort(int[] array)
        {
            int i, j, temp, min;

            for (i = 0; i < array.Length - 1; i++)
            {
                min = i;
                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    temp = array[min];
                    array[min] = array[i];
                    array[i] = temp;
                }
            }
            return array;
        }
    }
}
