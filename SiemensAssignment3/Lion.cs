using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class Lion : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Lion will Roar to  make sound");
        }
        public override void Move()
        {
            Console.WriteLine("Lion will walk on padded paws");
        }

    }

}
