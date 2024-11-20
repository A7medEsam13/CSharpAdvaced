using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Operator_Overloading
{
    public static class App
    {
        public static void Run()
        {
            status status = new status(55);
            if (status)  // Should be true because 55 > 50
            {
                Console.WriteLine("Status is active");
            }
            
        }
    }
}
