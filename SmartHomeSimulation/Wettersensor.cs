using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSimulation
{
    internal class Wettersensor
    {
        public Wohnung Wohnung { get; set; }
        private Random random = new Random();
        float temperature = 20;

        public Wettersensor(Wohnung wohnung)
        {
            Wohnung = wohnung;
        }

        public float PrintTemperature()
        {
            temperature += (float)(random.NextDouble() * 5 - 2.5);
            return temperature;
        }
    }
}
