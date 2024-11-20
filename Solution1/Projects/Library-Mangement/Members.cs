using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Library_Mangement
{
    public class Members
    {
        public string Name { get; set; }
        public int MemberShipId {  get; set; }
        public List<Book> BorrowBooks { get; private set; }

        public Members(string name,int membership)
        {
            Name = name;
            MemberShipId = membership;
            BorrowBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (book.Isavailable)
            {
                BorrowBooks.Add(book);
                book.Isavailable = false;
                Console.WriteLine($"{Name} Borrowed the book {book.Title}.");

            }
            else
            {
                Console.WriteLine($"sorry, the book {book.Title} is not available!");

            }

        }

        public void ReturnBook(Book book)
        {
            if(BorrowBooks.Contains(book))
            {
                BorrowBooks.Remove(book);
                book.Isavailable = true;
                Console.WriteLine($"{Name} Returned The book {book.Title}.");
                
            }
            else
            {
                Console.WriteLine($"{Name} has not borrowed the book {book.Title}.");
            }
        }

        public void DisplayBorrowedBooks()
        {
            Console.WriteLine($"Books borrowed by {Name} : ");
            foreach (Book book in BorrowBooks)
            {
                Console.WriteLine($"- {book.Title}");
            }
        }

    }
}
