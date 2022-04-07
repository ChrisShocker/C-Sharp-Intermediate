using System;

namespace StopWatch
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var watch = new Watch();
            watch.Start();
            watch.Stop();
            watch.Start();
            watch.Stop();
            watch.Start();
            watch.Stop();
            watch.Start();
            watch.Stop();
        }
    }
}
