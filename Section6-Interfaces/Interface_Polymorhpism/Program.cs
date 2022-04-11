namespace Interface_Polymorhpism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.CreateNotification(new MailNotification());
            encoder.CreateNotification(new SMSNotification());
            encoder.Encode(new Video());
        }
    }
}
