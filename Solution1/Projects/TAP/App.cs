using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace Projects.TAP
{
    public class App
    {
        public static async Task Run()
        {
            var cancellationToken = new CancellationTokenSource();
            Task task = longRunningOperation(cancellationToken.Token);

            Console.WriteLine("Press Any key to cancel...!");
            Console.ReadKey();
            cancellationToken.Cancel();
            
            Console.WriteLine("This program has been cancelled!");
            
            

        }

        private static async Task longRunningOperation(CancellationToken token)
        {
            for (int i = 0; i < 10; i++)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }

                Console.WriteLine($"{i}/10....");
                await Task.Delay(1000);
            }
        }

        
    }
}




