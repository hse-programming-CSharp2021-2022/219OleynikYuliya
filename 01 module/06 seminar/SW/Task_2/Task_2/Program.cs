using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] a = new int[N + 1];
            for (int i = 0; i < N; i++)
            {
                Random b = new Random();
                a[i] = b.Next(-10, 11);
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(a[i] + " ");
            }
            for (int i = 0; i < N; i++)
            {
                if (a[i] % 2 == 0)
                {
                    a[i] = 0;
                }
            }
            for (int i = 0; i < N; i++)
            {
                if (a[i] == 0)
                {
                    a[i] = a[i + 1];
                    a[i + 1] = 0;
                }
            }
            int N1 = 0;
            for (int i = 0; i < N; i++)
            {
                if (a[i] == 0)
                {
                    N1 += 1;
                }
            }
            int N2 = N - N1;
            Console.WriteLine();
            for (int i = 0; i < N2; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}