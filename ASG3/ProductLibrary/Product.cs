using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary
{
    public class Product
    {
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public int Quantity { get; set; }
        public float Unitprice { get; set; }
        public float SubTotal
        {
            get
            {
                return Unitprice * Quantity;
            }
        }

    }
}
