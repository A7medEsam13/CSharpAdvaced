using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Events
{
    internal class App
    {
        static public void Run()
        {
            var TempWarning = new TempratureSensor();
            TempWarning.TempratureEceeded += TempWarning_TempratureEceeded;
            TempWarning.TempratureBelow += TempWarning_TempratureBelow;
            Console.Write("Enter the temprature : ");
            int temp = int.Parse(Console.ReadLine());
            TempWarning.Limited(temp);
        }

        private static void TempWarning_TempratureBelow(int Temprature)
        {
            Console.WriteLine("Temprature is Under than 100 deg");
        }

        static private void TempWarning_TempratureEceeded(int Temprature)
        {
            Console.WriteLine("Warning!....Temprature is over than 100 deg !");
        }
    }
}
