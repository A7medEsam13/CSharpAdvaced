using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Library_Mangement
{
    public class Book
    {
        public string Title {  get; set; }
        public string author {  get; set; }
        public string ISBN {  get; set; }
        public bool Isavailable {  get; set; }

        public Book(string title, string author, string ISBN)
        {
            this.Title = title;
            this.author = author;
            this.ISBN = ISBN;
            Isavailable = true;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Title : {this.Title} , Author : {this.author} , ISBN : {this.ISBN} , Available : {this.Isavailable}.");
        }

    }
}
