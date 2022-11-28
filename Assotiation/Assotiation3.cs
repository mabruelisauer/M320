namespace Assotiation
{
    internal class Assotiation3
    {
        static void Main(string[] args)
        {
            var kunde = new Kunde();
            var meier = new Kunde();

            var cSharp = new Buch();
            var uml = new Buch();
            var krimi = new Buch();

            kunde.Leiht(cSharp);
            kunde.Leiht(uml);

            meier.Leiht(uml);
            meier.Leiht(krimi);
        }

        public class Kunde
        {
            private List<Buch> Buecher { get; set; } = new List<Buch>();

            public void Leiht(Buch buch)
            {
                if (buch.IstAusgeliehen)
                {
                    Console.WriteLine("Buch ist bereits ausgeliehen!");
                }
                else
                {
                    this.Buecher.Add(buch);
                    buch.IstAusgeliehen = true;
                }
            }
        }

        public class Buch
        {
            public bool IstAusgeliehen { get; set; }
        }
    }
}