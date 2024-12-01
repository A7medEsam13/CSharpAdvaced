using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Library_Mangement_System_Applying_Concepts_
{
    internal class App
    {
        public static void Run()
        {
            while (true)
            {
                int choice;
                int id;
                Console.WriteLine("Are you Librarian or Borrower ? (1 or 2)");
                Console.WriteLine("1.Librarian");
                Console.WriteLine("2.Borrower");
                Console.WriteLine("3.EXIT");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------");

                if (choice == 1)
                {


                    Console.WriteLine("1.Mange Books");
                    Console.WriteLine("2.Mange Borrowers");
                    Console.WriteLine("3.Mange Transactions");
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------------------");

                    if (choice == 1)
                    {
                        Console.WriteLine("1.Add new books to the library");
                        Console.WriteLine("2.Edit book details (e.g., title, author, quantity)");
                        Console.WriteLine("3.Delete books no longer in circulation");
                        Console.WriteLine("4.Search for books using LINQ queries");
                        choice = int.Parse(Console.ReadLine());
                        Console.WriteLine("-------------------------------------");

                        if (choice == 1)
                            Library.AddBook();
                        else if (choice == 2)
                            Library.EditBookDetails();
                        else if (choice == 3)
                            Library.RemoveBook();
                        else if (choice == 4)
                            Library.SearchBook();
                        Console.WriteLine("-------------------------------------");
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("1.Add new borrowers");
                        //Console.WriteLine("2.Update borrower information");
                        Console.WriteLine("2.Delete borrower records");
                        choice = int.Parse(Console.ReadLine());
                        Console.WriteLine("-------------------------------------");
                        if (choice == 1)
                            Library.AddNewBorrower();
                        //else if (choice == 2)
                        //    Library.UpdateBorrowerInfo();
                        else if (choice == 2)
                            Library.DeleteBorrowerRecords();
                        Console.WriteLine("-------------------------------------");
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("1.Borrow a book (reduce the book's quantity)");
                        Console.WriteLine("2.Return a book (increase the book's quantity)");
                        Console.WriteLine("3.View borrowing history of a borrower");
                        choice = int.Parse(Console.ReadLine());
                        Console.WriteLine("-------------------------------------");
                        if (choice == 1)
                            Transaction.BorrowBook();
                        else if (choice == 2)
                            Transaction.ReturnBook();
                        else if (choice == 3)
                            Transaction.ViewBorrowingHistory();
                        Console.WriteLine("-------------------------------------");
                    }

                }
                else if (choice == 2)
                {


                    Console.WriteLine("1.Search For a book");
                    Console.WriteLine("2.Borrow a book");
                    Console.WriteLine("3.Return a book");
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------------------");
                    if (choice == 1)
                        Library.SearchBook();
                    else if (choice == 2)
                        Transaction.ReturnBook();
                    else if (choice == 3)
                        Transaction.ViewBorrowingHistory();



                }
                else if (choice == 3)
                    break;
            }
        }
    }
}
