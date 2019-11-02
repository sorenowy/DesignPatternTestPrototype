using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPatternPrototype.Prototype
{
    class WhiteCell : Cell
    {
        public WhiteCell()
        {
            this.Name = "WhiteCell";
            this.Type = "Leucocytes";
        }
        public override Cell Clone()
        {
            return this.MemberwiseClone() as Cell;
        }
    }
}
