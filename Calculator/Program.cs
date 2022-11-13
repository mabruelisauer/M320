namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Result = 0;
            double TmpResult = 0;

            Console.Write("Geben sie die erste Zahl ein: ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geben sie den Operator [+, -, /, *] ein: ");
            string Operator =  Console.ReadLine();

            Console.Write("Geben sie die zweite Zahl ein: ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());

            if (Operator == "+")
            {
                Result = GetAddition(FirstNumber, SecondNumber);
            }

            if (Operator == "-")
            {
                Result = GetSubtraktion(FirstNumber, SecondNumber);
            }

            if (Operator == "/")
            {
                Result = GetDivision(FirstNumber, SecondNumber);
            }

            if (Operator == "*")
            {
                Result = GetMultiplikation(FirstNumber, SecondNumber);
            }

            static int GetAddition(int FirstNumber, int SecondNumber)
            {
                int result = FirstNumber + SecondNumber;
                return result;
            }

            static int GetSubtraktion(int FirstNumber, int SecondNumber)
            {
                int result = FirstNumber - SecondNumber;
                return result;
            }

            static int GetDivision(int FirstNumber, int SecondNumber)
            {
                int result = FirstNumber / SecondNumber;
                return result;
            }

            static int GetMultiplikation(int FirstNumber, int SecondNumber)
            {
                int result = FirstNumber * SecondNumber;
                return result;
            }

            Console.WriteLine($"Result: {Result}");
            TmpResult = Result;
        }
    }
}