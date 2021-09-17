using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "5 / 3 = ";
            Console.WriteLine(result + 5 / 3);
            result = "5.0 / 3.0 = ";
            Console.WriteLine(result + (5.0 / 3.0).ToString("F"));
            int result7 = 5 / 3;
            Console.WriteLine(result7 + " - это 5 / 3");
            Console.WriteLine("Нажмите ENTER для продолжения");
            Console.ReadLine();
        }
    }
}
