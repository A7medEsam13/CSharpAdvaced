using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Library_Mangement_System_Applying_Concepts_
{
    internal class Borrower : Person
    {
        public List<Book> BorrowedBooks = new List<Book>();

        public List<DateOnly> BorrowRecords = new List<DateOnly>();
        public List<DateOnly> ReturnRecords = new List<DateOnly>();
        
        internal static bool LogIn(int id)
        {
            foreach(var borrower in Library.Borrowers)
            {
                if (borrower.ID == id)
                    return true;
            }
            return false;
        }

        internal void DisplayDetails()
        {
            Console.WriteLine("Borrow Records : ");
            foreach(var date in BorrowRecords)
            {
                Console.WriteLine(date);
            }
            Console.WriteLine("Return Records : ");
            foreach(var date in ReturnRecords)
            {
                Console.WriteLine(date);
            }
        }
    }
}
