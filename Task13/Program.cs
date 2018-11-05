using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
