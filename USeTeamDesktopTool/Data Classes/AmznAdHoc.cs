using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USeTeamDesktopTool.Data_Classes
{
    public class AmznAdHoc
    {
        public List<AdHocItem> AllAdhocItems { get; set; }

        public AmznAdHoc()
        {
            AllAdhocItems = new List<AdHocItem>();
        }
    }

    public class AdHocItem
    {
        public string FileNo { get; set; }
        public int ClientNo { get; set; }
        public string CommInvNo { get; set; }
        public int CommInvLineNo { get; set; }
        public double CommQty { get; set; }
        public string Uom { get; set; }
        public string PartNo { get; set; }
        public double ForeignValue { get; set; }
        public double AssistValue { get; set; }
        public string FileLogged { get; set; }
        public string CR { get; set; }
        public string ES { get; set; }

        public static AdHocItem FromCsv(string csvLine)
        {
            csvLine = csvLine.Replace("\"", "");
            string[] values = csvLine.Split('|');

            string FileLoggedFinal = "0";
            string CRFinal = "0";
            string ESFinal = "0";
            if (values[09] != null && values[09].Length > 0)
            {
                FileLoggedFinal = Convert.ToString(values[09]);
            }
            if (values[10] != null && values[10].Length > 0)
            {
                CRFinal = Convert.ToString(values[10]);
            }
            if (values[11] != null && values[11].Length > 0)
            {
                ESFinal = Convert.ToString(values[11]);
            }


            AdHocItem newAdHocItem = new AdHocItem
            {
                FileNo = Convert.ToString(values[0]),
                ClientNo = Convert.ToInt32(values[1]),
                CommInvNo = Convert.ToString(values[2]),
                CommInvLineNo = Convert.ToInt32(values[3]),
                CommQty = Convert.ToDouble(values[4]),
                Uom = Convert.ToString(values[5]),
                PartNo = Convert.ToString(values[6]),
                ForeignValue = Convert.ToDouble(values[7]),
                AssistValue = Convert.ToDouble(values[8]),
                FileLogged = FileLoggedFinal,
                CR = CRFinal,
                ES = ESFinal
                //FileLogged = Convert.ToString(values[9]),
                //CR = Convert.ToString(values[10]),
                //ES = Convert.ToString(values[11])
            };
            return newAdHocItem;
        }
    }
}
