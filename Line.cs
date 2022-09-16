using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /**
     * TODO: Add math to check length
     * 
     */
    internal class Line
    {
        private Point point1;
        private Point point2;
        public Line(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public Line(Boolean isTriDimensional)
        {
            if (isTriDimensional)
            {
                point1 = new Point(1,1,1);
                point2 = new Point(3,3,3);
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
    }
}
