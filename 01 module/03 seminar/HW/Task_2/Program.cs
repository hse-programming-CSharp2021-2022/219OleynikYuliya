using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double g;
            bool f1 = double.TryParse(Console.ReadLine(), out x);
            bool f2 = double.TryParse(Console.ReadLine(), out y);
            if (f1 && f2)
            {
                if (x < y && x > 0)
                {
                    g = x + Math.Sin(y);
                } else if (x > y && x < 0)
                    {
                    g = y - Math.Cos(x);
                }
                else
                {
                    g = 0.5 * x * y;
                }
            } else
            {
                Console.WriteLine("Incorrect input");
            }
            Console.WriteLine(g);
        }
    }
}
