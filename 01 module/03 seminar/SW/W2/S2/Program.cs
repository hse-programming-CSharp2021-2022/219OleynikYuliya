using System;

namespace S2
{
    class Program
    {
        public static void F1()
        {
            int a = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Math.Pow(a, 2));
                a++;
            }
            Console.WriteLine();
        }

        public static void F2()
        {
            int b = 1;
            while (b <= 10)
            {
                Console.WriteLine(Math.Pow(b, 2));
                b++;
            }
            Console.WriteLine();
        }

        public static void F3()
        {
            int с = 1;
            do
            {
                Console.WriteLine(Math.Pow(с, 2));
                с++;
            } while (с <= 10);
        }
        static void Main(string[] args)
        {
            F1();
            F2();
            F3();           
            
        }
    }
}
