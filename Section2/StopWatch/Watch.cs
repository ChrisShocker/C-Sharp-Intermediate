using System;

namespace StopWatch
{
    internal partial class Program
    {
        public class Watch
        {
            private TimeSpan _totalTime;
            private bool _isRunning;

            public TimeSpan Start()
            {
                if (!_isRunning)
                {
                    DateTime _startTime = DateTime.Now;
                    Console.WriteLine("Stop watch started, the current timer is: {0}", _totalTime);
                    _isRunning = true;
                    return _totalTime += (DateTime.Now - _startTime);
                }
                else
                    throw new InvalidOperationException("Can't start twice");
            }


            public TimeSpan Stop()
            {
                _isRunning = false;
                Console.WriteLine("Stopwatch stopped, the current timer is: {0} ", _totalTime);
                return _totalTime;
            }

        }
    }
}
