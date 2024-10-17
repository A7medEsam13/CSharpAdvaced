using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Delegate
{
    public class App
    {
        
        delegate int[] SortDeegate(int[] nums);
        
        static public void Run()
        {
            int[] nums = { 1, 5, 8, 2, 6, 4, 3, 1, 0, 5 };
            GetSorting(nums,  Sorting);
        }

        static void GetSorting(int[] nums , SortDeegate sort)
        {
            int[] n = sort(nums);
            foreach(var i in n)
            {
                Console.Write($"{i} ");
            }
        }

        
        static public int[] Sorting(int[] nums)
        {
            Array.Sort(nums);
            return nums;
        }
       

    }
}
