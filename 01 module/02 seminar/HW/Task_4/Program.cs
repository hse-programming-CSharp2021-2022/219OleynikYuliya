using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            bool f1 = int.TryParse(Console.ReadLine(), out a);
            bool f2 = int.TryParse(Console.ReadLine(), out b);
            bool f3 = int.TryParse(Console.ReadLine(), out c);
            if ((f1) && (f2) && (f3) && (a > 99) && (a < 1000) && (b > 99) && (b < 1000) && (c > 99) && (c < 1000))
            {
                int a1 = a % 100;
                int b1 = b % 100;
                int c1 = c % 100;
                if (a1 < b1 && a1 < c1)
                    Console.WriteLine(a);
                if (b1 < a1 && b1 < c1)
                    Console.WriteLine(b);
                if (c1 < a1 && c1 < b1)
                    Console.WriteLine(c);
                if (a1 < c1 && a1 == b1)
                    Console.WriteLine(a + " " + b);
                if (a1 < b1 && a1 == c1)
                    Console.WriteLine(a + " " + c);
                if (b1 < c1 && b1 == c1)
                    Console.WriteLine(b + " " + c);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
