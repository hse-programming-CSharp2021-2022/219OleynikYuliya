using System;

namespace Task_1
{
    class Program
    {

        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
            public double Ro
            {
                get
                {
                    return Math.Sqrt(X * X + Y * Y);
                }
            }

            public double Fi
            {
                get
                {
                    return Math.Atan2(Y, X);
                }
            }

            public override string ToString()
            {
                return $"x = {X}\ty = {Y}\nR = {Ro}\tFi = {Fi}\n";
            }
        }

        static void Main()
        {
            Point x, y, z;
            x = new Point(1, -1);
            Console.WriteLine("Первая созданная точка");
            Console.WriteLine(x);
            y = new Point(10, 12);
            Console.WriteLine("Вторая созданная точка");
            Console.WriteLine(y);
            double x2 = 0, y2 = 0;
            do
            {
                Console.Write("Введите x = ");
                double.TryParse(Console.ReadLine(), out x2);
                Console.Write("Введите y = ");
                double.TryParse(Console.ReadLine(), out y2);
                z = new Point(x2, y2);


            } while (x2 != 0 | y2 != 0);
        }
    }
}
