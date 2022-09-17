using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Food
    {
        private String name;
        private String description;
        private int mass;
        private double kcal;
        public String Name { get { return name; } set { name = value; } }
        public String Description { get { return description; } set { description = value; } }
        public int Mass { get { return mass; } set { mass = value; } }
        public double Kcal { get { return kcal; } set { kcal = value; } }
    }
}
