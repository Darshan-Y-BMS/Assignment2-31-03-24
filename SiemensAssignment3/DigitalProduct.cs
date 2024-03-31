using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class DigitalProduct : Product
    {
        protected string Link;

        public DigitalProduct(string ProductId, string ProductName, double Price,string Link)
        {
            base.ProductId = ProductId;
            base.ProductName = ProductName;
            base.Price = Price;
            this.Link = Link;
        }

        public void GetProduct()
        {
            this.Link = "https://darshan.siemens.in";

            Console.WriteLine("Product ID            : " + ProductId);
            Console.WriteLine("Product type          : Digital");
            Console.WriteLine("Product name          : " + ProductName);
            Console.WriteLine("Price                 : " + Price);
            Console.WriteLine("Digital Prodcut Link  : " + Link);
        }

    }
}
