using System;

namespace Task1
{
    internal sealed class EquilateralTriangle : IFigure, IPrinter
    {
        private double _side;

        internal EquilateralTriangle() : this(10)
        {

        }

        internal EquilateralTriangle(double side)
        {
            _side = side;
        }

        public string Name => nameof(EquilateralTriangle);

        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}\nСторона: {_side}\nПлощадь: {GetSquare()}\nПериметр: {GetPerimetr()}");
        }

        public double GetPerimetr()
        {
            return (3 * _side) / 2;
        }

        public double GetSquare()
        {
            double perimetr = GetPerimetr();
            return Math.Sqrt(perimetr * (perimetr - _side) * (perimetr - _side) * (perimetr - _side));
        }

        public void Print()
        {
            DisplayInfo();
        }
    }
}
