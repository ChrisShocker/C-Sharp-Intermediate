using System;

namespace Section5_Exercises
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection() : base("Oracle")
        {

        }
        public override string OpenConnection()
        {
            if (Connected == false)
            {
                Console.WriteLine("Oracle Connection Opened");
                Console.WriteLine("It is now {0}", DateTime.Now);
                Console.WriteLine("Connection will remain open until {0}", DateTime.Now.Add(timer));
                Connected = true;
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
            if (Connected == true)
            {
                Console.WriteLine("Oracle Connection Closed");
                Connected = false;
                return "Oracle Closed";
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
            return "Command added to Oracle Db";
        }

    }
}


























