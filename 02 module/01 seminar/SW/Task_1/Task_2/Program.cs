using System;

namespace Task_2
{
    class RegularPolygon
    {
        public int N { get; set; }
        public double R { get; set; }

        public RegularPolygon(int n = 0, double r = 0)
        {
            N = n;
            R = r;
        }
        public double S
        {
            get
            {
                return N * 2 * R * Math.Tan(Math.PI / N);
            }
        }

        public double P
        {
            get
            {
                return R * P/2;
            }
        }
        public string PolygonData()
        {
            return N + " " + R + " " + P + " " + S;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            RegularPolygon polygon = new RegularPolygon(10, 10);
            Console.WriteLine(polygon.PolygonData());
        }
    }
}
