using System.Collections;

namespace DesignPatterns.Behavioral.Iterator
{
    abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
