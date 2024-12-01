using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Expense_Tracker
{
    public class App
    {
        public static void Run()
        {
            while(true)
            {
                Console.WriteLine("Expense Tracker");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. Delete Expense");
                Console.WriteLine("4. View Reports");
                Console.WriteLine("5. Add Category");
                Console.WriteLine("6. Exit");
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                    Expense.AddExpence();
                else if (choose == 2)
                    Expense.ListAllExpenses();
                else if (choose == 3)
                {
                    Console.Write("Enter Id : ");
                    int id = int.Parse(Console.ReadLine());
                    Expense.DeleteExpense(id);
                }
                    
                else if (choose == 4)
                {
                    Console.WriteLine("1. View Total Expenses By Category.");
                    Console.WriteLine("2. View Expenses For a specific Time.");
                    int choose1 = int.Parse(Console.ReadLine());
                    if (choose1 == 1)
                        Expense.ViewTotalExpensesByCategory();
                    else if (choose1 == 2)
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

                        Expense.ViewSpecificExpense(new DateTime(year, month, day));
                    }
                }
                else if (choose == 5)
                {
                    AddCategory();
                }
                else if (choose == 6)
                    break;

            }
        }


        public static void AddCategory()
        {
            int id;
            string name;
            Console.Write("Enter Category ID : ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Category Name : ");
            name = Console.ReadLine();

            Category category = new Category(id, name);
            category.Categories.Add(category);

        }
    }
}
