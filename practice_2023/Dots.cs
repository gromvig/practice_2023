using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace practice_2023
{
    public class Dots
    {
        private int z;
        private int r;
        private double angle;
        public dec_Dots decDot;
        public Dots(int z, int r, double angle)
        {
            this.z = z;
            this.r = r;
            this.angle = angle;
            this.decDot = this.convert_to_dec();
        }
        public dec_Dots convert_to_dec()
        {
            return new dec_Dots(this.z, this.r, this.angle);

        }
        public double Dots_distance(dec_Dots dot1, dec_Dots dot2)
        {
            double dist = Sqrt(Pow(dot2.x - dot1.x, 2) + Pow(dot2.y - dot1.y, 2) + Pow(dot2.z - dot1.z, 2));
            return Round(dist, 4);
        }
        public double straight_distance(dec_Dots dot, double x0, double y0, double z0, double m, double n, double p)

        {
            double i = (y0 - dot.y) * p - (z0 - dot.z) * n;
            double j = ((x0 - dot.x) * p - (z0 - dot.z) * m) * (-1);
            double k = (x0 - dot.x) * n - (y0 - dot.y) * m;
            double d = Sqrt(Pow(i, 2) + Pow(j, 2) + Pow(k, 2)) / Sqrt(Pow(m, 2) + Pow(n, 2) + Pow(p, 2));
            return Round(d, 4);
        }
        public double triangle_square(dec_Dots dot1, dec_Dots dot2, dec_Dots dot3)
        {
            double a = Dots_distance(dot1, dot2);
            double b = Dots_distance(dot2, dot3);
            double c = Dots_distance(dot1, dot3);
            double p = (a + b + c) / 2;
            double s = Sqrt(p * (p - a) * (p - b) * (p - c));
            return Round(s, 4);
        }

    }
    public class dec_Dots
    {
        public double x;
        public double y;
        public double z;
        public dec_Dots(int z, int r, double angle)
        {
            x = r * Cos(angle);
            y = r * Sin(angle);
            this.z = z;
        }

    }

}
