using System;
using System.Collections.Generic;

namespace Section5_Exercises
{
    public abstract class DbConnection
    {
        private readonly string _ConnectionString;
        protected TimeSpan timer;
        public bool Connected { get; set; }
        protected List<string> _list;

        public DbConnection(string type)
        {
            if (String.IsNullOrEmpty(type))
                throw new NullReferenceException();
            else
            {
                _ConnectionString = type;
                timer = new TimeSpan(0, 10, 0);
                _list = new List<string>();
                Connected = false;
            }

        }

        public abstract string OpenConnection();
        public abstract string CloseConnection();
        public abstract string AddDbCommand(string command);

        public void PrintDB()
        {
            foreach(var db in _list)
            {
                Console.WriteLine(db);
            }
        }
    }
}


























