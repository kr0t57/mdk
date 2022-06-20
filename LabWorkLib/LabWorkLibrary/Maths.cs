using System;

namespace LabWorkLibrary
{
    /// <summary>
    /// Математические функции
    /// </summary>
    public class Maths
    {
        /// <summary>
        /// Число Pi
        /// </summary>
        public const double PI = 3.1;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// вычитание двух чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returnsразность двух чисел</returns>
        public static double Difference(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// умножение a на b
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returns>произведение двух чисел</returns>
        public static double Multiplication(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// деление a на b
        /// </summary>
        /// <exception cref="ArgumentException">Генерирует исключение при попытке деления на 0</exception>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returns>частное двух чисел</returns>
        public static double Division(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException($"{nameof(b)} не может быть 0");
            }

            return a / b;
        }

        /// <summary>
        /// рассчёт площади прямоугольника
        /// </summary>
        /// <param name="a">Ширина</param>
        /// <param name="b">Высота</param>
        /// <returns>частное двух чисел</returns>
        public static double RectangleArea(double w, double h)
        {
            return w * h;
        }
    }
}
