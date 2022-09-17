using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ConsoleApp1
{
    enum Triangle_Type
    {
        Equilateral,
        Isosceles,
        Right_angled,
        Scalene
    }
    internal class Triangle
    {
        private Point a;
        private Point b;
        private Point c;
        private Line lineA;
        private Line lineB;
        private Line lineC;

        public Triangle(Point a, Point b, Point c)
        {
            if (a.pointEquals(b) && a.pointEquals(c) && b.pointEquals(c)) throw new ArgumentException("Points cant have same coordinates"); 
            if (a.X == b.X && b.X == c.X || a.Y == b.Y && b.Y == c.Y)
            {
                throw new ArgumentException("This triangle is impossible because it clips inside it self");
            }
            this.a = a;
            this.b = b;
            this.c = c;
            this.lineA = new Line(b, c);
            this.lineB = new Line(c, a);
            this.lineC = new Line(a, b);
        }


        //public Triangle(int sideA, int sideB, int sideC)
        //{
        //    if (sideA + sideB > sideC && sideC + sideA > sideB && sideB + sideC > sideA)
        //    {
        //        a = new Point(0, 0);
        //        b = new Point(sideC,0);
        //    }
        //}



        /*
         * TODO: Create point finder method.
         * For simplicity, triangle creation with lengthes of lines are done only with integers
         * this function doenst work yet.
         */
        private Point findLastPoint(Point point1, Point point2)
        {
            Point result = null;
            return result;
        }


        public Triangle_Type findType()
        {
            Triangle_Type type = Triangle_Type.Scalene;



            return type;
        }

        public double[] findAngles()
        {
            /* 
             * a^2 = b^2 + c^2 - 2bc * cos(A)
             * cos(A) = (b^2 + c^2 - a^2)/(-2bc)
             * 
             */
            double[] angles = new double[3];
            double la = lineA.getLength();
            double lb = lineB.getLength();
            double lc = lineC.getLength();

            // test


            double A = Math.Acos((Math.Pow(lb, 2) + Math.Pow(lc, 2) - Math.Pow(la, 2)) / (-2 * lb * lc));
            double B = Math.Acos((Math.Pow(la, 2) + Math.Pow(lc, 2) - Math.Pow(lb, 2)) / (-2 * la * lc));
            double C = Math.Acos((Math.Pow(la, 2) + Math.Pow(lb, 2) - Math.Pow(lc, 2)) / (-2 * la * lb));
            angles[0] = A;
            angles [1] = B;
            angles [2] = C;

            return angles;
        }
    }
}
