using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvProductDetails
{
    public class NumberOfProduct
    {
        public string Pincode { get; set; }
        public int NumberOfOrder { get; set; }

        public NumberOfProduct(string Pincode, int NumberOfOrder)
        {
            this.Pincode = Pincode;
            this.NumberOfOrder = NumberOfOrder;
        }
        public void addNumberOfOrder(int Quantity)
        {
            this.NumberOfOrder = NumberOfOrder+Quantity;
        }
    }
}
