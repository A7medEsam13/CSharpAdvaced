using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Projects.MultiThraeds.App;

namespace Projects.MultiThraeds
{
    internal class App
    {

        public static void Run()
        {
            Data data = new Data();
            data.counter = 0;

            var th1 = new Thread(() => ProcessBatch1(data));
            var th2 = new Thread(() => ProcessBatch2(data));
            th1.Start();
            th2.Start();

            




        }

        public class Data
        {
            public int counter { get; set; }
        }
        private static object _lock = new();

        private static void ProcessBatch1(Data data)
        {
            //Thread.Sleep(1000);
            while(data.counter < 1000)
            {
                lock (_lock)
                {
                        Console.ForegroundColor = ConsoleColor.Green;
                        data.counter++;
                        Console.WriteLine(data.counter);
                        Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private static void ProcessBatch2(Data data)
            {
            Thread.Sleep(450);

                while (data.counter < 2000)
                {
                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    data.counter++;
                    Console.WriteLine(data.counter);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }




    }
}
