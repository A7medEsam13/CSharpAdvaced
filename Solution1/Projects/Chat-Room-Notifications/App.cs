using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Chat_Room_Notifications
{
    public class App
    {
        static public void Run()
        {
            ChatRoom room = new ChatRoom();
            User user = new User();
            ChatRoom.MessageReceived += user.SendedMessage;

            user.SendedMessage("Hi, Ahmed");
        }
    }
}
