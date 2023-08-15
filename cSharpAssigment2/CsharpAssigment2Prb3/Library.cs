using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssigment2Prb3
{
    internal class Library
    {
        List<Book> booklist = new List<Book>()
        {
            new Book("onepiece","amar","iguwef",2),
        };
        

        public void AddBooks()
        {
            Console.WriteLine("eneter the title:");
            string title = Console.ReadLine();

            Console.WriteLine("enter the author");
            string author=Console.ReadLine();

            Console.WriteLine("enter the genre:");
            string genre =Console.ReadLine();

            Console.WriteLine("Enter the quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());

            
            Book b =new Book(title, author, genre, quantity);
            booklist.Add(b);
        }
        public void SearchByTitle()
        {
            string title;
            Console.WriteLine("eneter the title of the book to be search");
            title = Console.ReadLine();
            Book b =  booklist.Find(e=>e.title == title);
            Console.WriteLine(b);
        }

        public void DisplayBooks()
        {
            foreach(Book books in booklist)
            {
                Console.WriteLine(books);
            }
        }
        
         
    }
}
