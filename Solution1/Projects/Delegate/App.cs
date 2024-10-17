using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Delegate
{
    public class App
    {
        public class employee 
        {
            public string Name {  get; set; }
            public int BasicSalary {  get; set; }
            public int Deductions {  get; set; }
            public int Bonus {  get; set; }
        }

        delegate int CalculateDelegate(int num1, int num2);
        static public void Run()
        {
            List<employee> employees = new();
            for(var i = 0; i < 100; i++)
            {
                employees.Add(new employee
                {
                    Name = $"Employee {i}",
                    BasicSalary=Random.Shared.Next(1000 , 5001),
                    Deductions=Random.Shared.Next(0 , 501),
                    Bonus=Random.Shared.Next(0 ,1001)

                });
            }
            CalculateSalaries(employees);
            
        }

        private static void CalculateSalaries(List<employee> employees)
        {
            foreach(var i in employees)
            {
                int salary = i.BasicSalary - i.Deductions + i.Bonus;
                Console.WriteLine($"Salary for employee'{i.Name}' = {salary}");
            }
        }

        static void Calculate(int num1, int num2, CalculateDelegate dlg)
        {
            int result = dlg(num1,num2);
            
            Console.WriteLine($"Result = {result}");
        }

       static public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
       static public int Substract(int num1, int num2)
        {
            return num1 - num2;
        }
       static public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
       static public int Division(int num1, int num2)
        {
            return num1 / num2;
        }

    }
}
