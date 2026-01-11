using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesolverLibrary
{
    struct Point
    {
        private int _x;
        private int _y;
        public int X
        {
            get { return _x; }
            set { if (value < 0) { _x = 0; } else { _x = value; } }
        }
        public int Y
        {
            get { return _y; }
            set { if (value < 0) { _y = 0; } else { _y = value; } }
        }
    }
}
