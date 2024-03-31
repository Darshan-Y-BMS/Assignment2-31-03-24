using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class PhysicalProduct : Product
    {
        protected double ShippingCost;

        public PhysicalProduct(string ProductId, string ProductName, double Price)
        {
            base.ProductId = ProductId;
            base.ProductName = ProductName;
            base.Price = Price;
        }
        public void GetProduct()
        {
            this.ShippingCost = base.Price + 100;

            Console.WriteLine("Product ID            : " + ProductId);
            Console.WriteLine("Product type          : Physical");
            Console.WriteLine("Product name          : " + ProductName);
            Console.WriteLine("Price                 : " + Price);
            Console.WriteLine("Shipping Cost         : " + ShippingCost);
        }
    }

}
