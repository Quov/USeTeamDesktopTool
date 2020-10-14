using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USeTeamDesktopTool.Data_Classes.AmercareAudit
{
    public class AmercareTableView
    {
        public List<LineItems> AllLines { get; set; }
        public AmercareTableView()
        {
            AllLines = new List<LineItems>();
        }
    }

    public class LineItems
    {
        public string Bl { get; set; }
        public string Vessel { get; set; }
        public string Voyage { get; set; }
        public string Pol { get; set; }
        public string Pod { get; set; }
        public DateTime? CarrierFNDEta { get; set; }
        public string ShipmentErrorDesc { get; set; }
        public string Container { get; set; }
        public string ProductCode { get; set; }
        public string PONumber { get; set; }
        public string LineErrorDesc { get; set; }
    }
}
