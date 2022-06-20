using System;

namespace Task2
{
    public sealed class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine($"Inside {GetType().Name}");
        }
    }
}
