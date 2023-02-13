namespace SmartHomeSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wohnung = new Wohnung();
            Wettersensor wettersensor = new Wettersensor(wohnung);

            for (int i = 0; i < 60; i++)
            {
                float Temperature = wettersensor.PrintTemperature();
                Console.WriteLine("Temperature: " + Temperature.ToString("F2"));

                System.Threading.Thread.Sleep(1000);
            }

            Console.ReadLine();
        }
    }
}