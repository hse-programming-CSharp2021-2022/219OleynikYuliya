using System;
namespace Task_2
{
    class Program
    {
        static void Print(int[] a)
        {
            foreach (var i in a)
                Console.WriteLine(i + " ");
            Console.WriteLine();
        }

        public static void Swap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }

        static void Main(string[] args)
        {
            int[] a = new int[100];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i + 1;
            }
            Print(a);
            Console.WriteLine();
            for (int i = 0; i < 50; i++)
            {
                Random rnd = new Random();
                int i1 = rnd.Next(0, 100);
                int i2 = rnd.Next(0, 100);
                Swap(ref a[i1], ref a[i2]);
            }
            Print(a);
            Console.WriteLine();
            Array.Resize(ref a, a.Length - 1);
            Print(a);
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine(5050 - sum);
        }
    }
}