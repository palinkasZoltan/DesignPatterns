namespace DesignPatterns.Behavioral.Strategy
{
    internal class ReverseSortStrategy : IStrategy
    {
        public object ExecuteSort(object data)
        {
            List<string> list = data as List<string>;
            list?.Sort();
            list?.Reverse();

            return list;
        }
    }
}
