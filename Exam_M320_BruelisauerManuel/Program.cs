using Exam_M320_BruelisauerManuel;

namespace Exam.M320
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Zug = new Train();
            var Auto = new Car();
            var Fahrrad = new Bicycle();

            var SanktGallen = new Destination();
            var Genf = new Destination();
            var Barcelona = new Destination();

            var j1 = new Journey(SanktGallen, "St. Gallen", 20);
            var j2 = new Journey(Genf, "Genf", 360);
            var j3 = new Journey(Barcelona, "Barcelona", 784);
        }
    }
}