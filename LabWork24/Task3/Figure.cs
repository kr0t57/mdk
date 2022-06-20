using System;

namespace Task3
{
    public class Figure
    {
        private const double PI = 3.1415;
        private string _type;

        public Figure(string type)
        {
            _type = type;
        }

        private double? GetSquare()
        {
            switch (_type.ToUpper())
            {
                case "RECTAGLE":
                    Console.WriteLine("Ширина: ");
                    Double.TryParse(Console.ReadLine(), out var a);
                    Console.WriteLine("Высота: ");
                    Double.TryParse(Console.ReadLine(), out var b);
                    return a * b;
                case "CIRCLE":
                    Console.WriteLine("Радиус: ");
                    Double.TryParse(Console.ReadLine(), out var Radius);
                    return PI * Radius * Radius;
                case "RING":
                    Console.WriteLine("Введите R: ");
                    Double.TryParse(Console.ReadLine(), out var R);
                    Console.WriteLine("Введите r:");
                    Double.TryParse(Console.ReadLine(), out var r);
                    return PI * R * R - PI * r * r;
            }

            return null;
        }
    }
}
