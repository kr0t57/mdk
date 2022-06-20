using System;
using LabWorkLibrary;

namespace Task1
{
    internal sealed class Program
    {
        private static void Main()
        {
            Console.WriteLine(Maths.PI);
            Console.WriteLine(Maths.Sum(5, 5));
            Console.WriteLine(Maths.Difference(5, 5));
            Console.WriteLine(Maths.Multiplication(5, 5));
            Console.WriteLine(Maths.Division(5, 5));
            Console.WriteLine(Maths.RectangleArea(5, 5));
            Console.WriteLine(Maths.Division(5, 0));
        }
    }
}
