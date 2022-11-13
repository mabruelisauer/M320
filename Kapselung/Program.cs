namespace Kapselung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herzlich willkommen zur heutigen Wuttherapie!");
            Person person = new Person(3);
            person.PrintWohlbefinden();
            person.GetProzentAnWut();
            person.PrintTipps();
        }
    }

}