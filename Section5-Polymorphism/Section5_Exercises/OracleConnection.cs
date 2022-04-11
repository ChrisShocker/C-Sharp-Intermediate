using System;

namespace Section5_Exercise_1
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection() : base("Oracle")
        {

        }
        public override string OpenConnection()
        {
            if (connected == false)
            {
                Console.WriteLine("Oracle Connection Opened");
                Console.WriteLine("It is now {0}", DateTime.Now);
                Console.WriteLine("Connection will remain open until {0}", DateTime.Now.Add(timer));
                connected = true;
                return "Oracle Opened";
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
                Console.Write("Oracle Connection Closed");
                connected = false;
                return "Oracle Closed";
            }

            else
            {
                Console.WriteLine("Error: Connection already closed");
                return "Connection already closed";
            }
        }

    }
}


























