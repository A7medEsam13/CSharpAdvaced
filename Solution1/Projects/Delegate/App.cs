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
        public delegate bool ShouldCalculate(employee emloyees);

        
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
            CalculateSalaries(employees, e => e.BasicSalary <= 2000);
            
        }

        private static void CalculateSalaries(List<employee> employees, ShouldCalculate Predict)
        {
            foreach (var i in employees)
            {
                if (Predict(i))
                {
                    int salary = i.BasicSalary - i.Deductions + i.Bonus;
                    Console.WriteLine($"Total Salary for employee'{i.Name}' whith salary {i.BasicSalary} = {salary}");
                }
            }
        }
       

    }
}
