namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = 10;
            Rectangle rectangle1 = new Rectangle();
            rectangle1.Name = "rect1";
            Rectangle rectangle2 = new Rectangle();
            rectangle2.Name = "rect2";

            Console.WriteLine($"Rectangle1 Name={rectangle1.Name}, Area={rectangle1.Area}");
            Console.WriteLine($"Rectangle2 Name={rectangle2.Name}, Area={rectangle2.Area}");
        }
    }
}