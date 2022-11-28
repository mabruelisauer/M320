using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
    public class Rechteck : Figure, IRotatable {
        public void Rotate() {
            Console.WriteLine("Reckteck wird rotiert.");
        }
    }
}
