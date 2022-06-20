namespace Task1
{
    public sealed class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int ExecuteStrategy(int a, int b)
        {
            return _strategy.DoOperation(a, b);
        }
    }
}
