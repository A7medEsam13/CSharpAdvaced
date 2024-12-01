using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Library_Mangement_System_Applying_Concepts_
{
    internal class Transaction
    {
        public int TransactionID { set; get; }

        public int BorrowerID { set; get; }
        
        public int BookID { set; get; }

        public DateOnly BorrowDate { set; get; }

        public DateOnly ReturnDate { set; get; }

        public void Recordtransaction()
        {

        }

        public static void BorrowBook()
        {
            int bookId;
            int day, month, year;
            int BorrowerId;
            DateOnly BorrowDate;
            Console.WriteLine("Enter Book ID : ");
            bookId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Borrower ID : ");
            BorrowerId = int.Parse(Console.ReadLine());
            Console.Write("Date Of borrow : ");
            Console.Write("Year : ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Month : ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Day : ");
            day = int.Parse(Console.ReadLine());
            BorrowDate = new DateOnly(year, month, day);


            foreach (var borrower in Library.Borrowers)
            {
                if (borrower.ID == BorrowerId)
                {
                    borrower.BorrowedBooks.Add((Book)Library.Books.Where(x => x.ID == bookId));
                    borrower.BorrowRecords.Add(BorrowDate);

                }
            }
            foreach(var book in Library.Books)
            {
                if (book.ID == bookId)
                    book.Quantity -= 1;
            }
            
        }

        public static void ReturnBook()
        {
            int bookId;
            int BorrowerId;
            DateOnly ReturnDate;
            Console.WriteLine("Enter Book ID : ");
            bookId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Borrower ID : ");
            BorrowerId = int.Parse(Console.ReadLine());
            Console.Write("Enter Date Of Return(yyyy/mm/dd) : ");
            ReturnDate = DateOnly.Parse(Console.ReadLine());


            foreach (var borrower in Library.Borrowers)
            {
                if (borrower.ID == BorrowerId)
                {
                    borrower.BorrowedBooks.Remove((Book)Library.Books.Where(x => x.ID == bookId));
                    borrower.ReturnRecords.Add(ReturnDate);

                }
            }
            foreach (var book in Library.Books)
            {
                if (book.ID == bookId)
                    book.Quantity += 1;
            }

        }

        public static void ViewBorrowingHistory()
        {
            int id;
            Console.Write("Enter Borrower Id : ");
            id = int.Parse(Console.ReadLine());

            ((Borrower)Library.Borrowers.Where(x => x.ID == id)).DisplayDetails();
            

        }

    }
}
