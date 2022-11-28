namespace Assotiation
{
    internal class Assotiation
    {
        static void Main(string[] args)
        {
            var star = new Star();
            var fan = new Fan();
            fan.Star = star;
        }
    }

    public class Star
    {
        public List<Fan> Fans { get; set; }
    }

    public class Fan
    {
        public Star Star { get; set; }
    }
}