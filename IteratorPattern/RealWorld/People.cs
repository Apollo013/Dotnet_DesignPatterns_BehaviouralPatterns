using IteratorPattern.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern.RealWorld
{
    public class People : IEnumerable, IEnumerator<Person>
    {
        private ArrayList _people = new ArrayList();
        private int position = -1;

        public Person Current
        {
            get
            {
                try
                {
                    return _people[position] as Person;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public Person this[int idx]
        {
            get { return _people[idx] as Person; }
            set { _people.Insert(idx, value); }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _people.GetEnumerator();
        }

        public bool MoveNext()
        {
            position++;
            return position < _people.Count;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            _people.Clear();
            _people = null;
        }
    }
}
