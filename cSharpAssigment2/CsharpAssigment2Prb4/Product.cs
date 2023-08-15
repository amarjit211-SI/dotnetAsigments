using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssigment2Prb4
{
    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }

        public Product() { }    
        public Product(string name,int price,int quantity,string category)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Category = category;
        
        }
        public override string ToString() {     
        }
        //public override string ToString()
        //{
        //    return $"product name:{Name}    price:{Price}  Quantity:{Quantity} Category:{Category}";
        //}

    }
}
