using System;

namespace Task_7
{
    class Program
    {
        public static void First(double a)
        {
            Console.WriteLine((int)a);
            Console.WriteLine(a - (int)a);
        }
        public static void Second(double a)
        {
            Console.WriteLine(a * a);
            if (a >= 0)
                Console.WriteLine(Math.Sqrt(a));
            else
                Console.WriteLine("Incorrect input"); 
        }

        static void Main(string[] args)
        {
            double a;
            bool f = double.TryParse(Console.ReadLine(), out a);
            if (f)
            {
                First(a);
                Second(a);
            }
            else
                Console.WriteLine("Incorrect input");
            
        }
    }
}
