using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class Square : Shapes
    {
        public float side;

        public Square(float x, float y, float side) : base(x, y)
        {
            this.side = side;
        }

        public void drawShape()
        {
            Console.Write($"Draw a Square of side {side} units at the point ");
            this.getCoOrdinate();
        }

    }

}
