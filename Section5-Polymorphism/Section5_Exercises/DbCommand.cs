namespace Section5_Exercises
{
    public class DbCommand
    {
        public DbConnection DbConnectionObject;
        public DbCommand(DbConnection connection)
        {
            if (connection == null)
                throw new System.Exception("Error: Connection can't be null");
            else
                DbConnectionObject = connection;
        }

        public void Execute(string command)
        {
            if (string.IsNullOrEmpty(command))
                throw new System.Exception();
            else
            {
                DbConnectionObject.OpenConnection();
                DbConnectionObject.AddDbCommand(command);
                DbConnectionObject.PrintDB();
                DbConnectionObject.CloseConnection();
            }
        }
    }
}
