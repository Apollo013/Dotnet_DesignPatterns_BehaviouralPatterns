using IteratorPattern.Aggregates;
using IteratorPattern.Models;

namespace IteratorPattern.Iterators
{
    public class Iterator : IIterator<Person>
    {
        private Collection _collection;
        private int _current = 0;

        public Person CurrentItem { get { return _collection[_current] as Person; } }

        public bool IsDone { get { return _current >= _collection.Count; } }

        public Iterator(Collection collection)
        {
            _collection = collection;
        }

        public Person First()
        {
            _current = 0;
            return _collection[_current] as Person;
        }

        public Person Next()
        {
            _current++;

            if (!IsDone)
            {
                return _collection[_current] as Person;
            }
            return null;
        }
    }
}
