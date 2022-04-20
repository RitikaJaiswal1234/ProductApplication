using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvProductDetails
{
    public class LybraryOperetions
    {
        public List<ProductData> getListOfProduct(string Path)
        {
            List<ProductData> product = new List<ProductData>();
            if (File.Exists(Path))
            {
                var productData = new StreamReader(Path);
                while (!productData.EndOfStream)
                {
                    var line = productData.ReadLine();
                    var column = line.Split(',');
                    product.Add(new ProductData(Convert.ToInt32(column[0]), column[1], Convert.ToInt32(column[2]), Convert.ToInt32(column[3]), column[4], Convert.ToDateTime(column[5])));

                }
                productData.Close();
            }
            else
            {
                Console.WriteLine("file doesn't exit");
            }
            return product;
        }
        public void getListOfPriceGroupById(List<ProductData> products)
        {
            Dictionary<int, TotalSaleByProductId> map = new Dictionary<int, TotalSaleByProductId>();
            foreach (ProductData product in products)
            {
                if (map.ContainsKey(product.Id))
                {
                    map[product.Id].AddPrice(product.Price, product.Quantity);
                }
                else
                {
                    map[product.Id] = new TotalSaleByProductId(product.Id, product.Name, product.Price, product.Quantity);
                }
            }
            var Writer = new StreamWriter(@"C:\Users\Ritika Jaiswal\Documents\productfile1.csv");
            foreach (var key in map.Keys)
            {
                var line = string.Format(map[key].Id + "," + map[key].Name + "," + map[key].TotalPrice);
                Writer.WriteLine(line);
                Writer.Flush();
            }
            Console.WriteLine(@"Open C:\Users\Ritika Jaiswal\Documents\productfile.csv to view Data");

        }
        public void getListOfTotalOrderGroupByPincode(List<ProductData> productDatas)
        {
            Dictionary<string, NumberOfProduct> map = new Dictionary<string, NumberOfProduct>();
            foreach (ProductData product in productDatas)
            {
                if (map.ContainsKey(product.PinCode))
                {
                    map[product.PinCode].addNumberOfOrder(product.Quantity);
                }
                else
                {
                    map[product.PinCode] = new NumberOfProduct(product.PinCode, product.Quantity);
                }

            }
            var Writer = new StreamWriter(@"C:\Users\Ritika Jaiswal\Documents\productfile2.csv");
            foreach (var key in map.Keys)
            {
                var line = string.Format(map[key].Pincode + "," + map[key].NumberOfOrder);
                Writer.WriteLine(line);
                Writer.Flush();

            }
            Console.WriteLine(@"Open C:\Users\Ritika Jaiswal\Documents\productfile.csv to view Data");
        }

    }
}
