using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Library_Mangement
{
    public class App
    {

        public static void Run()
        {
            Library library = new Library();

            // Adding Books to the Library
            library.AddBook(new Book("C# in Depth", "Jon Skeet", "123456"));
            library.AddBook(new Book("Clean Code", "Robert C. Martin", "789012"));
            library.AddBook(new Book("The Pragmatic Programmer", "Andy Hunt", "345678"));

            // Adding Members to the Library
            library.AddMember(new Members("Alice", 1));
            library.AddMember(new Members("Bob", 2));

            // Display Available Books
            library.DisplayAvailableBooks();

            // Borrowing Books
            Members alice = library.GetMemberByID(1);
            Book bookToBorrow = library.GetBookByISBN("123456");
            alice.BorrowBook(bookToBorrow);

            // Display Borrowed Books
            alice.DisplayBorrowedBooks();

            // Display Available Books After Borrowing
            library.DisplayAvailableBooks();

            // Returning Books
            alice.ReturnBook(bookToBorrow);

            // Display Available Books After Returning
            library.DisplayAvailableBooks();

            // Invalid Operations
            alice.ReturnBook(bookToBorrow);
        }
    }
}
