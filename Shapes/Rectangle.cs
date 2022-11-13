using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes {
    public class Rectangle {
        private string name;

        private readonly int width = 10;
        private readonly int height = 15;

        private Color color = Color.Black;

        private readonly int thickness = 2;

        public string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }

        //public Color Color{
        //    get{
        //        return this.color;
        //    }
        //    set{
        //        this.color = value;
        //    }
        //}

        //AutoProperty für Color
        public Color Coler { get; set; }

        public int Area {
            get
            {
                return this.width * this.height;
            }
        }
    }
}

