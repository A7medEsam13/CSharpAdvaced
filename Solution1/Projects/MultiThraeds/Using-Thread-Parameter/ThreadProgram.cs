using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.MultiThraeds.Using_Thread_Parameter
{
    public static class ThreadProgram
    {
        public static void Run()
        {
            string str = "hello i'm a thread :)";
            Thread thread = new Thread(() =>
            {
                Console.WriteLine(str);
            });
            thread.Start();
            thread.IsBackground = true; 
        }

    }
}
