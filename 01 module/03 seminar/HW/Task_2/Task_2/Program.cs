using System;

namespace Task_2
{
    class Program
    {
        public static int MaxNum(int p)
        {
            int p1 = p % 10;
            int p2 = p % 100 / 10;
            int p3 = p / 100;
                if (p1 > p2 && p1 > p2)
                {
                    if (p2 > p3)
                        return (100 * p1 + 10 * p2 + p3);
                    if (p3 > p2)
                        return (100 * p1 + 10 * p3 + p2);
                }
                if (p2 > p1 && p2 > p3)
                {
                    if (p1 > p3)
                        return (100 * p2 + 10 * p1 + p3);
                    if (p3 > p1)
                        return (100 * p2 + 10 * p3 + p1);
                }
                if (p3 > p1 && p3 > p2)
                {
                    if (p1 > p2)
                        return (100 * p3 + 10 * p1 + p2);
                    if (p2 > p1)
                        return (100 * p3 + 10 * p2 + p1);
                }
            return p;
        }
        static void Main(string[] args)
        {
            int p;
            bool f = int.TryParse(Console.ReadLine(), out p);
            if ((f) && (p > 100) && (p < 1000))
            {
                Console.WriteLine(MaxNum(p));
            } else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
