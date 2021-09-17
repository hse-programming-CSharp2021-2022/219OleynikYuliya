using System;

namespace Task_4
{
    class Program
    {
        public static int Recursion(int m, int n)
        {
            if (m == 0)
            {
               return n + 1;
            } else if (m > 0 && n == 0)
                {
                return Recursion(m - 1, 1);
                } else
            {
                return Recursion(m - 1, Recursion(m, n - 1));
            }
        }
        static void Main(string[] args)
        {
            int m;
            int n;
            bool f1 = int.TryParse(Console.ReadLine(), out m);
            bool f2 = int.TryParse(Console.ReadLine(), out n);
            if (f1 && f2)
            {
                Console.WriteLine(Recursion(m, n));
            } else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
