using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double delta = 0;
            double S=0;
            bool f1 = double.TryParse(Console.ReadLine(), out A);
            bool f2 = double.TryParse(Console.ReadLine(), out delta);
            double n = A / delta;
            if (f1 && f2)
            {
                for (int i = 1; i <= n+1; i++)
                {
                    S += delta * (Math.Pow(delta, 2) + Math.Pow(delta + delta, 2)) / 2;
                    delta += delta;
                }
                if (A % delta != 0)
                {
                    double a = A - n * delta;
                    S += a * (Math.Pow(A - a, 2) + Math.Pow(A, 2)) / 2;
                }
                Console.WriteLine(S);
            } else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
