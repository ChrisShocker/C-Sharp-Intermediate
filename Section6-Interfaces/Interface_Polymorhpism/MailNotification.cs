using System;

namespace Interface_Polymorhpism
{
    public class MailNotification : INotifier
    {
        public void Send(Message message)
        {
            Console.WriteLine("Mail message sent");
        }
    }
}
