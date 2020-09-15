using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USeTeamDesktopTool.Data_Classes
{
    public class CanadaGooseModel
    {
        public List<CanadaGooseHeader> CGHeader { get; set; }
        public List<CanadaGooseSingleLine> AllCGLines { get; set; }

        public CanadaGooseModel()
        {
            CGHeader = new List<CanadaGooseHeader>();
            AllCGLines = new List<CanadaGooseSingleLine>();
        }
    }

    public class CanadaGooseHeader
    {
        public string ShipmentNo { get; set; }
        public string PapsNo { get; set; }
        public string TermsOfSale { get; set; }
        public string PickupDate { get; set; }
        public string CurrOfSale { get; set; }
        public string CountryOfOrigin { get; set; }
        public string ProvOfOrigin { get; set; }
        public string EntryPort { get; set; }
        public string ExitPort { get; set; }
        public decimal? Cartons { get; set; }
        public decimal? Skids { get; set; }
        public decimal? GrossWgt { get; set; }
        public string GrossWgtUom { get; set; }
        public decimal? SubTotal { get; set; }
        public string SubCurr { get; set; }
        public string ExpName { get; set; }
        public string GSTNumber { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string StateProv { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone1 { get; set; }
        public string ContactName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string ConsigneeName { get; set; }
        public string FederalIDNo { get; set; }
        public string Address12 { get; set; }
        public string City2 { get; set; }
        public string StateProv2 { get; set; }
        public string Zip2 { get; set; }
        public string Country2 { get; set; }
        public string ShipRef1 { get; set; }
        public string ShipRef2 { get; set; }
        public string ShipRef3 { get; set; }
        public string ShipRef4 { get; set; }
        public string InvNo { get; set; }
        public string BuyerName { get; set; }
        public string Address13 { get; set; }
        public string City3 { get; set; }
        public string StateProv3 { get; set; }
        public string Zip3 { get; set; }
        public string Country3 { get; set; }
        public string SellerName { get; set; }
        public string Address14 { get; set; }
        public string City4 { get; set; }
        public string StateProv4 { get; set; }
        public string Zip4 { get; set; }
        public string Country4 { get; set; }

        public static CanadaGooseHeader FromCsv(string csvLine)
        {
            //string sep = "\t";

            csvLine = csvLine.Replace("\"", "");
            string[] headerValues = csvLine.Split('\t');

            Decimal? carton = null;
            Decimal? skids = null;
            Decimal? grossWgt = null;
            Decimal? subTotal = null;

            if (headerValues[9] != null && headerValues[9].Length > 0)
            {
                carton = Convert.ToDecimal(headerValues[9]);
            }
            if (headerValues[10] != null && headerValues[10].Length > 0)
            {
                skids = Convert.ToDecimal(headerValues[10]);
            }
            if (headerValues[11] != null && headerValues[11].Length > 0)
            {
                grossWgt = Convert.ToDecimal(headerValues[11]);
            }
            if (headerValues[13] != null && headerValues[13].Length > 0)
            {
                subTotal = Convert.ToDecimal(headerValues[13]);
            }

            CanadaGooseHeader newHeader = new CanadaGooseHeader
            {
                ShipmentNo = headerValues[0],
                PapsNo = headerValues[1],
                TermsOfSale = headerValues[2],
                PickupDate = headerValues[3],
                CurrOfSale = headerValues[4],
                CountryOfOrigin = headerValues[5],
                ProvOfOrigin = headerValues[6],
                EntryPort = headerValues[7],
                ExitPort = headerValues[8],
                Cartons = carton,
                Skids = skids,
                GrossWgt = grossWgt,
                GrossWgtUom = headerValues[12],
                SubTotal = subTotal,
                SubCurr = headerValues[14],
                ExpName = headerValues[15],
                GSTNumber = headerValues[16],
                Address1 = headerValues[17],
                City = headerValues[18],
                StateProv = headerValues[19],
                Zip = headerValues[20],
                Country = headerValues[21],
                Phone1 = headerValues[22],
                ContactName = headerValues[23],
                Position = headerValues[24],
                Email = headerValues[25],
                Phone2 = headerValues[26],
                Fax = headerValues[27],
                ConsigneeName = headerValues[28],
                FederalIDNo = headerValues[29],
                Address12 = headerValues[30],
                City2 = headerValues[31],
                StateProv2 = headerValues[32],
                Zip2 = headerValues[33],
                Country2 = headerValues[34],
                ShipRef1 = headerValues[35],
                ShipRef2 = headerValues[36],
                ShipRef3 = headerValues[37],
                ShipRef4 = headerValues[38],
                InvNo = headerValues[39],
                BuyerName = headerValues[40],
                Address13 = headerValues[41],
                City3 = headerValues[42],
                StateProv3 = headerValues[43],
                Zip3 = headerValues[44],
                Country3 = headerValues[45],
                SellerName = headerValues[46],
                Address14 = headerValues[47],
                City4 = headerValues[48],
                StateProv4 = headerValues[49],
                Zip4 = headerValues[50],
                Country4 = headerValues[51]
            };

            return newHeader;
        }       
    }

    public class CanadaGooseSingleLine
    {
        public string TransNo { get; set; }
        public int Line { get; set; }
        public string SKU { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public decimal? QtyShip { get; set; }
        public string InvoiceUOM { get; set; }
        public decimal? UnitPrice { get; set; }
        public string UnitPriceCurr { get; set; }
        public decimal? TotalLinePrice { get; set; }
        public string LineLevelDis { get; set; }
        public decimal? UnitNetWght { get; set; }
        public string WghtUOM { get; set; }
        public string CtryofOrgFinGood { get; set; }
        public string ProdName { get; set; }
        public string ProdAddress { get; set; }
        public string ProdCity { get; set; }
        public string ProdState { get; set; }
        public string ProdCtry { get; set; }
        public string ProdPostCdeZip { get; set; }
        public string HTS { get; set; }
        public string DangerousGoodsDesc { get; set; }
        public string NaftaPref { get; set; }
        public string NaftaProd { get; set; }
        public string NaftaCost { get; set; }
        public string FDAProductCode { get; set; }
        public string FCCId { get; set; }
        public string DFAITTariff { get; set; }
        public string USStatisticalCode { get; set; }
        public string AccompanyingTariff { get; set; }
        public string CottonFee { get; set; }
        public string ReportQty1 { get; set; }
        public string ReportQtyUOM1 { get; set; }
        public string BindingRuling { get; set; }
        public string TextileDec { get; set; }
        public string FCC { get; set; }
        public string SWPM { get; set; }
        public string TSCA { get; set; }
        public string FDA { get; set; }
        public string Denim { get; set; }
        public string Footwear { get; set; }
        public string FW { get; set; }
        public string TariffTretmt { get; set; }
        public string ReportQty2 { get; set; }
        public string ReportQtyUOM2 { get; set; }
        public string FabricCtryOrg { get; set; }
        public string FabricCtryOrg2 { get; set; }
        public string FabricCtryOrg3 { get; set; }
        public string YarnCtryOrg { get; set; }
        public string YarnCtryOrg2 { get; set; }
        public string YarnCtryOrg3 { get; set; }
        public string FibreCtryOrg { get; set; }
        public string FibreCtryOrg2 { get; set; }
        public string FibreCtryOrg3 { get; set; }
        public string SME { get; set; }
        public string InvNo { get; set; }
        public string MID { get; set; }
        public string MfgName { get; set; }
        public string MfgStreet { get; set; }
        public string MfgCity { get; set; }
        public string MfgStateProv { get; set; }
        public string MfgPostal { get; set; }
        public string MfgCountry { get; set; }
        public string VisaNo { get; set; }
        public string VisaExpDte { get; set; }


        public static CanadaGooseSingleLine FromCsv(string csvLine)
        {
            csvLine = csvLine.Replace("\"", "");
            string[] values = csvLine.Split('\t');

            Decimal? qtyShip = null;
            Decimal? unitPrice = null;
            Decimal? totalLinePrice = null;
            Decimal? unitNetWeight = null;

            if (values[5] != null && values[9].Length > 0)
            {
                qtyShip = Convert.ToDecimal(values[9]);
            }
            if (values[7] != null && values[7].Length > 0)
            {
                unitPrice = Convert.ToDecimal(values[7]);
            }
            if (values[9] != null && values[9].Length > 0)
            {
                totalLinePrice = Convert.ToDecimal(values[9]);
            }
            if (values[11] != null && values[11].Length > 0)
            {
                unitNetWeight = Convert.ToDecimal(values[11]);
            }

            CanadaGooseSingleLine newEntry = new CanadaGooseSingleLine
            {
                TransNo = values[0],
                Line = Convert.ToInt32(values[1]),
                SKU = values[2],
                Description1 = values[3],
                Description2 = values[4],
                QtyShip = qtyShip,
                InvoiceUOM = values[6],
                UnitPrice = unitPrice,
                UnitPriceCurr = values[8],
                TotalLinePrice = totalLinePrice,
                LineLevelDis = values[10],
                UnitNetWght = unitNetWeight,
                WghtUOM = values[12],
                CtryofOrgFinGood = values[13],
                ProdName = values[14],
                ProdAddress = values[15],
                ProdCity = values[16],
                ProdState = values[17],
                ProdCtry = values[18],
                ProdPostCdeZip = values[19],
                HTS = values[20],
                DangerousGoodsDesc = values[21],
                NaftaPref = values[22],
                NaftaProd = values[23],
                NaftaCost = values[24],
                FDAProductCode = values[25],
                FCCId = values[26],
                DFAITTariff = values[27],
                USStatisticalCode = values[28],
                AccompanyingTariff = values[29],
                CottonFee = values[30],
                ReportQty1 = values[31],
                ReportQtyUOM1 = values[32],
                BindingRuling = values[33],
                TextileDec = values[34],
                FCC = values[35],
                SWPM = values[36],
                TSCA = values[37],
                FDA = values[38],
                Denim = values[39],
                Footwear = values[40],
                FW = values[41],
                TariffTretmt = values[42],
                ReportQty2 = values[43],
                ReportQtyUOM2 = values[44],
                FabricCtryOrg = values[45],
                FabricCtryOrg2 = values[46],
                FabricCtryOrg3 = values[47],
                YarnCtryOrg = values[48],
                YarnCtryOrg2 = values[49],
                YarnCtryOrg3 = values[50],
                FibreCtryOrg = values[51],
                FibreCtryOrg2 = values[52],
                FibreCtryOrg3 = values[53],
                SME = values[54],
                InvNo = values[55],
                MID = values[56],
                MfgName = values[57],
                MfgStreet = values[58],
                MfgCity = values[59],
                MfgStateProv = values[60],
                MfgPostal = values[61],
                MfgCountry = values[62]
                //,
                //VisaNo = values[63],
                //VisaExpDte = values[64]
            };

            return newEntry;
        }

    }
}
