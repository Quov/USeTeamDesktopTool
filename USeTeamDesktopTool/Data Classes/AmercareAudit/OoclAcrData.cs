using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USeTeamDesktopTool.Data_Classes
{
    public class OoclAcrData
    {
        public List<SingleOoclRecord> AllOoclRecords { get; set; }
        public OoclAcrData()
        {
            AllOoclRecords = new List<SingleOoclRecord>();
        }
    }

    public class SingleOoclRecord
    {
        public string Bl { get; set; }
        public string Po { get; set; }
        public string Vessel { get; set; }
        public string Voyage { get; set; }
        public DateTime? FirstPostAdvice { get; set; }
        public string ProductCode { get; set; }
        public string Container { get; set; }
        public string Pol { get; set; }
        public string Pod { get; set; }
        public string CargoFND { get; set; }
        public DateTime? CargoFNDEta { get; set; }
        public string Carrier { get; set; }
        public DateTime? CarrierFNDEta { get; set; }
        public DateTime? PodEta { get; set; }
        public string FwBl { get; set; }
        public DateTime? DeliveredDate { get; set; }
    }
}
