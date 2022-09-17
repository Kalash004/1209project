using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /**
     * TODO: Add math to check length
     * length = sqrt((Xb - Xa)^2 + (Yb - Ya)^2 + (Zb - Za)^2)
     */
    internal class Line
    {
        private Point point1;
        private Point point2;
        private bool triDimensional;
        public Line(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
            if (point1.isTriDimensional() == point2.isTriDimensional())
            {
                triDimensional = point1.isTriDimensional();
            }
            else
            {
                throw new ArgumentException(String.Format("Points have to be the same dimensinal Point A: {0} Point B: {1} ", point1.ToString(), point2.ToString()));
            }
        }

        public Line(bool triDimensional)
        {
            this.triDimensional = triDimensional;
            if (triDimensional)
            {
                point1 = new Point(1, 1, 1);
                point2 = new Point(3, 3, 3);
            }
            else
            {
                point1 = new Point(1, 1);
                point2 = new Point(3, 3);
            }
        }


        public Point Point1
        {
            get { return point1; }
            set { point1 = value; }
        }

        public Point Point2
        {
            get { return point2; }
            set { point2 = value; }
        }

        public override string ToString()
        {
            return String.Format("Line : {0}, {1}", point1.ToString, point2.ToString);
        }

        public double getLength()
        {
            if (triDimensional)
            {
                int Xb = point2.X;
                int Yb = point2.Y;
                int Zb = (int)point2.getZ();

                int Xa = point1.X;
                int Ya = point1.Y;
                int Za = (int)point1.getZ();

                double part1 = (Xb - Xa) * (Xb - Xa);
                double part2 = (Yb - Ya) * (Yb - Ya);
                double part3 = (Zb - Za) * (Zb - Za);

                double length = Math.Sqrt(part1 + part2 + part3);
                return length;
            }
            else
            {
                int Xb = point2.X;
                int Yb = point2.Y;

                int Xa = point1.X;
                int Ya = point1.Y;


                double part1 = (Xb - Xa) * (Xb - Xa);
                double part2 = (Yb - Ya) * (Yb - Ya);

                double length = Math.Sqrt(part1 + part2);
                return length;
            }

        }
    }
}
