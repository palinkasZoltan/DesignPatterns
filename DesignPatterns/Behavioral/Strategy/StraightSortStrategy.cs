namespace DesignPatterns.Behavioral.Strategy
{
    internal class StraightSortStrategy : IStrategy
    {
        public object ExecuteSort(object data)
        {
            List<string> list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}
