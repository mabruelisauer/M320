namespace Aggregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var festplatte = new Festplatte();
            var mcBook = new Notebook(festplatte);
            var elitebook = new Notebook(festplatte);
        }

        public class Notebook
        {
            public Festplatte Festplatte { get; set; }

            public Notebook (Festplatte festplatte)
            {
                if (festplatte.IstEingebaut)
                {
                    Console.WriteLine("Festplatte ist bereits eingebaut");
                }
                else
                {
                    this.Festplatte = festplatte;
                    this.Festplatte.IstEingebaut = true;
                }
                
            }

            public void TauscheFestplatte(Festplatte neueFestplatte)
            {
                if (neueFestplatte.IstEingebaut)
                {
                    Console.WriteLine("Neue Festplatte bereits in einem Notebook eingebaut");
                    return;
                }
                var alteFestplatte = this.Festplatte;
                alteFestplatte.IstEingebaut = false;

                this.Festplatte = neueFestplatte;
                this.Festplatte.IstEingebaut = true;
            }
        }

        public class Festplatte
        {
            public bool IstEingebaut { get; set; }
        }
    }
}