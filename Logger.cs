using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new object();
        private readonly string _logFilePath;

        private Logger()
        {
            _logFilePath = "log.txt";
            File.WriteAllText(_logFilePath, "Log file initialized.\n");
        }

        public static Logger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                    return _instance;
                }
            }
        }

        public void Log(string message)
        {
            string logMessage = $"{DateTime.Now}: {message}\n";
            File.AppendAllText(_logFilePath, logMessage);
            Console.WriteLine("Log message: " + logMessage);
        }

    }
}
