using System.IO;

namespace Interfaces_and_Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log("Error: ", message);
        }

        public void LogInfo(string message)
        {
            Log("INFO: ", message);
        }

        private void Log(string messageType, string message)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + message);
            }
        }
    }
}
