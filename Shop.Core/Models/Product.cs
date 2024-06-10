using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Models
{
    public class Product
    {
        private static  int _id;
        public int ID { get; set; }
        public string Name { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public Product() {
            ++_id;
            ID=_id;
        }
        public Product(string name, double cost, double sale):this() { 
            Name = name;
            CostPrice = cost;
            SalePrice = sale;
        }

    }
}
