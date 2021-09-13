using System;

namespace Seminar
{
    class Program
    {
        public static int CalculateBine(uint n)
        {
            double b = (1 + Math.Sqrt(5)) / 2;
            double un = (Math.Pow(b, n) - Math.Pow(-b, -n)) / (2 * b - 1);
            return (int)(un + 0.5);
        }
        static void Main(string[] args)
        {
            uint n;
            int res;
            string line;
            do
            {
                Console.WriteLine("Введите номер члена ряда: ");
                line = Console.ReadLine();
            }
            while (!uint.TryParse(line, out n));
            res = CalculateBine(n);
            Console.WriteLine("Число Фибоначчи: " + res);
            Console.WriteLine("Для выхода из программы нажмите ENTER.");
            Console.ReadLine();
        }
    }
}
