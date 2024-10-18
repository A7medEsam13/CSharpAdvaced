using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Online_Shoping_System
{
    public class App
    {
        static public void Run()
        {
            Order.OrderPlaced += NotificationService.SendNotification;
            Order.SendingNotification("I miss you!", "aesam4168@gmail.com", "01556268008");
        }
    }
}
