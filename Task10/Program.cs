using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal aDec = 111;
            char a = (char)aDec;
            Console.WriteLine("{0,2}{0}{0,2}{0}", a);
            Console.WriteLine("{0}{0,3}{0,3}", a);
            Console.WriteLine("{0,2}{0,4}", a);
            Console.WriteLine("{0,3}{0,2}", a);
            Console.WriteLine("{0,4}", a);

        }
    }
}
