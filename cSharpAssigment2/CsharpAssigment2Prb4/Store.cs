using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssigment2Prb4
{
    internal class Store
    {
        int totalprice;
        List<Product> productList = new List<Product>()

        {
            new Product("tv",24,4,"electronics"),
            new Product("phone",45,32,"electronics"),

        };
        public void AddProduct()//add the items
        {
            Console.WriteLine("Enter your product");
            string productname=Console.ReadLine();
            Console.WriteLine("Enter price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("eneter the category");
            string category = Console.ReadLine();
            
            Product product = new Product(productname,price,quantity,category);//create a product object and pass thje value
               productList.Add(product);//product ko list mai add kiya
               
        }
        public void DisplayProduct()
        {
            foreach(Product product in productList)
            {
                Console.WriteLine(product);
                totalprice = totalprice +( product.Quantity*product.Price);
                
            }
            Console.WriteLine(totalprice);
        }
    }

}
