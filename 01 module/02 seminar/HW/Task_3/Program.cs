using System;

namespace ConsoleApp3
{
    class Program
    {
        public static void G(double x, ref double y)
        {
            if (x <= 0.5)
            {
                Console.WriteLine((Math.Sqrt(2)) / 2);
            } else
            {
                Console.WriteLine(Math.Sin((Math.PI*(x - 1))/2));
            }
        }
        static void Main(string[] args)
        {
            double x;
            double y = 0;
            bool f = double.TryParse(Console.ReadLine(), out x);
            if (!f)
            {
                Console.WriteLine("Incorrect input");
            } else
            {
               G(x, ref y);
            }
        }
    }
}