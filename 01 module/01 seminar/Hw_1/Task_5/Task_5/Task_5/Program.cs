using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение первого катета: ");
            double a;
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите значение второго катета: ");
            double b;
            double.TryParse(Console.ReadLine(), out b);
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Значение гипотенузы: " + c);
        }
    }
}
