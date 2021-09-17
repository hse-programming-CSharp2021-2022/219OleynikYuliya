using System;

namespace Task_4
{
    class Program
    {
        public static void Pevertysh(int a)
        {
            Console.WriteLine(a % 10 * 1000 + a % 100 / 10 * 100 + a % 1000 / 100 * 10 + a / 1000);
        }
        static void Main(string[] args)
        {
            int a;
            bool f = int.TryParse(Console.ReadLine(), out a);
            if ((f) && (a > 999) && (a < 10000))
            {
                Pevertysh(a);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
