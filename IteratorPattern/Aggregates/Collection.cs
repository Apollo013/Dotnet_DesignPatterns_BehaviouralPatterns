using IteratorPattern.Iterators;
using IteratorPattern.Models;
using System.Collections;

namespace IteratorPattern.Aggregates
{
    public class Collection : ICollection<Person>
    {
        private ArrayList _items = new ArrayList();

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int idx]
        {
            get { return _items[idx]; }
            set { _items.Insert(idx, value); }
        }

        public IIterator<Person> CreateIterator()
        {
            return new Iterator(this);
        }
    }
}
