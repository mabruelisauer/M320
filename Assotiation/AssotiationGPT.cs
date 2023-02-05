using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assotiation
{
    internal class AssotiationGPT
    {
        public class Customer
        {
            public int Id { get; set; }
        }

        public class Order
        {
            public Customer Customer { get; set; }

            // Eigenschaften und Methoden der Order-Klasse
        }
    }
}
