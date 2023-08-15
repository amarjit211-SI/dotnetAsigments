using System.Security.Cryptography.X509Certificates;

namespace CsharpAssigment2Prb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddItems();
            cart.DisplayItems();
        }
    }
}