using System;

namespace Task1
{
    internal sealed class Rectangle : Figure
    {
        private double _a;
        private double _b;

        internal Rectangle() : this(5, 8)
        {

        }

        internal Rectangle(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public override string Name => nameof(Rectangle);

        public override void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}\nСторона a: {_a}\nСторона b: {_b}\nПлощадь: {GetSquare()}\nПериметр: {GetPerimetr()}");
        }

        public override double GetSquare()
        {
            return _a * _b;
        }

        public override double GetPerimetr()
        {
            return 2 * (_a + _b);
        }
    }
}
