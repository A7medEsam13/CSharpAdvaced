using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Library_Mangement_System_Applying_Concepts_
{
    internal class Book
    {
        public int ID { set; get; }

        public string Title { set; get; }
        public string Author { set; get; }
        public int Quantity { set; get; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Book ID : {ID}");
            Console.WriteLine($"Book Title : {Title}");
            Console.WriteLine($"Book Author : {Author}");
            Console.WriteLine($"Book Quantity : {Quantity}");
        }

    }
}
