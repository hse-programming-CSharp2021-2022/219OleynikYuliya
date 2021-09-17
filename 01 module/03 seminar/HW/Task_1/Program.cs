using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            Console.WriteLine("Введите значение x: ");
            bool f1 = double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Введите значение y: ");
            bool f2 = double.TryParse(Console.ReadLine(), out y);
            if (f1 && f2)
            {
                if ((x >= 0) && (x <= 2) && ((-2) <= y) && (y <= Math.Sqrt(2)))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            } else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
