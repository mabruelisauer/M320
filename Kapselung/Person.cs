using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapselung
{
    internal class Person
    {
        private int Wohlbefinden;
        private int ProzentAnWut;

        public Person(int wohlbefinden)
        {
            Wohlbefinden = wohlbefinden;
        }

        public void PrintWohlbefinden()
        {
            Console.WriteLine($"Sie haben für Ihr Wohlbefinden {Wohlbefinden} von 10 gewählt.");
            if (Wohlbefinden>=7)
            {
                Console.WriteLine("Ihnen scheint es doch nicht so schlecht zu gehen Sie haben die Wuttherapie nicht nötig.");
            }
        }
        public void GetProzentAnWut()
        {
            if (Wohlbefinden<7)
            {
                Console.WriteLine("Geben Sie doch die ungefähre Prozentzahl an Wut an, die Sie gerade verspüren.");
                string input = Console.ReadLine();
                while (!Int32.TryParse(input, out int n) || Convert.ToInt32(input) < 0 || Convert.ToInt32(input) > 100)
                {
                    Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 100 ein!");
                    input = Console.ReadLine();
                }
                ProzentAnWut = Convert.ToInt32(input);
            }
        }
        public void PrintTipps()
        {
            if (ProzentAnWut<=20)
            {
                Console.WriteLine("Sie haben ganz andere Probleme als Wut im Leben!");
            }
            else if (ProzentAnWut <= 40)
            {
                Console.WriteLine("Erstmal sollen Sie tief durchatmen und überlegen ob es sich wirklich lohnt wütend zu sein. Oftmals ist der Grund für eine solche Wut ein eher unbedeutendes Ereignis.");
            }
            else if (ProzentAnWut <= 60)
            {
                Console.WriteLine("Versuchen Sie ihre Gedanken zu stoppen und am besten einen Stressball zu kneten.");
            }
            else if (ProzentAnWut <= 80)
            {
                Console.WriteLine("Schließen Sie die Augen, atmen Sie tief ein und zählen Sie in Gedanken langsam bis zehn. Gerne können Sie auch ein Wort oder einen Satz wiederholen wie: „Das macht mir nichts aus“ oder „Das ist nur ein Gefühl“.");
            }
            else if (ProzentAnWut <= 100)
            {
                Console.WriteLine("Vielleicht sollten Sie erstmal das Messer in Ihrer Hand weglegen.");
            }
        }
    }
}
