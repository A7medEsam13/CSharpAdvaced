using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Online_Shoping_System
{
    public class NotificationService
    {
        static public void SendNotification(string message , string email , string phoneNumber)
        {
            Console.WriteLine($"To : {email}");
            Console.WriteLine($"    {message}");
            Console.WriteLine($"00000000000000000000000000000000000000000");
            Console.WriteLine($"To : {phoneNumber}");
            Console.WriteLine($"    {message}");
        }
    }
}
