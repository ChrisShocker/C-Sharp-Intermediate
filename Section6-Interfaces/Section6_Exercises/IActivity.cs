
using System;
using System.Collections.Generic;

namespace Section6_Exercises
{
    public interface IActivity
    {
        void Execute();
    }

    public interface IWorkFLow
    {
        void Add(IActivity activity);
        public IEnumerable<IActivity> GetTasks();
    }

    public class WorkFlow : IWorkFLow
    {
        private readonly IList<IActivity> _activities;
        public WorkFlow()
        {
            _activities = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
           _activities.Add(activity);    
        }

        public IEnumerable<IActivity> GetTasks()
        {
            return _activities;
        }

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
