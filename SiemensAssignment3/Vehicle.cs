using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class Vehicle
    {
        protected string Make;
        protected string Model;
        protected int Year;

        public Vehicle(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
    }

}
