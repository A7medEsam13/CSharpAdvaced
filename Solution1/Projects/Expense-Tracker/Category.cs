using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Expense_Tracker
{
    public class Category
    {
        public int ID {  get; set; }
        public string Name {  get; set; }

        public List<Category> Categories = new List<Category>();

        public Category(int id,string name)
        {
            ID = id;
            Name = name;
        }

        
    }
}
