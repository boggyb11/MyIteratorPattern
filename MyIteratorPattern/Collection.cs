using System.Collections;

namespace MyIteratorPattern
{
    public class Collection : ICollection
    {
        private ArrayList _horses = new ArrayList();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count => _horses.Count;

        public object this[int index]
        {
            get { return _horses[index]; }
            set { _horses.Add(value); }
        }
    }
}