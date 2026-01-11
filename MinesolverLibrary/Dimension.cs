using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesolverLibrary
{
    public struct Dimension
    {
        private int _width;
        private int _height;
        public int Width
        {
            get { return _width; }
            set { if (value < 0) { Console.WriteLine($"Width was an unexpected size {value.ToString()}"); } else { _width = value; } }
        }
        public int Height 
        {
            get { return _height; }
            set { if (value < 0) { Console.WriteLine($"Height was an unexpected size {value.ToString()}"); } else { _height = value; } }
        }
        public Dimension(int inWidth, int inHeight)
        {
            Width = inWidth;
            Height = inHeight;
        }
        public override string ToString()
        {
            return $"{Width}x{Height}";
            
        }
    }
}
