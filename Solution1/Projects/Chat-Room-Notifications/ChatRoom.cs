using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Chat_Room_Notifications
{
    public class ChatRoom
    {
        public string Message;

        public delegate void MessageReceivedEventHandler(string Message);
        static public event MessageReceivedEventHandler MessageReceived;
        public void SendMessage(string message)
        {
            Message = message;
            
            if(MessageReceived != null)
            {
                MessageReceived(Message);
            }
        }

        
    }
}
