using System;

namespace Interfaces_and_Extensibility
{
    public class DbMigrator
    {
        public void Migrate()
        {
            Console.WriteLine("Migration Started at {0}", DateTime.Now);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
