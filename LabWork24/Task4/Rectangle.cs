using System;

namespace Task4
{
    public class Rectangle : Figure
    {
        public override double GetSquare()
        {
            Console.WriteLine("Ширина: ");
            Double.TryParse(Console.ReadLine(), out var a);
            Console.WriteLine("Высота: ");
            Double.TryParse(Console.ReadLine(), out var b);
            return a * b;
        }
    }
}
