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
        Boolean isTriDimensional;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.z = null;
            isTriDimensional = false;
        }
        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            isTriDimensional = true;
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
            if (isTriDimensional)
            {
                return (int)z;
            }
            throw new ArgumentException("This point isnt Tri dimensional, dimension Z doesnt exist");
            return null;
        }

        public void setZ(int z)
        {
            if (isTriDimensional)
            {
                this.z = z;
            }
            throw new ArgumentException("You cant add z dimension to this point because it is not Tri dimensional, you will have to recreate the point with z specified in constructor");
        }
    }
}
