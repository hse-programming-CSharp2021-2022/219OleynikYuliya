using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double U;
            Console.WriteLine("Введите значение напряжения:");
            double.TryParse(Console.ReadLine(), out U);
            double R;
            Console.WriteLine("Введите значение сопротивления:");
            double.TryParse(Console.ReadLine(), out R);
            double P = Math.Pow(U, 2) / R;
            Console.WriteLine("Значение мощности: " + P);
        }
    }
}
