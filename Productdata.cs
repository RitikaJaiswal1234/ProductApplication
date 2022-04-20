using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvProductDetails
{
    public class ProductData
    {  
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; } 
        public string PinCode { get; set; }
        public DateTime Date { get; set; }

        public ProductData(int Id,string Name,float Price,int Quantity,string PinCode,DateTime Date)
        {
            this.Id = Id;
            this.Name = Name;   
            this.Price = Price; 
            this.Quantity = Quantity;
            this.PinCode = PinCode;
            this.Date = Date;

        }

       
    }
}
