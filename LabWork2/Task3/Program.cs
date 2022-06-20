using System;

namespace Task3
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(JumpSearch(new int[] { 1, 2, 3, 4, 5, 6 }, 1));
            Console.WriteLine(JumpSearch(new int[] { 1, 2, 3, 4, 5, 6 }, 6));
            Console.WriteLine(JumpSearch(new int[] { 1, 2, 3, 4, 5, 6 }, 3));
            Console.WriteLine(JumpSearch(new int[] { 1, 2, 3, 4, 5, 6 }, 4));
            Console.WriteLine(JumpSearch(new int[] { 1, 2, 3, 4, 5, 6 }, -1));
            Console.WriteLine(JumpSearch(new int[] { 1, 2, 3, 4, 5, 6 }, 7));
        }

        private static bool JumpSearch(int[] array, int value)
        {
            Array.Sort(array);

            if (value < array[0] || value > array[array.Length - 1])
            {
                return false;
            }

            int lastValue = int.MinValue, result = -1, i;
            int step = (int)Math.Sqrt(array.Length);

            for (i = 0; i < array.Length; i += step)
            {
                if (value < array[i])
                {
                    break;
                }
                lastValue = i;
            }

            for (i = lastValue; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    result = i;
                }
            }

            return result == -1 ? false : true;
        }
    }
}
