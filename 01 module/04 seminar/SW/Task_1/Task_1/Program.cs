using System;
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 1;
            do
            {
                b = a;
                a += 1 / (c * (c + 1) * (c + 2));
                c += 1;
            } while (a > b);
            Console.WriteLine(a);
            float d = 0;
            float e = 0;
            float f = 1;
            do
            {
                e = d;
                d += 1 / (f * (f + 1) * (f + 2));
                f += 1;
            } while (d > e);
            Console.WriteLine(d);
        }
    }
}

