namespace CsharpAssigment3Prb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electronics electronics = new Electronics();
            electronics.productId = 1;
            electronics.productName = "Smart Phone";
            electronics.productPrice = 200000;
            electronics.productStock = 6;
            electronics.productBrand = "lava";
            Console.WriteLine(electronics);
            Console.WriteLine("\n");

            Clothing clothing = new Clothing();
            clothing.productId = 2;
            clothing.productName = "Shirt";
            clothing.productPrice = 1200;
            clothing.productStock = 8;
            clothing.clothSize = 34;
            Console.WriteLine(clothing);
            Console.WriteLine("\n");

            Books books = new Books();
            books.productId = 3;
            books.productName = "one piece";
            books.productPrice = 200;
            books.productStock = 30;
            books.authorName = "anime";
            Console.WriteLine(books);

        }
    }
}