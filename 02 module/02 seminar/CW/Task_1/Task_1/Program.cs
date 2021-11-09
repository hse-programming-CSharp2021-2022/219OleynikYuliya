using System;

namespace Task_1
{
    class Polygon
    {
        private int sides;
        private int rad;

        public Polygon(int sides = 0, int rad = 0)
        {
            Sides = sides;
            Radius = rad;
        }

        public int Radius
        {
            get
            {
                return rad;
            }
            set
            {
                rad = value;
            }

        }
        public int Sides
        {
            get
            {
                return sides;
            }
            set
            {
                sides = value;
            }

        }

        public double Perimeter()
        {
            return 2 * (Radius / (Math.Cos(Math.PI / Sides))) * (Math.Sin(Math.PI / Sides));
        }

        public double Square()
        {
            return 0.5 * Perimeter() * (Radius / (Math.Cos(Math.PI / Sides)));
        }

        public void PolygonData()
        {
            Console.WriteLine($"R=: {this.Radius}\n" + $"N=: {this.Sides}\n" + $"P=: {this.Perimeter()}\n" + $"S= {this.Square()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var coolMan = new Polygon(3, 4);
            coolMan.PolygonData();
        }
    }
}