namespace Assotiation1
{
    internal class Assotiation1
    {
        static void Main(string[] args)
        {
            var fido = new Hund();
            var laus1 = new Laus(fido);
            var laus2 = new Laus(fido);
            var laus3 = new Laus(fido);

            //fido.Parasiten.Add(laus1);
            //fido.Parasiten.Add(laus2);
            //fido.Parasiten.Add(laus3);
        }
    }

    //0-n beziehung

    public class Hund
        
    {
        public List<Laus> Parasiten { get; set; } = new List<Laus>();
    }

    public class Laus
    {
        //Miltiplizitäten mit genau oder mindestens 1 werden via Kunstruktoren erzwungen.
        public Laus(Hund wirt)
        {
            this.Wirt = wirt;
            this.Wirt.Parasiten.Add(this);
        }

        public Hund Wirt { get; }
    }
}