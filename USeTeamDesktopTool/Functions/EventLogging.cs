using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USeTeamDesktopTool.Data_Classes;

namespace USeTeamDesktopTool.Functions
{
    public class EventLogging
    {
        public void RecordEvent(string fileLoc, string eventDesc, DateTime eventTime, string errorType)
        {
            String fileContents = File.ReadAllText(fileLoc);
            List<LoggedItems> logItems = new List<LoggedItems>();
            logItems = JsonConvert.DeserializeObject<List<LoggedItems>>(fileContents);
            if (logItems == null)
                logItems = new List<LoggedItems>();
            LoggedItems newItem = new LoggedItems();
                newItem.Type = errorType;
                newItem.Desc = eventDesc;
                newItem.DateTime = DateTime.Now;
            logItems.Add(newItem);
            var convertedJson = JsonConvert.SerializeObject(logItems, Formatting.Indented);

            System.IO.File.WriteAllText(fileLoc, convertedJson);
        }

        public string GetAppDataFilePath()
        {
            string filePathName = @"S:\US_Brokerage\EDI\USeTeamDesktopTool\Data\AppData.json";
            return filePathName;
        }

        public string GetAppLogFilePathName()
        {
            string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Data\Log\";
            DateTime today = System.DateTime.Now;
            string fileName = "AppLog-" + today.ToString("yyyy'-'MM'-'dd") + ".json";
            string filePathWithName = filePath + fileName;
            if(!Directory.Exists(filePath))
            {
                System.IO.Directory.CreateDirectory(filePath);
            }

            if(File.Exists(filePathWithName))
            {
                return filePathWithName;
            }
            else
            {
                using (var tw = new StreamWriter(filePathWithName, true))
                {
                    tw.Close();
                }
                return filePathWithName;
            }
        }
    }
}
