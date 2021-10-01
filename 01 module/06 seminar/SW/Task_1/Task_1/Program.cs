using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 9; i >= 0; i--)
            {
                int num = n;
                while (num > 0)
                {
                    if ((num % 10) == i)
                    {
                        l = l * 10 + i;
                    }
                    num /= 10;
                }
            }
            Console.WriteLine(l); ;
        }
    }
}