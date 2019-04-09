using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyIteratorPattern
{
    // the aggregate interface
    interface ICollection
    {
        Iterator CreateIterator();
    }
}
