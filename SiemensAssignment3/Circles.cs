using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class Circles : Shapes
    {
        public float Radius;
        public Circles(float x, float y, float radius) : base(x, y)
        {
            this.Radius = radius;
        }

        public void drawShape()
        {
            Console.Write($"Draw a Circle of radius {Radius} at the point ");
            this.getCoOrdinate();
        }
    }

}
