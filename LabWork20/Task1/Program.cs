using System;

namespace Task1
{
    internal sealed class Program
    {
        private delegate int MyFunc(int value);
        
        private static void Main()
        {
            //Task1
            Console.WriteLine("Task1");
            var squarePow = new MyFunc((int value) => value * value);
            var abs = new MyFunc((int value) => Math.Abs(value));
            var factorial = new MyFunc((int value) =>
            {
                int result = 1;

                for (int i = 1; i <= value; i++)
                {
                    result *= i;
                }

                return result;
            });

            Console.WriteLine(squarePow.Invoke(5));
            Console.WriteLine(abs.Invoke(-5));
            Console.WriteLine(factorial.Invoke(5));

            //Task4
            Console.WriteLine("\nTask4");
            var myFuncs = new MyFunc[] 
            {
                squarePow,
                abs,
                factorial
            };

            foreach (var func in myFuncs)
            {
                Console.WriteLine(func?.Invoke(5));
            }

            //Task5
            Console.WriteLine("\nTask5");
            foreach (var func in myFuncs)
            {
                ExecuteMyFunc(func, 5);
            }
        }

        private static void ExecuteMyFunc(MyFunc myFunc, int value)
        {
            Console.WriteLine(myFunc?.Invoke(value));
        }
    }
}
