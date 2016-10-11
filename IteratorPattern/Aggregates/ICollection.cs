using IteratorPattern.Iterators;

namespace IteratorPattern.Aggregates
{
    public interface ICollection<T>
    {
        IIterator<T> CreateIterator();
    }
}
