using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Library_Mangement_System_Applying_Concepts_
{
    internal class Library
    {
        public static List<Book> Books = new List<Book>();

        public static List<Borrower> Borrowers = new List<Borrower>();
        
        public static void AddBook()
        {
            Book NewBook = new Book();
            Console.Write("Enter The Title : ");
            NewBook.Title = Console.ReadLine();

            Console.Write("Enter The ID : ");
            NewBook.ID = int.Parse(Console.ReadLine());

            Console.Write("Enter The Author : ");
            NewBook.Author = Console.ReadLine();

            Console.Write("Enter The Quantity : ");
            NewBook.Quantity = int.Parse(Console.ReadLine());

            Books.Add(NewBook);

        }

        public static void RemoveBook()
        {
            int id;
            Console.Write("Enter Book ID : ");
            id = int.Parse(Console.ReadLine());
            foreach(var book in Books)
            {
                if (book.ID == id)
                    Books.Remove(book);
            }
            Console.WriteLine("Book has been removed successfully!");
        }

        public static void SearchBook()
        {
            int id;
            Console.WriteLine("Enter Book ID : ");
            id = int.Parse(Console.ReadLine());


            foreach (var book in Books)
            {
                if (book.ID == id)
                    book.DisplayDetails();
            }

        }

        public static void AddNewBorrower()
        {
            Borrower NewBorrower = new Borrower();
            string name;
            int id;
            Console.Write("Enter Borrower Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Borrower Id : ");
            id = int.Parse(Console.ReadLine());
            NewBorrower.Name = name;
            NewBorrower.ID = id;
            Borrowers.Add(NewBorrower);

        }

        

        public static void DeleteBorrowerRecords()
        {
            int id;
            Console.Write("Enter Borrower Id : ");
            id = int.Parse(Console.ReadLine());
            foreach(var borrower in Borrowers)
            {
                if (borrower.ID == id)
                {
                    borrower.BorrowRecords.Clear();
                    borrower.ReturnRecords.Clear();
                }
            }
        }

        public static void EditBookDetails()
        {
            int id;
            Console.Write("Enter Book Id : ");
            id = int.Parse(Console.ReadLine());

            int choice;
            Console.WriteLine("1.Edit Author");
            Console.WriteLine("2.Edit Title");
            Console.WriteLine("3.Edit Quantity");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                string NewAuthor;
                Console.Write("Enter The Name Of new Author : ");
                NewAuthor = Console.ReadLine();
                foreach(var book in Books)
                {
                    if(book.ID==id)
                    {
                        book.Author = NewAuthor;
                    }
                }
            }
            else if (choice == 2)
            {
                string NewTitle;
                Console.Write("Enter The new Title : ");
                NewTitle = Console.ReadLine();
                foreach (var book in Books)
                {
                    if (book.ID == id)
                    {
                        book.Title = NewTitle;
                    }
                }
            }
            else if (choice == 3)
            {
                int NewQuantity;
                Console.Write("Enter The New Quantity : ");
                NewQuantity = int.Parse(Console.ReadLine());
                foreach (var book in Books)
                {
                    if (book.ID == id)
                    {
                        book.Quantity = NewQuantity;

                    }
                }
            }
            Console.WriteLine("Information has been edited!");
        }

    }
}
