using System;

namespace Task4
{
    public class Circle : Figure
    {
        public override double GetSquare()
        {
            Console.WriteLine("Радиус: ");
            Double.TryParse(Console.ReadLine(), out var R);
            return GetSquare(R);
        }

        public double GetSquare(double R)
        {
            if (R < 0)
            {
                throw new ArgumentException("Радиус не может быть меньше 0");
            }
            return Math.PI * R * R;
        }
    }
}
