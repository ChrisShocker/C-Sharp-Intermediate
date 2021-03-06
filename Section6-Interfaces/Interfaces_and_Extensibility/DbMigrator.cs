using System;

namespace Interfaces_and_Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration has started: " +DateTime.Now);
        }
    }
}
