using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USeTeamDesktopTool.Data_Classes
{
    public class AmercareShipmentDataAdhoc
    {
        public List<SingleRecord> AllRecords { get; set; }

        public AmercareShipmentDataAdhoc()
        {
            AllRecords = new List<SingleRecord>();
        }
    }

    public class SingleRecord
    {
        public int FileNo { get; set; }
        public string EntryNo { get; set; }
        public string HouseSCAC { get; set; }
        public string HouseBL { get; set; }
        public string MasterSCAC { get; set; }
        public string MasterBL { get; set; }

        public static SingleRecord FromCsv(string csvLine)
        {
            csvLine = csvLine.Replace("\"", "");

            string[] values = csvLine.Split(',');

            string houseScac = "";
            string houseBill = "";

            if (!string.IsNullOrEmpty(values[2].ToString()))
            {
                houseScac = Convert.ToString(values[2]);
            }
            if (!string.IsNullOrEmpty(values[3].ToString()))
            {
                houseBill = Convert.ToString(values[3]);
            }

            SingleRecord newRecord = new SingleRecord
            {
                FileNo = Convert.ToInt32(values[0]),
                EntryNo = Convert.ToString(values[1]),
                HouseSCAC = houseScac,
                HouseBL = houseBill,
                MasterSCAC = Convert.ToString(values[4]),
                MasterBL = Convert.ToString(values[5])

            };
            return newRecord;
        }
    }
}
