using System;
using System.Collections.Generic;

namespace Section5_Exercises
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection() : base("SQL")
        {
        }

        public override string OpenConnection()
        {
            if (Connected == false)
            {
                Console.WriteLine("SQL Connection Opened");
                Console.WriteLine("It is now {0}", DateTime.Now);
                Console.WriteLine("Connection will remain open until {0}", DateTime.Now.Add(timer));

                Connected = true;
                return "SQL Opened";
            }
            else
            {
                Console.WriteLine("Open Connection Failed: A Connection is already Opened");
                return "Existing connection already exists";
            }
        }
        public override string CloseConnection()
        {
            if (Connected == true)
            {
                Console.WriteLine("SQL Connection Closed");
                Connected = false;
                return "SQL Closed";
            }

            else
            {
                Console.WriteLine("Error: Connection already closed");
                return "Connection already closed";
            }
        }

        public override string AddDbCommand(string command)
        {
            _list.Add(command);
            return "Command added to SQL Db";
        }
    }
}


























