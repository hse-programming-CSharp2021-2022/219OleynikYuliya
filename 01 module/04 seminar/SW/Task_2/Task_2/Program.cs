using System;
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double delta = 0;
            double S = 0;
            bool f1 = double.TryParse(Console.ReadLine(), out A);
            bool f2 = double.TryParse(Console.ReadLine(), out delta);
            double n = A / delta;
            double delta2 = delta;
            double delta3 = 0;
            if (f1 && f2)
            {
                for (int i = 1; i <= n + 1; i++)
                {
                    S += delta2 * (Math.Pow(delta3, 2) + Math.Pow(delta + delta3, 2)) / 2;
                    delta3 += delta2;
                }
                if (A % delta2 != 0)
                {
                    double a = A - n * delta2;
                    S += delta2 * (Math.Pow(A - a, 2) + Math.Pow(A, 2)) / 2;
                }
                Console.WriteLine(S);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
