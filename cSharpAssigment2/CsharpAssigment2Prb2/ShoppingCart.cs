using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssigment2Prb2
{
    internal class ShoppingCart
    {


        List<Item> items = new List<Item>()
       {
           new Item("shampoo",34,100),
           new Item("barbell",500,5),
       };
        int totalcart;

        public void AddItems()
        {
            Console.WriteLine("Enter product name");
            string ProductName = Console.ReadLine();
            Console.WriteLine("Enter Price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Quantity");
            int quantity = Convert.ToInt32(Console.ReadLine()); 

            Item i =new Item(ProductName, price, quantity); 
            items.Add(i);

        }
     
    public void DisplayItems()
        { 
            foreach (Item item in items)
            {
                Console.WriteLine(item);
               totalcart++;
                
            }
         
        }
    }
}
