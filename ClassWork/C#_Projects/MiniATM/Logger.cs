using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
    using System.IO;
    using System.Threading.Tasks;

    namespace MiniATM
    {
        public static class Logger
        {
            private static string path = "log.txt";

            public static async Task Log(string message)
            {
                string logMessage = $"{DateTime.Now} - {message}\n";
                await File.AppendAllTextAsync(path, logMessage);
            }
        }
    }
}
