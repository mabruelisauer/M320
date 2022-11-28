using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Rectangle
    {
        private int Height;
        private int Width;
        private string Color;
        private int Transparency;

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public Rectangle(int height, int width, string color) : this(height, width)
        {
            Color = color;
        }
        public Rectangle(int height, int width, int transparency) : this(height, width)
        {
            Transparency = transparency;
        }
        public Rectangle(int height, int width, string color, int transparency) : this(height, width, color)
        {
            Transparency = transparency;
        }

        
    }
}
