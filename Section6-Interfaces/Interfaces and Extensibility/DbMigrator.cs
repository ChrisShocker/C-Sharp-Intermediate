using System;

namespace Interfaces_and_Extensibility
{
    public class DbMigrator
    {
        public void Migrate()
        {
            Console.WriteLine("Migration started at {0}", DateTime.Now);
        }
    }
}
