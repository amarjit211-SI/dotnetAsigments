namespace CsharpAssigment2Prb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();    
            library.AddBooks();
            library.DisplayBooks();
            library.SearchByTitle();


        }
    }
}