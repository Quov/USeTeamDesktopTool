using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USeTeamDesktopTool.Data_Classes.AmercareAudit
{
    public class AmercareMissingShipmentData
    {
        public List<SingleMissingShipment> AllMissingRecords { get; set; }
        public AmercareMissingShipmentData()
        {
            AllMissingRecords = new List<SingleMissingShipment>();
        }
    }

    public class SingleMissingShipment
    {
        public string Bl { get; set; }
        public string Vessel { get; set; }
        public string Voyage { get; set; }
        public string Pol { get; set; }
        public string Pod { get; set; }
        public DateTime? CarrierFNDEta { get; set; }
        public string OoclProductCode { get; set; }
        public string OoclContainer { get; set; }
        public string OoclPONumber { get; set; }
        //public List<MissingLines> AllLines { get; set; }
        public string ShipmentErrorDesc { get; set; }
        //public SingleMissingShipment()
        //{
        //    AllLines = new List<MissingLines>();
        //}
        public int LiiFileNo { get; set; }
        public DateTime? LiiCrAccepted { get; set; }
        public string LiiProductCode { get; set; }
        public string LiiContainer { get; set; }
        public string LiiPONumber { get; set; }
        public string LineErrorDesc { get; set; }
    }

    //public class MissingLines
    //{
    //    public string Container { get; set; }
    //    public string ProductCode { get; set; }
    //    public string PONumber { get; set; }
    //    public string LineErrorDesc { get; set; }
    //}
}
