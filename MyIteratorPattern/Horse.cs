using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyIteratorPattern
{

    public class Horse
    {
        private string _name;

        public Horse(string name)
        {
            _name = name;
        }

        public string Name { get => _name; }
    }
}
