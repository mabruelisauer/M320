using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrische_Figuren
{
    internal class Rechteck : Form
    {
        public int laenge { get; set; }
        public int breite { get; set; }
        //public Rechteck(int laenge, int breite) : this(laenge, breite, DefaultY, DefaultX)
        //{
           
        //}
        public Rechteck(int laenge, int breite, float yPosition = DefaultY, float xPosition = DefaultX)
        {
            this.laenge = laenge;
            this.breite = breite;
            this.yPosition = yPosition;
            this.xPosition = xPosition;
        }

    }
}
