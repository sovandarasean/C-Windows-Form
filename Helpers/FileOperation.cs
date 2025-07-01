using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Sales_Reporting_Tool.Helpers
{
    public static class FileOperation
    {
        public static void AppendToLog(string message)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string logsFolder = Path.Combine(currentDirectory, "logs");
            string filePath = Path.Combine(logsFolder, "log.txt");

            if (!Directory.Exists(logsFolder))
            {
                Directory.CreateDirectory(logsFolder);
            }

            string textFormat = $"{DateTime.Now:dd-MM-yyyy HH:mm:ss} - {message}{Environment.NewLine}";

            File.AppendAllText(filePath, textFormat);
        }
    }
}
