using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Point
    {
        private int x;
        private int y;
        private int? z;
        private Boolean triDimensional;


        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.z = null;
            triDimensional = false;
        }
        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            triDimensional = true;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int? getZ()
        {
            if (triDimensional)
            {
                return z;
            }
            else
            {
                throw new ArgumentException("This point isnt Tri dimensional, dimension Z doesnt exist");
                return null;
            }
        }

        public void setZ(int z)
        {
            if (triDimensional)
            {
                this.z = z;
            }
            throw new ArgumentException("You cant add z dimension to this point because it is not Tri dimensional, you will have to recreate the point with z specified in constructor");
        }

        public Boolean isTriDimensional()
        {
            return triDimensional;
        }

        public bool pointEquals(Point target)
        {
            bool result = true;
            if (triDimensional)
            {
                if (this.x == target.x && this.y == target.y && this.z == target.z)
                {
                    return result;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                if (this.x == target.x && this.y == target.y)
                {
                    return result;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        public override string ToString()
        {
            if (!triDimensional)
            {
                return String.Format("Point X : {0} Y : {1} Z : {2} ", this.x, this.y, this.z);
            }
            return String.Format("Point X : {0} Y : {1}", this.x, this.y);
        }
    }
}
