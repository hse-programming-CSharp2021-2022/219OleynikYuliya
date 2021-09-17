using System;

namespace Task_3
{
    class Program
    {
        public static void Recurs(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine(a);
            }
            else if (b > 0)
            {
                b /= 10;
                a++;
                Recurs(a, b);
            }
        }
        static void Main(string[] args)
        {
            int b;
            bool f = int.TryParse(Console.ReadLine(), out b);
            Recurs(0, b);
        }
    }
}

