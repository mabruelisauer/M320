namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle myrectangle = new Rectangle(159, 360);
            Rectangle myrectangle2 = new Rectangle(159, 360, 35);
            Rectangle myrectangle3 = new Rectangle(159, 360, "Purple");
            Rectangle myrectangle4 = new Rectangle(159, 360, "Purple", 89);
        }
    }
}