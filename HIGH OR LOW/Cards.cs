using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIGH_OR_LOW
{
    public class Cards
    {
        int number;
        int color;
        public Cards(int num, int sort)
        {
            this.number = num;
            this.color = sort;
        }
        public void Display()
        {
            Console.WriteLine("Number: "+this.number + " Color: "+this.color);
        }
        public int Number()
        {
            return this.number;
        }
        public int Color()
        {
            return this.color;
        }
    }
}
