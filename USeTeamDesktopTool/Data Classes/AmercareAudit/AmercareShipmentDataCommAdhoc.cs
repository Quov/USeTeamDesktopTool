using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USeTeamDesktopTool.Data_Classes.AmercareAudit
{
    public class AmercareShipmentDataCommAdhoc
    {
        public List<EvolveShipmentHeader> AllShipments { get; set; }
        public AmercareShipmentDataCommAdhoc()
        {
            AllShipments = new List<EvolveShipmentHeader>();
        }
    }
    public class EvolveShipmentHeader
    {
        public int FileNo { get; set; }
        public List<EvolveShipmentCI> AllInvoices { get; set; }
        public EvolveShipmentHeader()
        {
            AllInvoices = new List<EvolveShipmentCI>();
        }
    }
    public class EvolveShipmentCI
    {
        public List<EvolveCILine> AllLines { get; set; }
        public string InvoiceNumber { get; set; }
        public string CIPONumber { get; set; }
        public string Desc1Ci { get; set; }
        public string BL { get; set; }
        public string Container { get; set; }
        public EvolveShipmentCI()
        {
            AllLines = new List<EvolveCILine>();
        }
    }
    public class EvolveCILine
    {
        public int LineNo { get; set; }
        public string PartNumber { get; set; }
        public string LinePONumber { get; set; }
        public string ContainerNumber { get; set; }
    }
}
