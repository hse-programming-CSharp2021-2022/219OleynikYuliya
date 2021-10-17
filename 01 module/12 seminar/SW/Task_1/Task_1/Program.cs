using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task_1
{
    class Program
    {
        static bool Pm(int t)
        {
            string t1 = t.ToString();
            for (var i = 0; i < t1.Length; i++)
            {
                if (t1[i] != t1[t1.Length - 1 - i])
                    return false;
            }
            return true;
        }

        public static int Size(int t)
        {
            int sum = 0;
            while (t > 0)
            {
                sum += t % 10;
                t /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            Random rnd = new Random();
            for (int i= 0; i < n; i++)
            {
                mas[i] = rnd.Next(1, 100);
            }

            foreach (var t in mas)
                Console.WriteLine(t + " ");
                Console.WriteLine();

            var selected1 = from t in mas
                            where t%3==0
                            where t < 100
                            where t > 9
                            select t;

            var selected2 = from t in mas
                            where Pm(t)
                            orderby t
                            select t;

            var selected3 = from t in mas
                            orderby Size(t)
                            select t;

            var selected4 = (from t in mas
                            where t >= 1000
                            where t <=9999
                            select t).ToArray().Sum();
            Console.WriteLine(selected4);

            var selected5 = (from t in mas
                            where t >= 10
                            where t <= 99
                            select t).ToArray().Min();
            Console.WriteLine(selected5);

            var selected6 = from t in mas
                            where t > 999
                            select t; 

            foreach (var t in selected3)
                Console.WriteLine(t + " "); 

            string s = Console.ReadLine();
            Regex regex = new Regex(@"\w{4}");
            foreach (var i in regex.Matches(s))
                Console.WriteLine(i); 
        }
    }
}
