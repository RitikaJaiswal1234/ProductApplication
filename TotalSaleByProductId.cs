using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvProductDetails
{
    public  class TotalSaleByProductId
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float TotalPrice { get; set; }

        public TotalSaleByProductId(int Id,string Name,float Price,int Quantity)
        {
            this.Id = Id;   
            this.Name = Name;
            float temp = Price * Quantity;     
            this.TotalPrice = temp;
        }
        public void AddPrice(float Price,int Quantity)
        {
            float temp = Price * Quantity;  
            this.TotalPrice+=temp;
        }
    }
}
