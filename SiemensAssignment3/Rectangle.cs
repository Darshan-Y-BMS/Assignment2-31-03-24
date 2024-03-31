using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class Rectangle : Shape
    {
        private float length;
        private float breadth;

        public Rectangle(float length, float breadth)
        {
            this.length = Math.Abs(length);
            this.breadth = Math.Abs(breadth);
        }
        public void CalculateArea()
        {
            area = length * breadth;
        }
        public void ShowArea()
        {
            Console.WriteLine("Area of Rectangle is = " + area + " Squnits");
        }
    }

}
