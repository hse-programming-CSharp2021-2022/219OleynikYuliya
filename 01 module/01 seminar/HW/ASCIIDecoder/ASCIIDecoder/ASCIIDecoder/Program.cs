using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите номер искомого символа");
            int.TryParse(Console.ReadLine(), out a);
            char b = (char)a;
            Console.WriteLine("Искомый символ: " + b);
        }
    }
}
