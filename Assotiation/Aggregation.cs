namespace Aggregation
{
    internal class Komposition
    {
        static void Main(string[] args)
        {
            var bankKunde = new BankKunde();

            new Konto(bankKunde);
        }

        public class BankKunde
        {
            private List<Konto> kontoList = new List<Konto>();

            public BankKunde ()
            {
                new Konto(this);
            }

            public void AddKonto(Konto konto)
            {
                if (kontoList.Count < 5)
                {
                    this.kontoList.Add(konto);
                }
                else
                {
                    Console.WriteLine("Max Anzahl Konti erreicht");
                }
            }
        }

        public class Konto
        {
            public Konto(BankKunde kunde)
            {
                kunde.AddKonto(this);
            }
        }
    }
}