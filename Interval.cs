using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1209project
{
    internal class Interval
    {
        private int first;
        private int last;
        public Interval(int first, int last)
        {
            this.First = first;
            this.Last = last;
        }
        public Interval()
        {
        }

        public int First
        {
            get
            {
                return first;
            }
            set
            {
                first = value;
            }
        }

        public int Last
        {
            get
            {
                return last;

            }
            set
            {
                if (value > first)
                {
                    last = value;
                }
                else
                {
                    int hold = first;
                    first = value;
                    last = hold;
                    Console.WriteLine("Switched first boundary of the Interval and last boundary of the Interval ");
                }
            }

        }

        public Boolean isInInterval(int value)
        {
            if (value > this.first && value < this.last)
            {
                return true;
            }
            return false;
        }

        public Interval? findUnion(Interval interval2)
        {
            //if (this.first > interval2.Last || this.last < interval2.First)
            //{
            //  return null;
            //}
            if (this.first <= interval2.First && this.last <= interval2.Last && this.last >= interval2.First)
            {
                return new Interval(interval2.First, this.last);
            }
            else if (this.first >= interval2.First && this.last >= interval2.Last && this.first <= interval2.Last) 
            {
                return new Interval(this.first, interval2.Last);
            }
            else if (this.first <= interval2.First && this.last >= interval2.Last)
            {
                return new Interval(interval2.First, interval2.Last);
            }
            else if (this.first >= interval2.First && this.last <= interval2.Last)
            {
                return new Interval(this.first, this.last);
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            return String.Format("First : " + First + " Last : " + Last);
        }

    }
}

