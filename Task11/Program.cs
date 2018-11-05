using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal aDec = 169;
            char a = (char)aDec;
            Console.WriteLine("{0,5}",a);
            Console.WriteLine("{0,4}{0,2}", a);
            Console.WriteLine("{0,3}{0,4}", a);
            Console.WriteLine("{0,2}{0,6}", a);
            Console.WriteLine("{0}{0,2}{0,2}{0,2}{0,2}", a);
        }
    }
}
