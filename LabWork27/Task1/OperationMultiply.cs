namespace Task1
{
    public sealed class OperationMultiply : IStrategy
    {
        public int DoOperation(int a, int b)
        {
            return a * b;
        }
    }
}
