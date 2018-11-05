using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            string astring = Console.ReadLine();
            double a = double.Parse(astring);

            Console.Write("b: ");
            string bstring = Console.ReadLine();
            double b = double.Parse(bstring);

            double c = a + b;
            Console.WriteLine("c: {0:f6}", c);

        }
    }
}
