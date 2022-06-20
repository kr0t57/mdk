using System;

namespace Task1
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Square(5)); 
            Console.WriteLine(Square(5, 3));
            Console.WriteLine(RationalFunc(5, 2));
            Console.WriteLine(RationalFunc(5));
        }

        /// <summary>
        /// Площадь квадрата
        /// </summary>
        /// <param name="side">Сторона квадрата</param>
        /// <returns></returns>
        private static int Square(int side)
        {
            return side * side;
        }

        /// <summary>
        /// Площадь прямоугольника
        /// </summary>
        /// <param name="height">высота прямоугольника</param>
        /// <param name="width">ширина прямоугольника</param>
        /// <returns></returns>
        private static int Square(int height, int width)
        {
            return height * width;
        }

        /// <summary>
        /// Возвращает значение функции 1/x^n
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static double RationalFunc(double x, int n)
        {
            if (n < 0)
            {
                return -1;
            }
            double res = x;
            for (int i = 0; i < n; i++)
            {
                res *= x;
            }
            return res;
        }

        /// <summary>
        /// Возвращает значение функции 1/x
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static double RationalFunc(double x)
        {
            return 1 / x;
        }
    }
}
