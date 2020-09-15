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
    public class CanadaGooseFunction
    {
        public string GetAugmentFilePath()
        {
            string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Data\CanadaGoose\";
            DateTime today = System.DateTime.Now;
            string fileName = "CanadaGooseAugments" + ".json";
            string filePathWithName = filePath + fileName;
            if (!Directory.Exists(filePath))
            {
                System.IO.Directory.CreateDirectory(filePath);
            }

            if (File.Exists(filePathWithName))
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

        public List<SingleAugment> LoadAugments(string fileLocation)
        {
            //TODO: Add logic here to read a new format for these items
            String fileContents = File.ReadAllText(fileLocation);
            List<SingleAugment> allAugments = new List<SingleAugment>();
            allAugments = JsonConvert.DeserializeObject<List<SingleAugment>>(fileContents);

            MessageBox.Show("TEST");

            return allAugments;
        }

        public void AddAugment(string fileLoc, string augmentType, string initialValue, string finalValue)
        {
            //TODO: Add logic to save current augments in the application.
            String fileContents = File.ReadAllText(fileLoc);
            List<SingleAugment> allAugments = new List<SingleAugment>();
            allAugments = JsonConvert.DeserializeObject<List<SingleAugment>>(fileContents);
            if (allAugments == null)
                allAugments = new List<SingleAugment>();
            SingleAugment newAugment = new SingleAugment();
                newAugment.AugmentType = augmentType;
                newAugment.InitialValue = initialValue;
                newAugment.FinalValue = finalValue;
            allAugments.Add(newAugment);
            var convertedJson = JsonConvert.SerializeObject(allAugments, Formatting.Indented);

            System.IO.File.WriteAllText(fileLoc, convertedJson);
        }
    }
}
