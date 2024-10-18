using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Online_Shoping_System
{
    public class Order
    {
        public delegate void OrderPlacedEventHandler(string message, string email, string phoneNumber);
        static public event OrderPlacedEventHandler OrderPlaced;

        static public void SendingNotification(string message, string email, string phoneNumber)
        {
            OrderPlaced?.Invoke(message, email, phoneNumber);
        }
    }
}
