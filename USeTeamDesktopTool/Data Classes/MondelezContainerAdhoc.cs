using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USeTeamDesktopTool.Data_Classes
{
    public class MondelezContainerAdhoc
    {
        public List<ContainerItem> AllContainerItems { get; set; }

        public MondelezContainerAdhoc()
        {
            AllContainerItems = new List<ContainerItem>();
        }
    }

    public class ContainerItem
    {
        public string FileNo { get; set; }
        public string TransModeDesc { get; set; }
        public string MasterBill { get; set; }
        public string PrimaryHouseBill { get; set; }
        public string Vessel { get; set; }
        public string VoyageFlight { get; set; }
        public string ContainerNo { get; set; }
        public string Description1 { get; set; }
        public string DescOfGoods { get; set; }
        public string PortOfLadingName { get; set; }
        public string PortOfUnladingName { get; set; }
        public string FirstCustRef { get; set; }
        public string ISFEstimate { get; set; }
        public string ArrivalDatePOE { get; set; }
        public string ReleaseDate { get; set; }
        public string Carrier { get; set; }
        public string CarrierName { get; set; }
        public string ContainerType { get; set; }
        public string ContainerSize { get; set; }
        public string ShipperName { get; set; }
        public string COO { get; set; }
        public string Filer { get; set; }
        public string EntryNo { get; set; }
        public string POEName { get; set; }


        public static ContainerItem FromCsv(string csvLine)
        {
            csvLine = csvLine.Replace("\"", "");
            string[] values = csvLine.Split('|');

            ContainerItem newContainerItem = new ContainerItem
            {
                FileNo = Convert.ToString(values[0]),
                TransModeDesc = Convert.ToString(values[1]),
                MasterBill = Convert.ToString(values[2]),
                PrimaryHouseBill = Convert.ToString(values[3]),
                Vessel = Convert.ToString(values[4]),
                VoyageFlight = Convert.ToString(values[5]),
                ContainerNo = Convert.ToString(values[6]),
                Description1 = Convert.ToString(values[7]),
                DescOfGoods = Convert.ToString(values[8]),
                PortOfLadingName = Convert.ToString(values[9]),
                PortOfUnladingName = Convert.ToString(values[10]),
                FirstCustRef = Convert.ToString(values[11]),
                ISFEstimate = Convert.ToString(values[12]),
                ArrivalDatePOE = Convert.ToString(values[13]),
                ReleaseDate = Convert.ToString(values[14]),
                Carrier = Convert.ToString(values[15]),
                CarrierName = Convert.ToString(values[16]),
                ContainerType = Convert.ToString(values[17]),
                ContainerSize = Convert.ToString(values[18]),
                ShipperName = Convert.ToString(values[19]),
                COO = Convert.ToString(values[20]),
                Filer = Convert.ToString(values[21]),
                EntryNo = Convert.ToString(values[22]),
                POEName = Convert.ToString(values[23])
            };
            return newContainerItem;
        }
    }
}
