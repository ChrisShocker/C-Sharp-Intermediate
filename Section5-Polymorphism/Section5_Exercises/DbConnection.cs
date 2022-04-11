using System;

namespace Section5_Exercise_1
{
    public abstract class DbConnection
    {
        private string _ConnectionString;
        protected TimeSpan timer;
        protected bool connected { get; set; }

        public DbConnection(string type)
        {
            if (String.IsNullOrEmpty(type))
                throw new NullReferenceException();
            else
            {
                _ConnectionString = type;
                timer = new TimeSpan(0, 10, 0);
                connected = false;
            }

        }

        public abstract string OpenConnection();
        public abstract string CloseConnection();


    }
}


























