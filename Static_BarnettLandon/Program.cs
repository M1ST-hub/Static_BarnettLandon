namespace Static_BarnettLandon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Integers
            Console.WriteLine("Integer Methods");
            Console.WriteLine(Calculate.Add(4, 59));
            Console.WriteLine(Calculate.Sub(81, 21));
            Console.WriteLine(Calculate.Mult(18, 2));
            Console.WriteLine(Calculate.Div(2, 2));

            //Floats
            Console.WriteLine("\nFloat Methods");
            Console.WriteLine(Calculate.Add(4.7f, 59.7f));
            Console.WriteLine(Calculate.Sub(81.7f, 21.7f));
            Console.WriteLine(Calculate.Mult(18.7f, 2.7f));
            Console.WriteLine(Calculate.Div(2.7f, 2.7f));

        }
    }
}