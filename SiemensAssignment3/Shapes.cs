using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class Shapes
    {
        protected float x;
        protected float y;
        public Shapes(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public void getCoOrdinate()
        {
            Console.WriteLine($"({x},{y})");
        }
    }

}
