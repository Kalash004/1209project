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
        private double mass;
        private double? kcal;
        private double? kj;
        
        public Food(String name, String description, double mass, double? kcal, double? kj)
        {
            this.name = name;
            this.description = description; 
            this.mass = mass; 
            this.kcal = kcal;
            this.kj = kj;  
        }


        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String Description
        {
            get { return description; }
            set { description = value; }
        }
        public double Mass
        {
            get { return mass; }
            set
            {
                if (value < 0) throw new Exception("Mass cant be 0");
                mass = value;
            }
        }
        public double Kcal
        {
            get { return kcal; }
            set 
            {
                if (value < 0) throw new Exception("kcal cant be 0");
                kcal = value;
            }
        }

        
    }
}
