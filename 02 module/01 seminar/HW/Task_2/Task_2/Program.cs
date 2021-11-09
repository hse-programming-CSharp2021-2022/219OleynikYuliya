using System;

namespace Task_2
{
    class Program
    {
        public class Polygon
        {
            int numb;
            double radius;
            public Polygon(int n = 3, double r = 1)
            {
                numb = n;
                radius = r;
            }
            public double Perimetr
            {
                get
                {
                    double term = Math.Tan(Math.PI / numb);
                    return 2 * numb * radius * term;
                }
            }

            public double Area
            {
                get
                {
                    return Perimetr * radius / 2;
                }
            }

            public string PolygonData()
            {
                return string.Format($"N = {0}; R = {1}; P = {2,2:F3}, S = {3,4:F3}", numb, radius, Perimetr, Area);
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите количество многоугольников: ");
                int numOfPolygons = int.Parse(Console.ReadLine() ?? string.Empty);
                Polygon[] arrPolygon = new Polygon[numOfPolygons];
                double minValue = double.MaxValue;
                double maxValue = 0;
                for (int i = 0; i < numOfPolygons; i++)
                {
                    Console.Write("Введите количество сторон: ");
                    int numSides = int.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("Введите радиус: ");
                    int radius = int.Parse(Console.ReadLine() ?? string.Empty);
                    arrPolygon[i] = new Polygon(numSides, radius);
                    if (arrPolygon[i].Square() <= minValue)
                    {
                        minValue = arrPolygon[i].Square();
                    }

                    if (arrPolygon[i].Square() >= maxValue)
                    {
                        maxValue = arrPolygon[i].Square();
                    }
                }
                foreach (var item in arrPolygon)
                {
                    if (item.Square() == maxValue)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        item.PolygonData();
                        Console.ResetColor();
                    }
                    else if (item.Square() == minValue)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        item.PolygonData();
                        Console.ResetColor();
                    }
                    else
                        item.PolygonData();
                }
                Console.WriteLine("Введите q, чтобы выйти."); 
            } while (Console.ReadLine() != "q");

        }
    }
}
