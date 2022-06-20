namespace Task1
{
    public sealed class OperationAdd : IStrategy
    {
        public int DoOperation(int a, int b)
        {
            return a + b;
        }
    }
}
