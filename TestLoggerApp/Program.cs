using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace TestLoggerApp
{
    class Program
    {
        static ILog log = LogManager.GetLogger("TestLoggerApp");
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            //Info Log
            for(int count=1;count<=50;count++)
            {
                log.Info(string.Format("Information Log Loop Count {0}",count));
            }
            //Debug Log
            for (int count = 1; count <= 50; count++)
            {
                log.Debug(string.Format("Debug Log Loop Count {0}", count));
            }

            //Error log
            for (int count = 1; count <= 50; count++)
            {
                log.Error(string.Format("Error Log Loop Count {0}", count));
            }
            //Fatal log
            for (int count = 1; count <= 50; count++)
            {
                log.Fatal(string.Format("FATAL Log Loop Count {0}", count));
            }
            Console.WriteLine("Completed Logging");
            Console.ReadKey();
        }
    }
}
