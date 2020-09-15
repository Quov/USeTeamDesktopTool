using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USeTeamDesktopTool.Data_Classes
{
    public class MondelezPartiesAdhoc
    {
        public List<PartyItem> AllPartyItems { get; set; }

        public MondelezPartiesAdhoc()
        {
            AllPartyItems = new List<PartyItem>();
        }
    }

    public class PartyItem
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string EntryDate { get; set; }
        public string FileNo { get; set; }
        public string BrokerFiler { get; set; }
        public string EntryNo { get; set; }
        public string PortofEntry { get; set; }
        public string CustRef { get; set; }
        public string ArrivalDatePortofEntry { get; set; }
        public string ReleaseDate { get; set; }
        public string LineNo { get; set; }
        public string PartNumber { get; set; }
        public string ProductDescription { get; set; }
        public string PartyRole { get; set; }
        public string PartyName { get; set; }
        public string PartyAddressLine1 { get; set; }
        public string PartyCity { get; set; }
        public string PartyStateProvince { get; set; }
        public string PartyPostalCd { get; set; }
        public string ManufacturerName { get; set; }
        public string MasterBill { get; set; }
        public string HouseBill { get; set; }
        public string ContainerNumber { get; set; }
        public string CountryOfOrigin { get; set; }
        public string CountryOfOriginName { get; set; }

        public static PartyItem FromCsv(string csvLine)
        {
            csvLine = csvLine.Replace("\"", "");
            string[] values = csvLine.Split('|');

            PartyItem newPartyItem = new PartyItem
            {
                CustomerID = Convert.ToString(values[0]),
                CustomerName = Convert.ToString(values[1]),
                EntryDate = Convert.ToString(values[2]),
                FileNo = Convert.ToString(values[3]),
                BrokerFiler = Convert.ToString(values[4]),
                EntryNo = Convert.ToString(values[5]),
                PortofEntry = Convert.ToString(values[6]),
                CustRef = Convert.ToString(values[7]),
                ArrivalDatePortofEntry = Convert.ToString(values[8]),
                ReleaseDate = Convert.ToString(values[9]),
                LineNo = Convert.ToString(values[10]),
                PartNumber = Convert.ToString(values[11]),
                ProductDescription = Convert.ToString(values[12]),
                PartyRole = Convert.ToString(values[13]),
                PartyName = Convert.ToString(values[14]),
                PartyAddressLine1 = Convert.ToString(values[15]),
                PartyCity = Convert.ToString(values[16]),
                PartyStateProvince = Convert.ToString(values[17]),
                PartyPostalCd = Convert.ToString(values[18]),
                ManufacturerName = Convert.ToString(values[19]),
                MasterBill = Convert.ToString(values[20]),
                HouseBill = Convert.ToString(values[21]),
                ContainerNumber = Convert.ToString(values[22]),
                CountryOfOrigin = Convert.ToString(values[23]),
                CountryOfOriginName = Convert.ToString(values[24])
            };
            return newPartyItem;
        }
    }
}
