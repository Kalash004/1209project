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
        private int precentholder;


        public Food(String name, String description, double mass, double? kcal, double? kj)
        {
            this.name = name;
            this.description = description;
            this.mass = mass;
            this.kcal = kcal;
            this.kj = kj;

            if (kj == null) this.kj = toKj(Kcal);
            if (kcal == null) kcal = toKcal(Kj);
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
            get { return (double)kcal; }
            set
            {
                if (value < 0) throw new Exception("kcal cant be 0");
                kcal = value;
            }
        }
        public double Kj
        {
            get { return (double)kj; }
            set
            {
                if (value < 0) throw new Exception("kj cant be 0");
                kj = value;
            }
        }

        public double toKj(double value)
        {
            return value * 4.184;
        }

        public double toKcal(double value)
        {
            return value / 4.184;
        }

        public int precentOf(int kcal)
        {
            int precent = (int)(this.kcal / (kcal / 100));
            this.precentholder = precent;
            return precent;
        }
        public override string ToString()
        {
            return String.Format("\n{0}: \n" +
                "{1} \n" +
                "mass: {2} \n" +
                "kcal: {3} \n" +
                "kj: {4} \n" +
                "precentage of ration: {5}%", name, description, mass.ToString(), kcal.ToString(), kj.ToString(), this.precentholder);

        }
    }
}
