using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using USeTeamDesktopTool.Data_Classes;

namespace USeTeamDesktopTool.Functions
{
    public class JsonFunctions
    {
        public void LoadSchema(string fileLocation)
        {
            String fileContents = File.ReadAllText(fileLocation);
            List<SingleDataElement> schemaElements = new List<SingleDataElement>();
            schemaElements = JsonConvert.DeserializeObject<List<SingleDataElement>>(fileContents);

            MessageBox.Show("TEST");
        }
    }
}
