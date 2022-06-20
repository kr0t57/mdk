using System;

namespace Task1
{
    internal sealed class Program
    {
        private static void Main()
        {
            var context = new Context(new OperationAdd());
            Console.WriteLine(context.ExecuteStrategy(5, 5));

            context = new Context(new OperationSubstract());
            Console.WriteLine(context.ExecuteStrategy(5, 5));

            context = new Context(new OperationMultiply());
            Console.WriteLine(context.ExecuteStrategy(5, 5));
        }
    }
}
