using System;

namespace Task_1
{
    class Program
    {
        public static int Pov(int x)
        {
           return (x * (2 + x * ((-3) + x * (9 + x * 12))) - 4);
        }
        static void Main(string[] args)
        {
            int x;
            bool f = int.TryParse(Console.ReadLine(), out x);
            if (f)
                Console.WriteLine(Pov(x));
            else
                Console.WriteLine("Incorrect input");
        }
    }
}

