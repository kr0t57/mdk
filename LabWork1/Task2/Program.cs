using System;

namespace Task2
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
        /// Сортировка методом пузырька
        /// </summary>
        /// <param name="array">Массив для сортировки</param>
        /// <returns>Возвращается отсортированный массив</returns>
        private static int[] Sort(int[] array)
        {
            int i, j, temp;
            for (i = 0; i < array.Length - 1; i++)
            {
                for (j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
