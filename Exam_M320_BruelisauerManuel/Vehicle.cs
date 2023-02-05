using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_M320_BruelisauerManuel
{
    internal abstract class Vehicle
    {
        protected Vehicle successor;
        protected ConsoleLogger logger;
        public string name;

        protected ConsoleLogger _consoleLogger; //Komposition

        public Vehicle()
        {
        }
        public Vehicle(Vehicle successor, ConsoleLogger consoleLogger)
        {
            this.successor = successor;
            _consoleLogger = consoleLogger;
        }
        public abstract Vehicle selectVehicle(Journey journey);
    }
}
