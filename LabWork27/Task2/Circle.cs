using System;

namespace Task2
{
    public sealed class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine($"Inside {GetType().Name}");
        }
    }
}
