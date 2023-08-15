using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssigment2Prb2
{
    internal class Item
    {


        public string ProductName { get; set; } //prop plus 2 tab and clr d for copy  to create constructor ctor
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public Item(string productname ,int price,int quantity)
        {
            ProductName = productname;
            Price = price;
            Quantity = quantity;
            TotalPrice= price*quantity;
        }
        public override string ToString() {
            return $"product name:{ProductName}    price:{Price}  Quantity:{Quantity} TotalPrice:{TotalPrice}";
        }
    }
}
