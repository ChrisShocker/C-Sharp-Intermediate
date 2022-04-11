using System;

namespace Section5_Exercise_1
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection() : base("SQL")
        {
        }

        public override string OpenConnection()
        {
            if (connected == false)
            {
                Console.WriteLine("SQL Connection Opened");
                Console.WriteLine("It is now {0}", DateTime.Now);
                Console.WriteLine("Connection will remain open until {0}", DateTime.Now.Add(timer));
                connected = true;
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
            if (connected == true)
            {
                Console.Write("SQL Connection Closed");
                connected = false;
                return "SQL Closed";
            }

            else
            {
                Console.WriteLine("Error: Connection already closed");
                return "Connection already closed";
            }
        }
    }
}


























