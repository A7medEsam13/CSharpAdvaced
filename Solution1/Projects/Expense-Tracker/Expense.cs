using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Expense_Tracker
{
    public class Expense
    {
        public int ID { set; get; }
        public DateTime Date { set; get; }
        public decimal Amount {  set; get; }
        public string Category {  set; get; }
        public string Description { set; get; }

        public static List<Expense> Expenses = new List<Expense>();


        public Expense(DateTime date, decimal amount,string category,string description)
        {
            Date = date;
            Amount = amount;
            Category = category;
            Description = description;
        }

        public void AddNewExpense(Expense expense)
        {
            
        }

        public static void DeleteExpense(int id)
        {
            for(var i = 0; i < Expenses.Count - 1; i++)
            {
                if(Expenses[i].ID == id)
                    Expenses.RemoveAt(i);
                break;
            }
            Console.WriteLine("------------- Expense deleted! ---------------");
            
        }

        public static void ListAllExpenses()
        {
            Console.WriteLine("------------------- All Expenses ------------------");
            foreach(var  expense in Expenses)
            {
                Console.WriteLine($"ID : {expense.ID}");
                Console.WriteLine($"Date : {expense.Date}");
                Console.WriteLine($"Amount : {expense.Amount}");
                Console.WriteLine($"Category : {expense.Category}");
                Console.WriteLine($"Description : {expense.Description}");
                Console.WriteLine("-----------------------------------------------");
            }
        }


        public static void ListSpecific(string category)
        {
            Console.WriteLine($"------------------- {category} Expenses ------------------");
            foreach (var expense in Expenses)
            {
                if(expense.Category == category)
                {   
                    Console.WriteLine($"ID : {expense.ID}");
                    Console.WriteLine($"Date : {expense.Date}");
                    Console.WriteLine($"Amount : {expense.Amount}");
                    Console.WriteLine($"Category : {expense.Category}");
                    Console.WriteLine($"Description : {expense.Description}");
                    Console.WriteLine("-----------------------------------------------");
                }
            }
        }

        internal static void AddExpence()
        {
            int day;
            int month;
            int year;
            Console.Write("Enter The Day : ");
            day = int.Parse(Console.ReadLine());

            Console.Write("Enter The month : ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Enter The year : ");
            year = int.Parse(Console.ReadLine());

            Console.Write("Enter Category : ");
            string category = Console.ReadLine();

            Console.Write("Enter Amount : ");
            decimal amount = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Description : ");
            string description = Console.ReadLine();

            Expense expense = new Expense(new DateTime(year, month, day), amount, category, description);

            Expenses.Add(expense);
            Console.WriteLine($"---------------- New expense Added! -----------------");
        }

        internal static void ViewTotalExpensesByCategory()
        {
            Console.Write("enter category name : ");
            string categoryName = Console.ReadLine();

            Expense.ListSpecific(categoryName);
        }

        internal static void ViewSpecificExpense(DateTime dateTime)
        {
            foreach (var expense in Expenses)
            {
                if (expense.Date == dateTime)
                {
                    Console.WriteLine($"ID : {expense.ID}");
                    Console.WriteLine($"Date : {expense.Date}");
                    Console.WriteLine($"Amount : {expense.Amount}");
                    Console.WriteLine($"Category : {expense.Category}");
                    Console.WriteLine($"Description : {expense.Description}");
                    Console.WriteLine("-----------------------------------------------");
                }
            }
        }
    }
}
