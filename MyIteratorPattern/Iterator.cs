using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyIteratorPattern
{
    public class Iterator : IIterator
    {
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;

        public Iterator(Collection collection)
        {
            _collection = collection;
        }

        public Horse CurrentlyBeingRidden() => _collection[_current] as Horse; 

        public Horse First()
        {
            _current = 0;
            return _collection[_current] as Horse;
        }

        public bool IsRidden() => _current >= _collection.Count;

        public Horse Next()
        {
            _current += _step;
            if (!IsRidden())
                return _collection[_current] as Horse;
            else

                return null;
        }

        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }
    }
}
