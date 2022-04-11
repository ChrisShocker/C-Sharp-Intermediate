using System;

namespace Interface_Polymorhpism
{
    public class SMSNotification : INotifier
    {
        public void Send(Message message)
        {
            Console.WriteLine("SMS message sent");
        }
    }
}
