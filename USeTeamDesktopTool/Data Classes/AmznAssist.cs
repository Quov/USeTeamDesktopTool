using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USeTeamDesktopTool.Data_Classes
{
    public class AmznAssist
    {
        public List<SingleAmznAssist> AllAmznList { get; set; }

        public AmznAssist()
        {
            AllAmznList = new List<SingleAmznAssist>();
        }
    }

    public class SingleAmznAssist
    {
        public string ASIN { get; set; }
        public double AssistValue { get; set; }
        public string USHTS { get; set; }

        public static SingleAmznAssist FromCsv(string csvLine)
        {
            csvLine = csvLine.Replace("\"", "");

            string[] values = csvLine.Split(',');
            SingleAmznAssist newAssist = new SingleAmznAssist
            {
                ASIN = Convert.ToString(values[0]),
                USHTS = Convert.ToString(values[1]),
                AssistValue = Convert.ToDouble(values[2])
            };
            return newAssist;
        }
    }
}
