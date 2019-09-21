using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferService.UseCases.Logger
{
    public class LoggerUseCase
    {
        private readonly String directoryName = "\\Logs";
        public void WriteToFile(string message, string path = null)
        {
            if (null == path)
            {
                path = AppDomain.CurrentDomain.BaseDirectory + directoryName;
            }

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filePath = path + "\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
            if (!File.Exists(filePath))
            {
                // Create a file to write to.   
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine(message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine(message);
                }
            }
        }
    }
}
