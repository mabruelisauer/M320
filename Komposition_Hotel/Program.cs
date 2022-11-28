namespace Komposition_Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hotel = new Hotel();
            var rezeption = new Rezeption();

            
        }

        public class Hotel
        {
            // Multiplizität von genau 1 oder 0..1e$
            public Rezeption rezeption;

            //Multiplizität > 1
            private List<Sitzungszimmer> sitzungszimmerList = new List<Sitzungszimmer>();
            private List<Zimmer> zimmerList = new List<Zimmer>();

            public Hotel()
            {
                this.rezeption = new Rezeption();
            }

            public void Addsitzungszimmer(string nummer, int anzplaetze)
            {
                if (this.sitzungszimmerList.Count >= 3)
                {
                    Console.WriteLine("Zu viele Sitzungszimmer");
                    return;
                }
                var stizungszimmer = new Sitzungszimmer { Nummer = nummer, Anzplaetze = anzplaetze };
            }

            public void AddZimmer(string nummer, int anzplaetze)
            {
                if (this.zimmerList.Count >= 3)
                {
                    Console.WriteLine("Zu viele Zimmer");
                    return;
                }
                var zimmer = new Zimmer { Nummer = nummer };
            }

        }

        public class Rezeption
        {
            
        }

        public class Zimmer
        {
            public string Nummer { get; set; }
        }

        public class Sitzungszimmer
        {
            public string Nummer { get; set; }
            public int Anzplaetze { get; set; }
        }

        public class Bett
        {

        }

        public class Beamer
        {

        }
    }
}