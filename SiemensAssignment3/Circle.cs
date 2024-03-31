using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class Circle : Shape
    {
        private float radius;
        public Circle(float radius)
        {

            this.radius = Math.Abs(radius);
        }

        public void CalculateArea()
        {
            area = radius * radius * (Math.PI);
        }
        public void ShowArea()
        {
            Console.WriteLine("Area of circle is    = " + area.ToString("F4") + " Squnits");
        }
    }

}
