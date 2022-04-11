namespace Interfaces_and_Extensibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            var dbMigratorFile = new DbMigrator(new FileLogger(@"C:\Programming\C#\C-Sharp-Intermediate\Section6-Interfaces\Interfaces and Extensibility\log.txt"));
            dbMigrator.Migrate();
            dbMigratorFile.Migrate();
        }
    }
}
