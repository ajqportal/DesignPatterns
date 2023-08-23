using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Singleton.Loggers
{
    internal sealed class Logger
    {
        public static Logger _instance = null;
        private static readonly object lockObject = new object(); // Threadsafe locking

        private Logger() { }

        public static Logger Instance
        {
            get
            {
                if(_instance is null)
                {
                    lock(lockObject)
                    {
                        if(_instance is null)
                        {
                            _instance = new Logger();
                        }
                    }
                }
                return _instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"[Log] {DateTime.Now}: {message}");
        }
    }
}
