namespace Vererbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Person person1 = new Person() { Vorname = "Hans", Name = "Meier" };
            Kunde kunde1 = new Kunde() { Vorname = "Fritz", Name = "Mueller", Umsatz = 1000.0 };
            Lagerist lagerist1 = new Lagerist() { Vorname = "Joe", Name = "Manser", Groesse = 180 };
            Kind kind1 = new Kind() { Vorname = "Boby", Name = "Cap"};
            //kunde1.Esse();
            //kunde1.Kaufe();
            //lagerist1.Esse();
            //lagerist1.LagereEin();

            List<Person> KoennenTragen = new List<Person>();
            KoennenTragen.Add(kunde1);
            KoennenTragen.Add(lagerist1);
            KoennenTragen.Add(kind1);

            foreach (Person item in KoennenTragen)
            {
                item.Trage();
            }
        }
    }
    public abstract class Person
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public void Esse()
        {
            System.Console.WriteLine("Ich als Person {0} {1} esse mit Messer und Gabel", Vorname, Name);
        }

        public abstract void Trage();
    }
    public class Kunde : Person
    {
        public double Umsatz { get; set; }
        public void Kaufe()
        {
            Console.WriteLine("Ich als Kunde {0} {1} kaufe bei Lidl", Vorname, Name);
        }

        public override void Trage()
        {
            Console.WriteLine("Ich als Kunde tragen den Einkauf nach hause.");
        }
    }
    public class Lagerist : Person
    {
        public int Groesse { get; set; }
        public void LagereEin()
        {
            Console.WriteLine("Ich als Lagerist {0} {1} lagere ein", Vorname, Name);
        }

        public override void Trage()
        {
            Console.WriteLine("Ich als Lagerist trage Waren im Lager herum.");
        }
    }

    public class Kind : Person
    {
        public override void Trage()
        {
            Console.WriteLine("Kinder werden getragen.");
        }
    }
}