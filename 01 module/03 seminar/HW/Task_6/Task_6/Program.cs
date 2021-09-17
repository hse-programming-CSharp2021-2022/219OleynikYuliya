using System;

namespace Task_6
{
    class Program
    {
        public static void dollary(decimal a, int b)
        {
            decimal c = a * b / 100;
            Console.WriteLine("{0:C2}", c);
        }
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            dollary(a, b);
        }
    }
}
