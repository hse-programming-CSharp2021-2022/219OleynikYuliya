using System;

namespace Task_5
{
    class Program
    {
        public static void Triangle(double a, double b, double c)
        {
            bool f = ((a + b > c) && (a + c > b) && (b + c > a));
            Console.WriteLine(f);
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Triangle(a, b, c);
        }
    }
}
