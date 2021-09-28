using System;

namespace Task_1
{
    class Program
    {
        public static void Sums(uint number, out uint sumEven, out uint sumOdd)
        {
            sumEven = 0;
            sumOdd = 0;
            do
            {
                sumEven += number % 10;
                sumOdd += number / 10 % 10;
                number /= 100;
            } while (number != 0);
        }
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            uint sumEven;
            uint sumOdd;
            Sums(number, out sumEven, out sumOdd);
            Console.WriteLine(sumEven);
            Console.WriteLine(sumOdd);
        }
    }
}
