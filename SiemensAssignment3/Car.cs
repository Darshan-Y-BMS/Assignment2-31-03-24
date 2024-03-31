using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class Car : Vehicle
    {
        protected string Fuel;

        public Car(string make, string model, int year, string Fuel) : base(make, model, year)
        {
            this.Fuel = Fuel;
        }
        public void show()
        {

            Console.WriteLine("Make      : " + Make);
            Console.WriteLine("Model     : " + Model);
            Console.WriteLine("Year      : " + Year);
            Console.WriteLine("Fuel      : " + Fuel);
        }
    }
  
}
