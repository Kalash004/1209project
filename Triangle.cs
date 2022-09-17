using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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
            this.a = a;
            this.b = b;
            this.c = c;

            this.lineA = new Line(b, c);
            this.lineB = new Line(c, a);
            this.lineC = new Line(a, b);
        }

        /*
         * TODO: Create point finder method.
         * For simplicity, triangle creation with lengthes of lines are done only with integers
         * this function doenst work yet.
         */
        //public Triangle(int sideA, int sideB, int sideC)
        //{
        //    if (sideA + sideB > sideC && sideC + sideA > sideB && sideB + sideC > sideA)
        //    {
        //        a = new Point(0, 0);
        //        b = new Point(sideC,0);
        //    }
        //}

        public Point findLastPoint(Point point1, Point point2) 
        {
            Point result = null;



            return result;
        }
    }
}
