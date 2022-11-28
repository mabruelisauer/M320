namespace Figures {
    internal class Program {
        static void Main(string[] args) {
            IRotatable dreieck = new Dreieck();
            IRotatable rechteck = new Rechteck();
            IRotatable dreieck2 = new Dreieck();

            var list = new List<IRotatable>();  
            list.Add(rechteck);
            list.Add(dreieck2);
            list.Add(dreieck);

            foreach(IRotatable item in list) { 
                item.Rotate();
            }


            //IRotatable kreis = new Kreis();

        }
    }
}