using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USeTeamDesktopTool.Data_Classes
{
    public class MondelezOceanReport
    {
        public List<OceanReportRecord> AllRecords { get; set; }

        public MondelezOceanReport()
        {
            AllRecords = new List<OceanReportRecord>();
        }
    }

    public class OceanReportRecord
    {
        public string BrokerReferenceNumber { get; set; }
        public string ModeOfTransportationDescription { get; set; }
        public string MasterBills { get; set; }
        public string HouseBillNumbers { get; set; }
        public string VesselName { get; set; }
        public string VoyageFlightNumber { get; set; }
        public List<string> ContainerNumbers { get; set; }
        public List<string> MerchandiseDescription { get; set; }
        public string PortOfLoad { get; set; }
        public string PortOfDischarge { get; set; }
        public List<string> CustomerRefs { get; set; }
        public string LatestComment { get; set; }
        public string DONumber { get; set; }
        public string InlandCarrierName { get; set; }
        public string SailDate { get; set; }
        public string POEEstimatedArrivalDate { get; set; }
        public string CustomsReleaseDate { get; set; }
        public string Consignee { get; set; }
        public string Carrier { get; set; }
        public string CarrierName { get; set; }
        public string Shipper { get; set; }
        public string OriginCountry { get; set; }
        public string EquipmentTypeSize { get; set; }
        public string ArrivalWeek { get; set; }
        public string OffTerminalFreeTime { get; set; }
        public string FileNo { get; set; }
        public string ContainerString { get; set; }
        public string CustomerRefString { get; set; }

        public string MerchandiseDescriptionString { get; set; }
    }
}
