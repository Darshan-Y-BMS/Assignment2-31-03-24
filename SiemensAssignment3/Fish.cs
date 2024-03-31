using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class Fish : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Fish perform Stridulation to make sound");
        }
        public override void Move()
        {
            Console.WriteLine("Fish will swim with fins");
        }
    }

}
