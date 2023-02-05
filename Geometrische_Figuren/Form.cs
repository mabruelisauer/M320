using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrische_Figuren
{
    internal class Form
    {
        public const float DefaultX = 100;
        public const float DefaultY = 100;
        public float xPosition { get; set; } //= DefaultX;
        public float yPosition { get; set; }// = DefaultY;

        public void PrintPosition (float x, float y)
        {

        }
        public class test : Form
        {
        public float xPosition { get; set; }
            
        }
    }
}
