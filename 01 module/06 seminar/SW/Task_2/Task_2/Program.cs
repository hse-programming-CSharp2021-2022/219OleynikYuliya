using System;
namespace Task_1
{
    class Program
    {
        static void Cout(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        public static void swap(ref int a, ref int b)
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
                a[i] = i+1;
            }
            Cout(a);
            Console.WriteLine();
            for (int i = 0; i < 50; i++)
            {
                Random rnd = new Random();
                int i1 = rnd.Next(0, 100);
                int i2 = rnd.Next(0, 100);
                swap(ref a[i1], ref a[i2]);
            }
            Cout(a);
            Console.WriteLine();
            Array.Resize(ref a, a.Length-1);
            Cout(a);
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