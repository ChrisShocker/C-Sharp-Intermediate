
using System;

namespace Section6_Exercises
{
    public interface IActivity
    {
        void Execute();
    }

    public class UploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploaded a video");
        }
       
    }

    public class DownloadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Downloaded a video");
        }
    }

    public class Call : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Called someone");
        }
    }
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sent email to someone");
        }
    }
    public class UpdateStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Status updated");
        }
    }
}
