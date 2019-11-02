using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPatternPrototype.Prototype
{
    public abstract class Cell
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public abstract Cell Clone();
    }
}
