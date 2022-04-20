using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvProductDetails
{
    public class Executer
    {
       
        public static void Main(String[] args)
        {
            LybraryOperetions lybraryOperetions = new LybraryOperetions();
            List<ProductData> products = lybraryOperetions.getListOfProduct(@"C:\Users\Ritika Jaiswal\Documents\ProductSaleFile.csv");
            lybraryOperetions.getListOfPriceGroupById(products);
            lybraryOperetions.getListOfTotalOrderGroupByPincode(products);
        }
    }
}
