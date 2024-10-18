using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Chat_Room_Notifications
{
    public class User
    {
        
        public void SendedMessage(string Message)
        {
            Console.WriteLine($"{Message}");
        }
    }
}
