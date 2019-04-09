using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyIteratorPattern
{
    interface IIterator
    {
        Horse First();
        Horse Next();
        bool IsRidden();
        Horse CurrentlyBeingRidden();
    }
}
