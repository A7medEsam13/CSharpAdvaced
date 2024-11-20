using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Operator_Overloading
{
    public class status
    {
        public int StatusLevel;
    
        public status() { }
        public status(int level) 
        {
            StatusLevel = level;
        }

        public static bool operator true(status status)
        {
            bool result;
            _ = (status.StatusLevel >= 50) ? result = true : result = false;
            return result;
        }
        public static bool operator false(status status)
        {
            bool result;
            _ = (status.StatusLevel >= 50) ? result = true : result = false;
            return result;
        }

    }
    
        
}
