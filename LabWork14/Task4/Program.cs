using System;

namespace Task4
{
    internal sealed class Program
    {
        private static void Main()
        {
            Product product = new Product() { Name = "product", Price = 127.9556, ExpirationDate = DateTime.Now };
            Console.WriteLine(product);
        }
    }
}
