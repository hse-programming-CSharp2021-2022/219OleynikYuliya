using System;

namespace Task_3
{
    class Program
    {
        public static void Y2(double a, double b, double c)
        {
            double d;
            double x1;
            double x2;
            double d1;
            d1 = b * b - 4 * a * c;
            d = Math.Sqrt(b * b - 4 * a * c);
            x1 = ((-b) + d) / (2 * a);
            x2 = ((-b) - d) / (2 * a);
           switch (d1)
            {
                case > 0:
                    Console.WriteLine($"{x1}, {x2}");
                    break;
                case 0:
                    Console.WriteLine(x1);
                    break;
                case < 0:
                    Console.WriteLine("Корней нет");
                    break;
            }
        }
        static void Main(string[] args)
        { 
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            switch (a)
            {
                case 0:
                    Console.WriteLine(-c / b);
                    break;
                default:
                    Y2(a, b, c);
                    break;

            }
        }
    }
}