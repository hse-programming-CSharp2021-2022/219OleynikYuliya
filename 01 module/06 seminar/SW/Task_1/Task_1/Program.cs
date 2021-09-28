using System;

namespace Task_1
{
    class Program
    {
        static void Cout(char[] a)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write(a[i]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            char[] a = new char[k];
            char[] copy = new char[k];
            for (int i = 0; i < a.Length; i++)
            {
                Random rnd = new Random();
                a[i] = (char)rnd.Next('A', 'Z' + 1);
            }
            Cout(a);
            Array.Copy(a, copy, k);
            Array.Sort(a);
            Cout(a);
            Array.Reverse(a);
            Cout(a);
        }
    }
}
