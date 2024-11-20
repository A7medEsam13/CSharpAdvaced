using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Library_Mangement
{
    public class Library
    {
        public List<Book> Books = new List<Book>();
        public List<Members> Members = new List<Members>();

        public Library()
        {
            Books = new List<Book>();
            Members = new List<Members>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"{book.Title} has Added to the lobrary.");
        }

        public void AddMember(Members member)
        {
            Members.Add(member);
            Console.WriteLine($"Member {member.Name} has been added to the library.");
        }

        public void DisplayAvailableBooks()
        {
            Console.WriteLine("Available Books In the library : ");
            foreach(var book in Books.Where(x => x.Isavailable))
            {
                book.DisplayDetails();
            }
        }

        public Members GetMemberByID(int id)
        {
            return Members.FirstOrDefault(m => m.MemberShipId == id);
        }

        public Book GetBookByISBN(string isbn)
        {
            return Books.FirstOrDefault(b => b.ISBN == isbn);
        }


    }
}
