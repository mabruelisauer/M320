using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exam_M320_BruelisauerManuel
{
    internal class Journey
    {
        private int id;
        private int lastId;
        public Destination destinations; //1..*
        //public destination.name finalDestination;
        public readonly int distance;

        //Aggregation
        private Destination _destination;
        public Journey(Destination destination, string name, int distance)
        {
            _destination = destination;
            _destination.distance = distance;
            _destination.name = name;
            id++;
            lastId= id;
        }
    }
}
