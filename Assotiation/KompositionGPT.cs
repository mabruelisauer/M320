using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompositionGPT
{
    internal class KompositionGPT
    {
        public class Engine
        {
            // Eigenschaften und Methoden der Engine-Klasse
            public void Start()
            {

            }
        }

        public class Car
        {
            private readonly Engine _engine;

            public Car(Engine engine)
            {
                _engine = engine;
            }

            public void Start()
            {
                _engine.Start();
            }

            // Weitere Eigenschaften und Methoden der Car-Klasse
        }

    }
}
