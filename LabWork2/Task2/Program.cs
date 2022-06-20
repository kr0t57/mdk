using System;

namespace Task2
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(BinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, 1));
            Console.WriteLine(BinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, 6));
            Console.WriteLine(BinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, 3));
            Console.WriteLine(BinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, 4));
            Console.WriteLine(BinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, -1));
            Console.WriteLine(BinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, 7));
        }

        private static bool BinarySearch(int[] array, int value)
        {
            Array.Sort(array);

            int left = -1, right = array.Length, middle;

            do
            {
                middle = (left + right) / 2;
                if (array[middle] == value)
                {
                    return true;
                }
                if (value < array[middle])
                {
                    right = middle;
                }
                else
                {
                    left = middle;
                }
            } while (left < right - 1);

            return false;
        }
    }
}
