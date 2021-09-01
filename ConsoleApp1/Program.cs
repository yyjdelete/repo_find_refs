using System;

namespace ConsoleApp1
{
    class Program
    {
        static Microsoft.Extensions.Logging.ILogger logger;
        static void Main(string[] args)
        {
#if NET5_0
            logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel.Information);
#else
            logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel.Debug);
#endif
        }
    }
}
