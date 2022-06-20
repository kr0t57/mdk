using System;

namespace Task4
{
    public class Ring : Figure
    {
        public override double GetSquare()
        {
            Console.WriteLine("Введите R: ");
            Double.TryParse(Console.ReadLine(), out var R);
            Console.WriteLine("Введите r:");
            Double.TryParse(Console.ReadLine(), out var r);
            return GetCircleSquare(R) - GetCircleSquare(r);
        }

        public double GetCircleSquare(double R)
        {
            if (R < 0)
            {
                throw new ArgumentException("Радиус не может быть меньше 0");
            }
            return Math.PI * R * R;
        }
    }
}
