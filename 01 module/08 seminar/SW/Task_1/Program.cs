using System;

namespace Task_1
{
    class Program
    {
        public static int Comp(int i, int i1)
        {
            if (i % 2 == 0 && i1 % 2 != 0)
                return 1;
            return -1;
        }

        public static int Sum(int a)
        {
            int sum = 0;
            while (a > 0)
            {
                a /= 10;
                sum += 1;
            }
            return sum;
        }
        public static int Comp1(int i, int i1)
        {
            if (Sum(i) > Sum(i1))
                return 1;
            return -1;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
                a[i] = rnd.Next(0, 10001);
            Array.ForEach(a, el => Console.Write(el + " "));
            Console.WriteLine();
            Array.Sort(a, Comp);
            Array.ForEach(a, el => Console.Write(el + " "));
            Console.WriteLine();
            Array.Sort(a, Comp1);
            Array.ForEach(a, el => Console.Write(el + " "));
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}