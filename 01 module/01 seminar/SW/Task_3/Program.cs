using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int aa, bb;
            int.TryParse(Console.ReadLine(), out aa);
            int.TryParse(Console.ReadLine(), out bb);
            Console.WriteLine(aa + bb);
            Console.WriteLine(aa - bb);
            Console.WriteLine(aa * bb);
            Console.WriteLine(aa / bb);
            Console.WriteLine(aa % bb);
            Console.WriteLine(aa >> bb);
            Console.WriteLine(aa << bb);
        }
    }
}
