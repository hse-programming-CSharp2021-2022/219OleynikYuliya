using System;

namespace Task_6
{
    class Program
    {
        private static int Factorial(int a)
        {
            int result = 1;
            int i = 1;
            if (a == 0)
            {
                return 1;
            }
            else
            {
                while (i <= a)
                {
                    result *= i;
                    i += 1;
                }
            }
            return result;
        }
        static double S(double x)
        {
            int b = 3;
            int c = 4;
            int d = 4;
            double s = (1 - x * x + (Math.Pow(2, b) * Math.Pow(x, 4)) / Factorial(d));
            do
            {
                b += 2;
                c += 2;
                d += 2;
                s += ((Math.Pow(2, b) * Math.Pow(x, 4)) / Factorial(d));
            }
            while (s <= (s + ((Math.Pow(2, b) * Math.Pow(x, 4)) / Factorial(d))));
            return s;
        }
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(S(x));
        }
    }
}
