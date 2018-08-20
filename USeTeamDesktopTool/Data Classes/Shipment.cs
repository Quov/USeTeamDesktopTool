using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace USeTeamDesktopTool.Data_Classes
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute("SHIPMENT", Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class Shipment
    {
        [XmlElement("SHIPMENT_MAIN")]
        public ShipmentMain ShipmentMain { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class ShipmentMain
    {
        [XmlElement("DASHBOARD_WORK_MGMT")]
        public DashboardWorkMgmt DashboardWorkMgmt { get; set; }
        [XmlElement("EDI_SHIPMENT_HEADER")]
        public ShipmentHeader ShipmentHeader { get; set; }
        //[XmlElement("EDI_SHIPMENT_HEADER_AUX")]
        //[XmlElement("EDI_SHIPMENT_HEADER_FLEX")]

        [XmlElement("ACTION")]
        public string action { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class DashboardWorkMgmt
    {
        [XmlElement("TRANSACTION_TYPE_CD")]
        public string TransactionTypeCd { get; set; }
        [XmlElement("PROCESS_CD")]
        public string ProcessCd { get; set; }
        [XmlElement("DATE_CREATED")]
        public string DateCreated { get; set; }
        [XmlElement("TIME_CREATED")]
        public string TimeCreated { get; set; }
        [XmlElement("CUST_NO")]
        public string CustNo { get; set; }
        [XmlElement("COMPANY_NO")]
        public string CompanyNo { get; set; }
        [XmlElement("DIVISION_NO")]
        public string DivisionNo { get; set; }
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerID { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("MASTER_BILL")]
        public string MasterBill { get; set; }
        [XmlElement("HOUSE_BILL")]
        public string HouseBill { get; set; }
        [XmlElement("SUB_BILL")]
        public string SubBill { get; set; }
        [XmlElement("SUB_SUB_BILL")]
        public string SubSubBill { get; set; }
        [XmlElement("SCAC")]
        public string Scac { get; set; }
        [XmlElement("MATCH_ENTRY")]
        public string MatchEntry { get; set; }
        [XmlElement("FILE_NO")]
        public decimal? FileNo { get; set; }
        [XmlElement("DIST_PORT_ENTRY")]
        public decimal? DistPortEntry { get; set; }
        [XmlElement("ENTRY_NO")]
        public decimal? EntryNo { get; set; }
        [XmlElement("ENTRY_TYPE")]
        public decimal? EntryType { get; set; }
        [XmlElement("MOT")]
        public decimal? Mot { get; set; }
        [XmlElement("BROKER_TEAM")]
        public string BrokerTeam { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("SCAC_HOUSE")]
        public string ScacHouse { get; set; }

        public string DateExtracted { get; set; }
        public string TimeExtracted { get; set; }
        public string DateReleased { get; set; }
        public string TimeReleased { get; set; }
        public string DateApproved { get; set; }
        public string TimeApproved { get; set; }
        public string DateRejected { get; set; }
        public string TimeRejected { get; set; }
    }

    #region Shipment Level
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class ShipmentHeader
    {
        [XmlElement("EDI_INVOICE_HEADER")]
        public InvoiceHeader[] InvoiceHeader { get; set; }
        [XmlElement("EDI_INVOICE_HEADER_FLEX")]
        public ShipmentHeaderFlex[] ShipmentHeaderFlexs { get; set; }
        [XmlElement("EDI_SHIPMENT_DATES")]
        public ShipmentDate[] ShipmentDates { get; set; }
        //[XmlElement("EDI_SHIPMENT_REFERENCE")]
        //[XmlElement("EDI_CONTAINERS")]
        [XmlElement("EDI_SHIPMENT_ID")]
        public ShipmentId[] ShipmentIds { get; set; }
        //[XmlElement("EDI_SHIPMENT_DETAIL")]

        [XmlElement("MASTER_BILL")]
        public string MasterBill { get; set; }
        [XmlElement("HOUSE_BILL")]
        public string HouseBill { get; set; }
        [XmlElement("SUB_BILL")]
        public string SubBill { get; set; }
        [XmlElement("SUB_SUB_BILL")]
        public string SubSubBill { get; set; }
        [XmlElement("MATCH_SHIPMENT")]
        public string MatchShipment { get; set; }
        [XmlElement("MATCH_ENTRY")]
        public string MatchEntry { get; set; }
        [XmlElement("SCAC")]
        public string Scac { get; set; }
        [XmlElement("CUST_NO")]
        public string CustNo { get; set; }
        [XmlElement("DATE_EST_ARRIVAL")]
        public string DateEstArrival { get; set; }
        [XmlElement("PORT_LADING")]
        public decimal? PortLading { get; set; }
        [XmlElement("DIST_PORT")]
        public decimal? DistPort { get; set; }
        [XmlElement("DIST_PORT_ENTRY")]
        public decimal? DistPortEntry { get; set; }
        [XmlElement("DESTINATION_STATE")]
        public string DestinationState { get; set; }
        [XmlElement("COUNTRY_ORIGIN")]
        public string CountryOrigin { get; set; }
        [XmlElement("COUNTRY_EXPORT")]
        public string CountryExport { get; set; }
        [XmlElement("PIECE_COUNT")]
        public decimal? PieceCount { get; set; }
        [XmlElement("UOM")]
        public string Uom { get; set; }
        [XmlElement("WEIGHT_GROSS")]
        public decimal? WeightGross { get; set; }
        [XmlElement("UOM_WEIGHT")]
        public string UomWeight { get; set; }
        [XmlElement("CARRIER")]
        public string Carrier { get; set; }
        [XmlElement("CARRIER_NAME")]
        public string CarrierName { get; set; }
        [XmlElement("VESSEL_AIRLINE_NAME")]
        public string VesselAirlineName { get; set; }
        [XmlElement("VOYAGE_FLIGHT_NO")]
        public string VoyageFlightNo { get; set; }
        [XmlElement("MANIFEST_NO")]
        public string ManifestNo { get; set; }
        [XmlElement("DESC_OF_GOODS")]
        public string DescOfGoods { get; set; }
        [XmlElement("VALUE_US")]
        public decimal? ValueUs { get; set; }
        [XmlElement("CHARGES")]
        public decimal? Charges { get; set; }
        [XmlElement("CUST_REF")]
        public string CustRef { get; set; }
        [XmlElement("EDI_ASSIGNED_FILE")]
        public decimal? EdiAssignedFile { get; set; }
        [XmlElement("EDI_ASSIGNED_DATE")]
        public string EdiAssignedDate { get; set; }
        [XmlElement("DATE_ARRIVAL")]
        public string DateArrival { get; set; }
        [XmlElement("ENTRY_TYPE")]
        public decimal? EntryType { get; set; }
        [XmlElement("ENTRY_FILER_CODE")]
        public string EntryFilerCode { get; set; }
        [XmlElement("ENTRY_NO")]
        public decimal? EntryNo { get; set; }
        [XmlElement("CUSTOMS_TEAM")]
        public string CustomsTeam { get; set; }
        [XmlElement("DATE_RECIEVED")]
        public string DateRecieved { get; set; }
        [XmlElement("TIME_RECIEVED")]
        public string TimeRecieved { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
        [XmlElement("RECON_NAFTA")]
        public string ReconNafta { get; set; }
        [XmlElement("RECON_9802")]
        public string Recon9802 { get; set; }
        [XmlElement("RECON_CLASS")]
        public string ReconClass { get; set; }
        [XmlElement("RECON_VALUE")]
        public string ReconValue { get; set; }
        [XmlElement("FILE_NO")]
        public decimal? FileNo { get; set; }
        [XmlElement("DIVISION_NO")]
        public decimal? DivisionNo { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class ShipmentHeaderFlex
    {
        [XmlElement("MASTER_BILL")]
        public string MasterBill { get; set; }
        [XmlElement("HOUSE_BILL")]
        public string HouseBill { get; set; }
        [XmlElement("SUB_BILL")]
        public string SubBill { get; set; }
        [XmlElement("SUB_SUB_BILL")]
        public string SubSubBill { get; set; }
        [XmlElement("FLEX_FIELD_1")]
        public string FlexField1 { get; set; }
        [XmlElement("FLEX_FIELD_2")]
        public string FlexField2 { get; set; }
        [XmlElement("FLEX_FIELD_3")]
        public string FlexField3 { get; set; }
        [XmlElement("FLEX_FIELD_4")]
        public string FlexField4 { get; set; }
        [XmlElement("FLEX_FIELD_5")]
        public string FlexField5 { get; set; }
        [XmlElement("FLEX_FIELD_6")]
        public string FlexField6 { get; set; }
        [XmlElement("FLEX_FIELD_7")]
        public string FlexField7 { get; set; }
        [XmlElement("FLEX_FIELD_8")]
        public string FlexField8 { get; set; }
        [XmlElement("FLEX_FIELD_9")]
        public string FlexField9 { get; set; }
        [XmlElement("FLEX_FIELD_10")]
        public string FlexField10 { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class ShipmentId
    {
        [XmlElement("MASTER_BILL")]
        public string MasterBill { get; set; }
        [XmlElement("HOUSE_BILL")]
        public string HouseBill { get; set; }
        [XmlElement("SUB_BILL")]
        public string SubBill { get; set; }
        [XmlElement("SUB_SUB_BILL")]
        public string SubSubBill { get; set; }
        [XmlElement("SEQ_NO")]
        public decimal? SeqNo { get; set; }
        [XmlElement("IT_NO")]
        public string ItNo { get; set; }
        [XmlElement("SCAC")]
        public string Scac { get; set; }
        [XmlElement("MASTER_BILL_ADDL")]
        public string MasterBillAddl { get; set; }
        [XmlElement("HOUSE_BILL_ADDL")]
        public string HouseBillAddl { get; set; }
        [XmlElement("SUB_BILL_ADDL")]
        public string SubBillAddl { get; set; }
        [XmlElement("QTY")]
        public decimal? Qty { get; set; }
        [XmlElement("UOM")]
        public string Uom { get; set; }
        [XmlElement("AMS_24_SCAC")]
        public string Ams24Scac { get; set; }
        [XmlElement("AMS_24_MASTER")]
        public string Ams24Master { get; set; }
        [XmlElement("SCAC_HOUSE")]
        public string ScacHouse { get; set; }
        [XmlElement("SUB_SUB_BILL_ADDL")]
        public string SubSubBillAddl { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class ShipmentDate
    {
        [XmlElement("MASTER_BILL")]
        public string MasterBill { get; set; }
        [XmlElement("HOUSE_BILL")]
        public string HouseBill { get; set; }
        [XmlElement("SUB_BILL")]
        public string SubBill { get; set; }
        [XmlElement("SUB_SUB_BILL")]
        public string SubSubBill { get; set; }
        [XmlElement("TRACING_DATE_NO")]
        public decimal? TracingDateNo { get; set; }
        [XmlElement("DATE_TRACING_SHIPMENT")]
        public string DateTracingShipment { get; set; }
        [XmlElement("TIME_TRACING_SHIPMENT")]
        public decimal? TimeTracingShipment { get; set; }
        [XmlElement("TIME_ZONE")]
        public string TimeZone { get; set; }
    }

    #region Invoice Level
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class InvoiceHeader
    {
        [XmlElement("EDI_INVOICE_LINES")]
        public InvoiceLine[] InvoiceLines { get; set; }
        [XmlElement("EDI_INVOICE_ADDRESSES")]
        public InvoiceAddresses[] InvoiceAddresses { get; set; }
        [XmlElement("EDI_INVOICE_LINES_FLEX")]
        public InvoiceLineFlex[] InvoiceLinesFlex { get; set; }

        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("MASTER_BILL")]
        public string MasterBill { get; set; }
        [XmlElement("HOUSE_BILL")]
        public string HouseBill { get; set; }
        [XmlElement("SUB_BILL")]
        public string SubBill { get; set; }
        [XmlElement("SUB_SUB_BILL")]
        public string SubSubBill { get; set; }
        [XmlElement("MATCH_SHIPMENT")]
        public string MatchShipment { get; set; }
        [XmlElement("MATCH_ENTRY")]
        public string MatchEntry { get; set; }
        [XmlElement("CUST_NO")]
        public string CustNo { get; set; }
        [XmlElement("INVOICE_TYPE")]
        public string InvoiceType { get; set; }
        [XmlElement("CURRENCY")]
        public string Currency { get; set; }
        [XmlElement("FIXED_EXCHANGE_RATE")]
        public decimal? FixedExchangeRate { get; set; }
        [XmlElement("EXCHANGE_RATE")]
        public decimal? ExchangeRate { get; set; }
        [XmlElement("LOCATION")]
        public string Location { get; set; }
        [XmlElement("LOCATION_OF_GOODS")]
        public string LocationOfGoods { get; set; }
        [XmlElement("NO_INVOICE_LINES")]
        public decimal? NoInvoiceLines { get; set; }
        [XmlElement("TOT_INVOICE_VALUE")]
        public decimal? TotInvoiceValue { get; set; }
        [XmlElement("TOT_VALUE_DISCOUNT")]
        public decimal? TotValueDiscount { get; set; }
        [XmlElement("MISC_DISCOUNT")]
        public decimal? MiscDiscount { get; set; }
        [XmlElement("MISC_DISCOUNT_PERCENT")]
        public decimal? MiscDiscountPercent { get; set; }
        [XmlElement("CASH_DISCOUNT")]
        public decimal? CashDiscount { get; set; }
        [XmlElement("CASH_DISCOUNT_PERCENT")]
        public decimal? CashDiscountPercent { get; set; }
        [XmlElement("FREIGHT_AMOUNT")]
        public decimal? FreightAmount { get; set; }
        [XmlElement("PRO_RATE_FREIGHT_AMT")]
        public string ProRateFreightAmt { get; set; }
        [XmlElement("PRO_RATE_MISC_DISCOUNT")]
        public string ProRateMiscDiscount { get; set; }
        [XmlElement("PRO_RATE_CASH_DISCOUNT")]
        public string ProRateCashDiscount { get; set; }
        [XmlElement("DISCOUNT_PERCENT")]
        public decimal? DiscountPercent { get; set; }
        [XmlElement("DISCOUNT_DAYS")]
        public decimal? DiscountDays { get; set; }
        [XmlElement("NON_DUTIABLE_AMT")]
        public decimal? NonDutiableAmt { get; set; }
        [XmlElement("ADD_TO_MAKE_AMT")]
        public decimal? AddToMakeAmt { get; set; }
        [XmlElement("DESC_1_CI")]
        public string Desc1Ci { get; set; }
        [XmlElement("DESC_2_CI")]
        public string Desc2Ci { get; set; }
        [XmlElement("DESC_3_CI")]
        public string Desc3Ci { get; set; }
        [XmlElement("CUST_REF")]
        public string CustRef { get; set; }
        [XmlElement("QTY")]
        public decimal? Qty { get; set; }
        [XmlElement("UOM")]
        public string Uom { get; set; }
        [XmlElement("WEIGHT_GROSS")]
        public decimal? WeightGross { get; set; }
        [XmlElement("DATE_EXPORT")]
        public string DateExport { get; set; }
        [XmlElement("COUNTRY_ORIGIN")]
        public string CountryOrigin { get; set; }
        [XmlElement("DEL_TERMS_1")]
        public string DelTerms1 { get; set; }
        [XmlElement("DEL_TERMS_2")]
        public string DelTerms2 { get; set; }
        [XmlElement("DEL_TERMS_3")]
        public string DelTerms3 { get; set; }
        [XmlElement("DEL_TERMS_4")]
        public string DelTerms4 { get; set; }
        [XmlElement("DEL_TERMS_5")]
        public string DelTerms5 { get; set; }
        [XmlElement("PAYMENT_TERMS_1")]
        public string PaymentTerms1 { get; set; }
        [XmlElement("PAYMENT_TERMS_2")]
        public string PaymentTerms2 { get; set; }
        [XmlElement("PAYMENT_TERMS_3")]
        public string PaymentTerms3 { get; set; }
        [XmlElement("PAYMENT_TERMS_4")]
        public string PaymentTerms4 { get; set; }
        [XmlElement("PAYMENT_TERMS_5")]
        public string PaymentTerms5 { get; set; }
        [XmlElement("NET_ALLOWANCE_CHARGE")]
        public decimal? NetAllowanceCharge { get; set; }
        [XmlElement("CHARGES")]
        public decimal? Charges { get; set; }
        [XmlElement("ACTION_REQUEST_CODE")]
        public string ActionRequestCode { get; set; }
        [XmlElement("EDI_ASSIGNED_FILE")]
        public decimal? EdiAssignedFile { get; set; }
        [XmlElement("EDI_ASSIGNED_DATE")]
        public string EdiAssignedDate { get; set; }
        [XmlElement("DATE_PRINTED")]
        public string DatePrinted { get; set; }
        [XmlElement("LOCATION_QUAL")]
        public string LocationQual { get; set; }
        [XmlElement("OTHER_AMT")]
        public decimal? OtherAmt { get; set; }
        [XmlElement("PRO_RATE_NON_DUTIABLE")]
        public string ProRateNonDutiable { get; set; }
        [XmlElement("PRO_RATE_ADJUSTMENT")]
        public string ProRateAdjustment { get; set; }
        [XmlElement("PRO_RATE_OTHER")]
        public string ProRateOther { get; set; }
        [XmlElement("CONVERT_NON_DUTIABLE")]
        public string ConvertNonDutiableAmt { get; set; }
        [XmlElement("CONVERT_ADD_TO_MAKE_AMT")]
        public string ConvertAddToMakeAmt { get; set; }
        [XmlElement("CONVERT_OTHER_AMT")]
        public string ConvertOtherAmt { get; set; }
        [XmlElement("CONVERT_MISC_DISCOUNT")]
        public string ConvertMiscDiscount { get; set; }
        [XmlElement("CONVERT_CASH_DISCOUNT")]
        public string ConvertCashDiscount { get; set; }
        [XmlElement("CONVERT_FREIGHT_AMT")]
        public string ConvertFreightAmt { get; set; }
        [XmlElement("DEDUCT_BROKERAGE")]
        public string DeductBrokerage { get; set; }
        [XmlElement("DEDUCT_DUTY_FEES")]
        public string DeductDutyFees { get; set; }
        [XmlElement("DISCOUNT")]
        public decimal? Discount { get; set; }
        [XmlElement("AGENT_CODE")]
        public string AgentCode { get; set; }
        [XmlElement("LANDED_WEIGHT")]
        public decimal? LandedWeight { get; set; }
        [XmlElement("LANDED_WEIGHT_UOM")]
        public string LandedWeightUom { get; set; }
        [XmlElement("ENTRY_TYPE")]
        public decimal? EntryType { get; set; }
        [XmlElement("PURCHASE_ORDER_NO")]
        public string PurchaseOrderNo { get; set; }
        [XmlElement("USER_FLD_1")]
        public string UserFld1 { get; set; }
        [XmlElement("USER_FLD_2")]
        public string UserFld2 { get; set; }
        [XmlElement("USER_FLD_3")]
        public string UserFld3 { get; set; }
        [XmlElement("USER_FLD_4")]
        public string UserFld4 { get; set; }
        [XmlElement("USER_FLD_5")]
        public string UserFld5 { get; set; }
        [XmlElement("PACKING_CHARGE")]
        public decimal? PackingCharge { get; set; }
        [XmlElement("INSURANCE_AMT")]
        public decimal? InsuranceAmt { get; set; }
        [XmlElement("DOCUMENT_PREPARED_BY")]
        public string DocumentPreparedBy { get; set; }
        [XmlElement("DISCOUNT_DESC")]
        public string DiscountDesc { get; set; }
        [XmlElement("FOREIGN_SHIP_DESC_1")]
        public string ForeignShipDesc1 { get; set; }
        [XmlElement("FOREIGN_SHIP_DESC_2")]
        public string ForeignShipDesc2 { get; set; }
        [XmlElement("FOREIGN_SHIP_DESC_3")]
        public string ForeignShipDesc3 { get; set; }
        [XmlElement("WEIGHT_NET")]
        public decimal? WeightNet { get; set; }
        [XmlElement("UPDATE_ACTION_CODE")]
        public string UpdateActionCode { get; set; }
        [XmlElement("INVOICE_REQUEST_RESPONSE")]
        public string InvoiceRequestResponse { get; set; }
        [XmlElement("PAYMENT_TERMS_TYPE")]
        public decimal? PaymentTermsType { get; set; }
        [XmlElement("AII_TRANSACTION")]
        public string AiiTransaction { get; set; }
        [XmlElement("CI_NO_LINES")]
        public decimal? CiNoLines { get; set; }
        [XmlElement("TOT_INVOICE_AMOUNTS")]
        public decimal? TotInvoiceAmounts { get; set; }
        [XmlElement("TOT_INVOICE_ADD_AMT")]
        public decimal? TotInvoiceAddAmt { get; set; }
        [XmlElement("TOT_INVOICE_FOREIGN_TAX")]
        public decimal? TotInvoiceForeignTax { get; set; }
        [XmlElement("TOT_PREPAYMENT")]
        public decimal? TotPrepayment { get; set; }
        [XmlElement("TOT_VALUE_FOREIGN_TAX")]
        public decimal? TotValueForeignTax { get; set; }
        [XmlElement("TOT_VALUE_US_DUTY")]
        public decimal? TotValueUsDuty { get; set; }
        [XmlElement("DECLARANT")]
        public string Declarant { get; set; }
        [XmlElement("DATE_DECLARATION")]
        public string DateDeclaration { get; set; }
        [XmlElement("ALREADY_SENT_AII")]
        public string AlreadySentAii { get; set; }
        [XmlElement("SWPM_INDICATOR")]
        public string SwpmIndicator { get; set; }
        [XmlElement("IRS_NO")]
        public string IrsNo { get; set; }
        [XmlElement("AII_FILE")]
        public string AiiFile { get; set; }
        [XmlElement("DESC_4_CI")]
        public string Desc4Ci { get; set; }
        [XmlElement("CVD_ADA_DEDUCTION")]
        public string CvdAdaDeduction { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class InvoiceAddresses
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("PARTIES_QUALIFIER")]
        public string PartiesQualifier { get; set; }
        [XmlElement("NAME")]
        public string Name { get; set; }
        [XmlElement("ADDRESS_1")]
        public string Address1 { get; set; }
        [XmlElement("ADDRESS_2")]
        public string Address2 { get; set; }
        [XmlElement("ADDRESS_3")]
        public string Address3 { get; set; }
        [XmlElement("CITY")]
        public string City { get; set; }
        [XmlElement("COUNTRY_SUBENTITY")]
        public string CountrySubentity { get; set; }
        [XmlElement("PROVINCE")]
        public string Province { get; set; }
        [XmlElement("ZIP")]
        public string Zip { get; set; }
        [XmlElement("COUNTRY")]
        public string Country { get; set; }
        [XmlElement("PARTY_NO")]
        public string PartyNo { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class InvoiceHeaderFlex
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("FLEX_FIELD_1")]
        public string FlexField1 { get; set; }
        [XmlElement("FLEX_FIELD_2")]
        public string FlexField2 { get; set; }
        [XmlElement("FLEX_FIELD_3")]
        public string FlexField3 { get; set; }
        [XmlElement("FLEX_FIELD_4")]
        public string FlexField4 { get; set; }
        [XmlElement("FLEX_FIELD_5")]
        public string FlexField5 { get; set; }
        [XmlElement("FLEX_FIELD_6")]
        public string FlexField6 { get; set; }
        [XmlElement("FLEX_FIELD_7")]
        public string FlexField7 { get; set; }
        [XmlElement("FLEX_FIELD_8")]
        public string FlexField8 { get; set; }
        [XmlElement("FLEX_FIELD_9")]
        public string FlexField9 { get; set; }
        [XmlElement("FLEX_FIELD_10")]
        public string FlexField10 { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class InvoiceLine
    {
        [XmlElement("EDI_INVOICE_TARIFF_CLASS")]
        public InvoiceLineTariffClass[] InvoiceLinesTariffClass { get; set; }
        [XmlElement("EDI_INVOICE_LINES_FLEX")]
        public InvoiceLineFlex[] InvoiceLineFlexes { get; set; }
        [XmlElement("EDI_INVOICE_LINE_PARTY")]
        public InvoiceParty[] InvoiceLineParties { get; set; }

        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("MASTER_BILL")]
        public string MasterBill { get; set; }
        [XmlElement("HOUSE_BILL")]
        public string HouseBill { get; set; }
        [XmlElement("SUB_BILL")]
        public string SubBill { get; set; }
        [XmlElement("SUB_SUB_BILL")]
        public string SubSubBill { get; set; }
        [XmlElement("MATCH_SHIPMENT")]
        public string MatchShipment { get; set; }
        [XmlElement("MATCH_ENTRY")]
        public string MatchEntry { get; set; }
        [XmlElement("CUST_NO")]
        public string CustNo { get; set; }
        [XmlElement("PART_NO")]
        public string PartNo { get; set; }
        [XmlElement("STYLE_NO")]
        public string StyleNo { get; set; }
        [XmlElement("ASSEMBLER")]
        public string Assembler { get; set; }
        [XmlElement("VENDOR_PART_NO")]
        public string VendorPartNo { get; set; }
        [XmlElement("CONSIGNEE_PART_NO")]
        public string ConsigneePartNo { get; set; }
        [XmlElement("SERIAL_NO")]
        public string SerialNo { get; set; }
        [XmlElement("QTY")]
        public decimal? Qty { get; set; }
        [XmlElement("UOM")]
        public string Uom { get; set; }
        [XmlElement("DATE_EXPORT")]
        public string DateExport { get; set; }
        [XmlElement("COUNTRY_ORIGIN")]
        public string CountryOrigin { get; set; }
        [XmlElement("COUNTRY_EXPORT")]
        public string CountryExport { get; set; }
        [XmlElement("PORT_LADING")]
        public decimal? PortLading { get; set; }
        [XmlElement("WEIGHT_GROSS")]
        public decimal? WeightGross { get; set; }
        [XmlElement("KILOS_POUNDS")]
        public string KilosPounds { get; set; }
        [XmlElement("VOLUME")]
        public decimal? Volume { get; set; }
        [XmlElement("UOM_VOLUME")]
        public string UomVolume { get; set; }
        [XmlElement("QTY_COMMERCIAL")]
        public decimal? QtyCommercial { get; set; }
        [XmlElement("UOM_COMMERCIAL")]
        public string UomCommercial { get; set; }
        [XmlElement("UNIT_PRICE")]
        public decimal? UnitPrice { get; set; }
        [XmlElement("UOM_UNIT_PRICE")]
        public string UomUnitPrice { get; set; }
        [XmlElement("MANIFEST_NO")]
        public string ManifestNo { get; set; }
        [XmlElement("NO_CONTAINER")]
        public string NoContainer { get; set; }
        [XmlElement("CONT_SIZE")]
        public string ContSize { get; set; }
        [XmlElement("SEAL_NO")]
        public string SealNo { get; set; }
        [XmlElement("TARIFF_NO")]
        public string TariffNo { get; set; }
        [XmlElement("VALUE_FOREIGN")]
        public decimal? ValueForeign { get; set; }
        [XmlElement("QTY_1_CLASS")]
        public decimal? Qty1Class { get; set; }
        [XmlElement("QTY_2_CLASS")]
        public decimal? Qty2Class { get; set; }
        [XmlElement("QTY_3_CLASS")]
        public decimal? Qty3Class { get; set; }
        [XmlElement("UOM_1_CLASS")]
        public string Uom1Class { get; set; }
        [XmlElement("UOM_2_CLASS")]
        public string Uom2Class { get; set; }
        [XmlElement("UOM_3_CLASS")]
        public string Uom3Class { get; set; }
        [XmlElement("CUST_REF")]
        public string CustRef { get; set; }
        [XmlElement("PURCHASE_ORDER_NO")]
        public string PurchaseOrderNo { get; set; }
        [XmlElement("PURCHASE_ORDER_DATE")]
        public string PurchaseOrderDate { get; set; }
        [XmlElement("FILLER_2")]
        public string Filler2 { get; set; }
        [XmlElement("PURCHASE_ORDER_REL_NO")]
        public string PurchaseOrderRelNo { get; set; }
        [XmlElement("PURCHASE_ORDER_QTY")]
        public decimal? PurchaseOrderQty { get; set; }
        [XmlElement("MODEL_NO")]
        public string ModelNo { get; set; }
        [XmlElement("CONTRACT")]
        public string Contract { get; set; }
        [XmlElement("RELATED_PARTIES")]
        public string RelatedParties { get; set; }
        [XmlElement("DESCR")]
        public string Descr { get; set; }
        [XmlElement("SUPPLIER_NAME")]
        public string SupplierName { get; set; }
        [XmlElement("SUPPLIER_MID")]
        public string SupplierMid { get; set; }
        [XmlElement("SALES_ORDER")]
        public string SalesOrder { get; set; }
        [XmlElement("INBOUND_CONSOLIDATOR")]
        public string InboundConsolidator { get; set; }
        [XmlElement("TAX_JURIS_CODE")]
        public string TaxJurisCode { get; set; }
        [XmlElement("EDI_ASSIGNED_FILE")]
        public decimal? EdiAssignedFile { get; set; }
        [XmlElement("EDI_ASSIGNED_DATE")]
        public string EdiAssignedDate { get; set; }
        [XmlElement("DATE_PRINTED")]
        public string DatePrinted { get; set; }
        [XmlElement("PRODUCT_LINE")]
        public string ProductLine { get; set; }
        [XmlElement("DOMESTIC_DESTINATION")]
        public string DomesticDestination { get; set; }
        [XmlElement("DEPARTMENT")]
        public decimal? Department { get; set; }
        [XmlElement("CHARGES")]
        public decimal? Charges { get; set; }
        [XmlElement("PENALTY_TYPE")]
        public string PenaltyType { get; set; }
        [XmlElement("CASE_NO")]
        public string CaseNo { get; set; }
        [XmlElement("USER_ENTERED_WEIGHT")]
        public string UserEnteredWeight { get; set; }
        [XmlElement("SPI_PRIMARY")]
        public string SpiPrimary { get; set; }
        [XmlElement("SPI_SECONDARY")]
        public string SpiSecondary { get; set; }
        [XmlElement("NON_DUTIABLE_AMT")]
        public decimal? NonDutiableAmt { get; set; }
        [XmlElement("ADD_TO_MAKE_AMT")]
        public decimal? AddToMakeAmt { get; set; }
        [XmlElement("OTHER_AMT")]
        public decimal? OtherAmt { get; set; }
        [XmlElement("MISC_DISCOUNT")]
        public decimal? MiscDiscount { get; set; }
        [XmlElement("CASH_DISCOUNT")]
        public decimal? CashDiscount { get; set; }
        [XmlElement("FREIGHT_AMOUNT")]
        public decimal? FreightAmount { get; set; }
        [XmlElement("CONVERT_NON_DUTIABLE_AMT")]
        public string ConvertNonDutiableAmt { get; set; }
        [XmlElement("CONVERT_ADD_TO_MAKE_AMT")]
        public string ConvertAddToMakeAmt { get; set; }
        [XmlElement("CONVERT_OTHER_AMT")]
        public string ConvertOtherAmt { get; set; }
        [XmlElement("CONVERT_MISC_DISCOUNT")]
        public string ConvertMiscDiscount { get; set; }
        [XmlElement("CONVERT_CASH_DISCOUNT")]
        public string ConvertCashDiscount { get; set; }
        [XmlElement("CONVERT_FREIGHT_AMT")]
        public string ConvertFreightAmt { get; set; }
        [XmlElement("RULING_NO")]
        public string RulingNo { get; set; }
        [XmlElement("QUOTA_S")]
        public string QuotaS { get; set; }
        [XmlElement("VISA_LIC")]
        public string VisaLIC { get; set; }
        [XmlElement("VISA_LIC_QTY")]
        public string VisaLICQty { get; set; }
        [XmlElement("VISA_LIC_UOM_S")]
        public string VisaLICUomS { get; set; }
        [XmlElement("VISA_DATE")]
        public string VisaDate { get; set; }
        [XmlElement("CATEGORY_NO")]
        public decimal? CategoryNo { get; set; }
        [XmlElement("DESC_1_CI")]
        public string Desc1Ci { get; set; }
        [XmlElement("DESC_2_CI")]
        public string Desc2Ci { get; set; }
        [XmlElement("DESC_3_CI")]
        public string Desc3Ci { get; set; }
        [XmlElement("RECON_NAFTA")]
        public string ReconNafta { get; set; }
        [XmlElement("RECON_9802")]
        public string Recon9802 { get; set; }
        [XmlElement("RECON_CLASS")]
        public string ReconClass { get; set; }
        [XmlElement("RECON_VALUE")]
        public string ReconValue { get; set; }
        [XmlElement("WOOL_LISCENSE")]
        public string WoolLiscense { get; set; }
        [XmlElement("STEEL_LISCENSE")]
        public string SteelLiscense { get; set; }
        [XmlElement("OTHER_LIC_DATA_1")]
        public string OtherLicData1 { get; set; }
        [XmlElement("OTHER_LIC_DATA_2")]
        public string OtherLicData2 { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class InvoiceLineFlex
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public string CommInvLineNo { get; set; }
        [XmlElement("FLEX_FIELD_1")]
        public string FlexField1 { get; set; }
        [XmlElement("FLEX_FIELD_2")]
        public string FlexField2 { get; set; }
        [XmlElement("FLEX_FIELD_3")]
        public string FlexField3 { get; set; }
        [XmlElement("FLEX_FIELD_4")]
        public string FlexField4 { get; set; }
        [XmlElement("FLEX_FIELD_5")]
        public string FlexField5 { get; set; }
        [XmlElement("FLEX_FIELD_6")]
        public string FlexField6 { get; set; }
        [XmlElement("FLEX_FIELD_7")]
        public string FlexField7 { get; set; }
        [XmlElement("FLEX_FIELD_8")]
        public string FlexField8 { get; set; }
        [XmlElement("FLEX_FIELD_9")]
        public string FlexField9 { get; set; }
        [XmlElement("FLEX_FIELD_10")]
        public string FlexField10 { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class InvoiceParty
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public string CommInvLineNo { get; set; }
        public string PartiesQualifier { get; set; }
        [XmlElement("NAME")]
        public string Name { get; set; }
        [XmlElement("ADDRESS_1")]
        public string Address1 { get; set; }
        [XmlElement("ADDRESS_2")]
        public string Address2 { get; set; }
        [XmlElement("ADDRESS_3")]
        public string Address3 { get; set; }
        [XmlElement("CITY")]
        public string City { get; set; }
        [XmlElement("COUNTRY_SUBENTITY")]
        public string CountrySubentity { get; set; }
        [XmlElement("PROVINCE")]
        public string Province { get; set; }
        [XmlElement("ZIP")]
        public string Zip { get; set; }
        [XmlElement("COUNTRY")]
        public string Country { get; set; }
        [XmlElement("PARTY_NO")]
        public string PartyNo { get; set; }
        [XmlElement("CUST_NO")]
        public string CustNo { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class InvoiceLineTariffClass
    {
        [XmlElement("EDI_PG_ES")]
        public PgEs[] LinePgEs { get; set; }

        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_NO")]
        public string TariffNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("WEIGHT_GROSS")]
        public decimal? WeightGross { get; set; }
        [XmlElement("KILOS_POUNDS")]
        public string KilosPounds { get; set; }
        [XmlElement("VALUE_FOREIGN")]
        public decimal? ValueForeign { get; set; }
        [XmlElement("QTY_1_CLASS")]
        public decimal? Qty1Class { get; set; }
        [XmlElement("QTY_2_CLASS")]
        public decimal? Qty2Class { get; set; }
        [XmlElement("QTY_3_CLASS")]
        public decimal? Qty3Class { get; set; }
        [XmlElement("UOM_1_CLASS")]
        public string Uom1Class { get; set; }
        [XmlElement("UOM_2_CLASS")]
        public string Uom2Class { get; set; }
        [XmlElement("UOM_3_CLASS")]
        public string Uom3Class { get; set; }
        [XmlElement("SPI_PRIMARY")]
        public string SpiPrimary { get; set; }
        [XmlElement("SPI_SECONDARY")]
        public string SpiSecondary { get; set; }
        [XmlElement("NON_DUTIABLE_AMT")]
        public decimal? NonDutiableAmt { get; set; }
        [XmlElement("ADD_TO_MAKE_AMT")]
        public decimal? AddToMakeAmt { get; set; }
        [XmlElement("OTHER_AMT")]
        public decimal? OtherAmt { get; set; }
        [XmlElement("MISC_DISCOUNT")]
        public decimal? MiscDiscount { get; set; }
        [XmlElement("CASH_DISCOUNT")]
        public decimal? CashDiscount { get; set; }
        [XmlElement("FREIGHT_AMOUNT")]
        public decimal? FreightAmount { get; set; }
        [XmlElement("CONVERT_NON_DUTIABLE_AMT")]
        public string ConvertNonDutiableAmt { get; set; }
        [XmlElement("CONVERT_ADD_TO_MAKE_AMT")]
        public string ConvertAddToMakeAmt { get; set; }
        [XmlElement("CONVERT_OTHER_AMT")]
        public string ConvertOtherAmt { get; set; }
        [XmlElement("CONVERT_MISC_DISCOUNT")]
        public string ConvertMiscDiscount { get; set; }
        [XmlElement("CONVERT_CASH_DISCOUNT")]
        public string ConvertCashDiscount { get; set; }
        [XmlElement("CONVERT_FREIGHT_AMT")]
        public string ConvertFreightAmt { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgEs
    {
        [XmlElement("EDI_PG_EPA_ES")]
        public PgEpaEs[] EpaLines { get; set; }
        [XmlElement("EDI_PG_FDA_ES")]
        public PgFdaEs[] FdaLines { get; set; }
        [XmlElement("EDI_NHTSA_ES")]
        public NhtsaEs[] NhtsaLines { get; set; }
        //[XmlElement("EDI_PG_APHIS_ES")]
        //public PgAphisEs[] AphisLines { get; set; }

        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_NO")]
        public string TariffNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("COMMERCIAL_DESC")]
        public string CommercialDesc { get; set; }
        [XmlElement("AGENCY_PROCESSING_CD")]
        public string AgencyProcessingCd { get; set; }
        [XmlElement("ELECTRONIC_IMAGE_SUBMITTED")]
        public string ElectronicImageSubmitted { get; set; }
        [XmlElement("CONFIDENTIAL")]
        public string Confidential { get; set; }
        [XmlElement("GLOBAL_PRODUCT_ID_QUAL")]
        public string GlobalProductIdQual { get; set; }
        [XmlElement("GLOBAL_PRODUCT_ID")]
        public string GlobalProductId { get; set; }
        [XmlElement("PG_INTENDED_USE_BASE_CD")]
        public string PgIntendedUseBaseCd { get; set; }
        [XmlElement("PG_INTENDED_USE_SUB_CD")]
        public string PgIntendedUseSubCd { get; set; }
        [XmlElement("PG_INTENDED_USE_ADD_CD")]
        public string PgIntendedUseAddCd { get; set; }
        [XmlElement("PG_INTENDED_USE_DESC")]
        public string PgIntendedUseDesc { get; set; }
        [XmlElement("IS_DISCLAIMER")]
        public string IsDisclaimer { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("PG_AGENCY_CD")]
        public string PgAgencyCd { get; set; }
        [XmlElement("PG_PROGRAM_CD")]
        public string PgProgramCd { get; set; }
        [XmlElement("USCS_PG_SEQ_NBR")]
        public decimal? UscsPgSeqNbr { get; set; }
        [XmlElement("DISPOSITION_ACTION_DATE")]
        public string DispositionActionDate { get; set; }
        [XmlElement("DISPOSITION_ACTION_TIME")]
        public decimal? DispositionActionTime { get; set; }
        [XmlElement("DISPOSITION_ACTION_CD")]
        public string DispositionActionCd { get; set; }
        [XmlElement("NARRATIVE_MESSAGE")]
        public string NarrativeMessage { get; set; }
        [XmlElement("DOCUMENT_TYPE_CD")]
        public string DocumentTypeCd { get; set; }
        [XmlElement("DISCLAIMER_TYPE_CD")]
        public string DisclaimerTypeCd { get; set; }
    }

    #region EPA
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgEpaEs
    {
        [XmlElement("EDI_PG_EPA_ES_PARTIES")]
        public PgEpaEsParties[] EpaParties { get; set; }
        [XmlElement("EDI_PG_EPA_ES_PROD_COMP")]
        public PgEpaEsProdComp[] EpaProdComps { get; set; }
        [XmlElement("EDI_PG_EPA_ES_ADDL_ITEM_ID")]
        public PgEpaEsAddlItemId[] EpaAddlItems { get; set; }
        [XmlElement("EDI_PG_EPA_ES_REMARKS")]
        public PgEpaEsRemarks[] EpaRemarks { get; set; }

        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("PRODUCT_CD_QUALIFIER")]
        public string ProductCdQualifier { get; set; }
        [XmlElement("PRODUCT_CD")]
        public string ProductCd { get; set; }
        [XmlElement("NET_WEIGHT_UOM")]
        public string NetWeightUom { get; set; }
        [XmlElement("NET_WEIGHT")]
        public decimal? NetWeight { get; set; }
        [XmlElement("DOCUMENT_ID_CD")]
        public string DocumentIdCd { get; set; }
        [XmlElement("ENTITY_ROLE_CD")]
        public string EntityRoleCd { get; set; }
        [XmlElement("DECLARATION_CD")]
        public string DeclarationCd { get; set; }
        [XmlElement("DECLARATION_CERT")]
        public string DeclarationCert { get; set; }
        [XmlElement("DATE_SIGNATURE")]
        public string DateSignature { get; set; }
        [XmlElement("IS_EXEMPT_FROM_BOND")]
        public string IsExemptFromBond { get; set; }
        [XmlElement("INDUSTRY_CD")]
        public string IndustryCd { get; set; }
        [XmlElement("OTHER_EXEMPTION_REGULATION")]
        public string OtherExemptionRegulation { get; set; }
        [XmlElement("TRADE_BRAND_NAME")]
        public string TradeBrandName { get; set; }
        [XmlElement("EPA_REGISTRATION_NO")]
        public string EpaRegistrationNo { get; set; }
        [XmlElement("FOREIGN_PRODUCER_EST_NO")]
        public string ForeignProducerEstNo { get; set; }
        [XmlElement("DOMESTIC_PRODUCER_EST_NO")]
        public string DomesticProducerEstNo { get; set; }
        [XmlElement("CERTIFYING_INDIVIDUAL_ROLE_CD")]
        public string CertifyingIndividualRoleCd { get; set; }
        [XmlElement("NOTIFY_PARTY_ROLE_CD")]
        public string NotifyPartyRoleCd { get; set; }
        [XmlElement("ACTIVE_INGREDIENT")]
        public string ActiveIngredient { get; set; }
        [XmlElement("INGREDIENT_NAME")]
        public string IngredientName { get; set; }
        [XmlElement("INGREDIENT_PERCENT")]
        public string IngredientPercent { get; set; }
        [XmlElement("PACKAGIN_QUANTITY_1")]
        public decimal? PackagingQuantity1 { get; set; }
        [XmlElement("PACKAGIN_QUANTITY_2")]
        public decimal? PackagingQuantity2 { get; set; }
        [XmlElement("PACKAGIN_QUANTITY_3")]
        public decimal? PackagingQuantity3 { get; set; }
        [XmlElement("PACKAGIN_QUANTITY_4")]
        public decimal? PackagingQuantity4 { get; set; }
        [XmlElement("PACKAGIN_QUANTITY_5")]
        public decimal? PackagingQuantity5 { get; set; }
        [XmlElement("PACKAGIN_QUANTITY_6")]
        public decimal? PackagingQuantity6 { get; set; }
        [XmlElement("PACKAGIN_UOM_CD_1")]
        public string PackagingUomCd1 { get; set; }
        [XmlElement("PACKAGIN_UOM_CD_2")]
        public string PackagingUomCd2 { get; set; }
        [XmlElement("PACKAGIN_UOM_CD_3")]
        public string PackagingUomCd3 { get; set; }
        [XmlElement("PACKAGIN_UOM_CD_4")]
        public string PackagingUomCd4 { get; set; }
        [XmlElement("PACKAGIN_UOM_CD_5")]
        public string PackagingUomCd5 { get; set; }
        [XmlElement("PACKAGIN_UOM_CD_6")]
        public string PackagingUomCd6 { get; set; }
        [XmlElement("PACKAGING_IDENTIFIER_1")]
        public string PackagingIdentifier1 { get; set; }
        [XmlElement("PACKAGING_IDENTIFIER_2")]
        public string PackagingIdentifier2 { get; set; }
        [XmlElement("PACKAGING_IDENTIFIER_3")]
        public string PackagingIdentifier3 { get; set; }
        [XmlElement("PACKAGING_IDENTIFIER_4")]
        public string PackagingIdentifier4 { get; set; }
        [XmlElement("PACKAGING_IDENTIFIER_5")]
        public string PackagingIdentifier5 { get; set; }
        [XmlElement("PACKAGING_IDENTIFIER_6")]
        public string PackagingIdentifier6 { get; set; }
        [XmlElement("MODEL")]
        public string Model { get; set; }
        [XmlElement("MODEL_YEAR")]
        public string ModelYear { get; set; }
        [XmlElement("MANUFACTURE_MONTH_YEAR")]
        public decimal? ManufactureMonthYear { get; set; }
        [XmlElement("MANUFACTURE_DATE_LOCATION_CD")]
        public string ManufactureDateLocationCd { get; set; }
        [XmlElement("OTHER_LOCATION_DESC")]
        public string OtherLocationDesc { get; set; }
        [XmlElement("ENGINE_POWER_RATING_TYPE")]
        public string EnginePowerRatingType { get; set; }
        [XmlElement("ENGINE_POWER_RATING_MAX_VALUE")]
        public decimal? EnginePowerRatingMaxValue { get; set; }
        [XmlElement("BODY_TYPE_UNDER_1_TON")]
        public string BodyTypeUnder1Ton { get; set; }
        [XmlElement("BODY_TYPE_OVER_1_TON")]
        public string BodyTypeOver1Ton { get; set; }
        [XmlElement("MILITARY_EQUIPMENT")]
        public string MilitaryEquipment { get; set; }
        [XmlElement("DRIVER_SIDE")]
        public string DriverSide { get; set; }
        [XmlElement("TEST_GROUP_NAME_NO")]
        public string TestGroupNameNo { get; set; }
        [XmlElement("BOND_POLICY_NO")]
        public string BondPolicyNo { get; set; }
        [XmlElement("BOND_POLICY_NO_DURATION")]
        public string BondPolicyNoDuration { get; set; }
        [XmlElement("VNE_EXCEPTION_NO")]
        public string VneExceptionNo { get; set; }
        [XmlElement("ITEM_IDENTITY_QUAL")]
        public string ItemIdentityQual { get; set; }
        [XmlElement("ITEM_IDENTITY_NBR")]
        public string ItemIdentityNbr { get; set; }
        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("SEND_PG_PROGRAM_CD")]
        public string SendPgProgramCd { get; set; }       
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgEpaEsParties
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("PARTY_SEQ_NBR")]
        public decimal? PartySeqNbr { get; set; }
        [XmlElement("PARTY_ROLE")]
        public string PartyRole { get; set; }
        [XmlElement("PARTY_CUST_NO")]
        public string PartyCustNo { get; set; }
        [XmlElement("PARTY_ADDRESS_NO")]
        public decimal? PartyAddressNo { get; set; }
        [XmlElement("PARTY_CONTACT_NO")]
        public decimal? PartyContactNo { get; set; }
        [XmlElement("PARTY_CARRIER_CD")]
        public string PartyCarrierCd { get; set; }
        [XmlElement("PARTY_FIRMS_CD")]
        public string PartyFirmsCd { get; set; }
        [XmlElement("PARTY_MID_CD")]
        public string PartyMidCd { get; set; }
        [XmlElement("PARTY_NUMBER")]
        public string PartyNumber { get; set; }
        [XmlElement("PARTY_NAME")]
        public string PartyName { get; set; }
        [XmlElement("PARTY_ADDRESS_LINE_1")]
        public string PartyAddressLine1 { get; set; }
        [XmlElement("PARTY_ADDRESS_LINE_2")]
        public string PartyAddressLine2 { get; set; }
        [XmlElement("PARTY_CITY")]
        public string PartyCity { get; set; }
        [XmlElement("PARTY_STATE_PROVINCE")]
        public string PartyStateProvince { get; set; }
        [XmlElement("PARTY_COUNTRY")]
        public string PartyCountry { get; set; }
        [XmlElement("PARTY_ZIP_CD")]
        public string PartyZipCd { get; set; }
        [XmlElement("PARTY_INDIVIDUAL_NAME")]
        public string PartyIndividualName { get; set; }
        [XmlElement("PARTY_PHONE_NO")]
        public string PartyPhoneNo { get; set; }
        [XmlElement("PARTY_FAX_NO")]
        public string PartyFaxNo { get; set; }
        [XmlElement("PARTY_EMAIL_ADDRESS")]
        public string PartyEmailAddress { get; set; }
        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgEpaEsProdComp
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("COMPONENT_SEQ_NBR")]
        public decimal? ComponentSeqNbr { get; set; }
        [XmlElement("COMPONENT_TYPE_CD")]
        public string ComponentTypeCd { get; set; }
        [XmlElement("PRODUCT_CD_QUALIFIER")]
        public string ProductCdQualifier { get; set; }
        [XmlElement("PRODUCT_CD")]
        public string ProductCd { get; set; }
        [XmlElement("ACTIVE_INGREDIENT")]
        public string ActiveIngredient { get; set; }
        [XmlElement("INGREDIENT_NAME")]
        public string IngredientName { get; set; }
        [XmlElement("INGREDIENT_PERCENT")]
        public string IngredientPercent { get; set; }
        [XmlElement("VEHICLE_MODEL")]
        public string VehicleModel { get; set; }
        [XmlElement("VEHICLE_MFG_MONTH_YEAR")]
        public string VehicleMfgMonthYear { get; set; }
        [XmlElement("VEHICLE_ITEM_IDENTITY_QUAL")]
        public string VehicleItemIdentityQual { get; set; }
        [XmlElement("VEHICLE_ITEM_IDENTITY_NBR")]
        public string VehicleItemIdentityNbr { get; set; }
        [XmlElement("ENGINE_MODEL")]
        public string EngineModel { get; set; }
        [XmlElement("ENGINE_MFG_MONTH_YEAR")]
        public string EngineMfgMonthYear { get; set; }
        [XmlElement("ENGINE_ITEM_IDENTITY_QUAL")]
        public string EngineItemIdentityQual { get; set; }
        [XmlElement("ENGINE_ITEM_IDENTITY_NBR")]
        public string EngineItemIdentityNbr { get; set; }
        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgEpaEsAddlItemId
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("ITEM_ID_SEQ_NBR")]
        public decimal? ItemIdSeqNbr { get; set; }
        [XmlElement("ITEM_IDENTITY_NBR")]
        public string ItemIdentityNbr { get; set; }
        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgEpaEsRemarks
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("REMARKS_SEQ_NBR")]
        public decimal? RemarksSeqNbr { get; set; }
        [XmlElement("REMARKS_TYPE_CD")]
        public string RemarksTypeCd { get; set; }
        [XmlElement("REMARKS_CD")]
        public string RemarksCd { get; set; }
        [XmlElement("REMARKS_TEXT")]
        public string RemarksText { get; set; }
        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
    }

    #endregion
    #region FDA

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgFdaEs
    {
        [XmlElement("EDI_PG_FDA_ES_PARTIES")]
        public PgFdaEsParties[] FdaParties { get; set; }
        [XmlElement("EDI_PG_FDA_ES_COUNTRIES")]
        public PgFdaEsCountries[] FdaCountries { get; set; }
        [XmlElement("EDI_PG_FDA_ES_CONTAINERS")]
        public PgFdaEsContainers[] FdaContainers { get; set; }
        [XmlElement("EDI_PG_FDA_ES_COMPLIANCE")]
        public PgFdaEsCompliance[] FdaCompliance { get; set; }
        [XmlElement("EDI_PG_FDA_ES_INGREDIENTS")]
        public PgFdaEsIngredients[] FdaIngredients { get; set; }
        [XmlElement("EDI_PG_FDA_ES_REMARKS")]
        public PgFdaEsRemarks[] FdaRemarks { get; set; }
        [XmlElement("EDI_PG_FDA_ES_ADDL_LOTS")]
        public PgFdaEsAddlLots[] FdaAddlLots { get; set; }

        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("PRODUCT_CODE_QUALIFIER")]
        public string ProductCodeQualifier { get; set; }
        [XmlElement("PRODUCT_CODE_NUMBER")]
        public string ProductCodeNumber { get; set; }
        [XmlElement("PRODUCT_DESCR")]
        public string ProductDescr { get; set; }
        [XmlElement("SCIENTIFIC_GENUS_NAME")]
        public string ScientificGenusName { get; set; }
        [XmlElement("SCIENTIFIC_SPECIES_NAME")]
        public string ScientificSpeciesName { get; set; }
        [XmlElement("SCIENTIFIC_SUB_SPECIES_NAME")]
        public string ScientificSubSpeciesName { get; set; }
        [XmlElement("TRADE_BRAND_NAME")]
        public string TradeBrandName { get; set; }
        [XmlElement("TEMPERATURE_QUALIFIER")]
        public string TemperatureQualifier { get; set; }
        [XmlElement("DEGREE_TYPE_CD")]
        public string DegreeTypeCd { get; set; }
        [XmlElement("IS_NEGATIVE_TEMP")]
        public string IsNegativeTemp { get; set; }
        [XmlElement("ACTUAL_TEMPERATURE")]
        public decimal? ActualTemperature { get; set; }
        [XmlElement("TEMPERATURE_LOCATION_CD")]
        public string TemperatureLocationCd { get; set; }
        [XmlElement("LOT_NUMBER_QUALIFIER_CD")]
        public string LotNumberQualifierCd { get; set; }
        [XmlElement("LOT_NUMBER")]
        public string LotNumber { get; set; }
        [XmlElement("LOT_PRODUCTION_START_DATE")]
        public string LotProductionStartDate { get; set; }
        [XmlElement("LOT_PRODUCTION_END_DATE")]
        public string LotProductionEndDate { get; set; }
        [XmlElement("PGA_LINE_VALUE_FOREIGN")]
        public decimal? PgaLineValueForeign { get; set; }
        [XmlElement("PGA_UNIT_VALUE_FOREIGN")]
        public decimal? PgaUnitValueForeign { get; set; }
        [XmlElement("PGA_LINE_VALUE_US")]
        public decimal? PgaLineValueUs { get; set; }
        [XmlElement("CURRENCY")]
        public string Currency { get; set; }
        [XmlElement("EXCHANGE_RATE")]
        public decimal? ExchangeRate { get; set; }
        [XmlElement("PACKAGING_QUANTITY_1")]
        public decimal? PackagingQuantity1 { get; set; }
        [XmlElement("PACKAGING_QUANTITY_2")]
        public decimal? PackagingQuantity2 { get; set; }
        [XmlElement("PACKAGING_QUANTITY_3")]
        public decimal? PackagingQuantity3 { get; set; }
        [XmlElement("PACKAGING_QUANTITY_4")]
        public decimal? PackagingQuantity4 { get; set; }
        [XmlElement("PACKAGING_QUANTITY_5")]
        public decimal? PackagingQuantity5 { get; set; }
        [XmlElement("PACKAGING_QUANTITY_6")]
        public decimal? PackagingQuantity6 { get; set; }
        [XmlElement("PACKAGIN_UOM_CD_1")]
        public string PackagingUomCd1 { get; set; }
        [XmlElement("PACKAGIN_UOM_CD_2")]
        public string PackagingUomCd2 { get; set; }
        [XmlElement("PACKAGIN_UOM_CD_3")]
        public string PackagingUomCd3 { get; set; }
        [XmlElement("PACKAGIN_UOM_CD_4")]
        public string PackagingUomCd4 { get; set; }
        [XmlElement("PACKAGIN_UOM_CD_5")]
        public string PackagingUomCd5 { get; set; }
        [XmlElement("PACKAGIN_UOM_CD_6")]
        public string PackagingUomCd6 { get; set; }
        [XmlElement("PACKAGING_IDENTIFIER_1")]
        public string PackagingIdentifier1 { get; set; }
        [XmlElement("PACKAGING_IDENTIFIER_2")]
        public string PackagingIdentifier2 { get; set; }
        [XmlElement("PACKAGING_IDENTIFIER_3")]
        public string PackagingIdentifier3 { get; set; }
        [XmlElement("PACKAGING_IDENTIFIER_4")]
        public string PackagingIdentifier4 { get; set; }
        [XmlElement("PACKAGING_IDENTIFIER_5")]
        public string PackagingIdentifier5 { get; set; }
        [XmlElement("PACKAGING_IDENTIFIER_6")]
        public string PackagingIdentifier6 { get; set; }
        [XmlElement("CONTAINER_DIMENSION_1")]
        public string ContainerDimension1 { get; set; }
        [XmlElement("CONTAINER_DIMENSION_2")]
        public string ContainerDimension2 { get; set; }
        [XmlElement("CONTAINER_DIMENSION_3")]
        public string ContainerDimension3 { get; set; }
        [XmlElement("PG_LINE_NET_QTY_UOM")]
        public string PgLineNetQtyUom { get; set; }
        [XmlElement("PG_LINE_NET_QTY")]
        public decimal? PgLineNetQty { get; set; }
        [XmlElement("PG_LINE_GROSS_QTY_UOM")]
        public string PgLineGrossQtyUom { get; set; }
        [XmlElement("PG_LINE_GROSS_QTY")]
        public decimal? PgLineGrossQty { get; set; }
        [XmlElement("UNIT_NET_QTY_UOM")]
        public string UnitNetQtyUom { get; set; }
        [XmlElement("UNIT_NET_QTY")]
        public decimal? UnitNetQty { get; set; }
        [XmlElement("UNIT_GROSS_QTY_UOM")]
        public string UnitGrossQtyUom { get; set; }
        [XmlElement("UNIT_GROSS_QTY")]
        public decimal? UnitGrossQty { get; set; }
        [XmlElement("ANTICIPATED_ARRIVAL_DATE")]
        public string AnticipatedArrivalDate { get; set; }
        [XmlElement("ANTICIPATED_ARRIVAL_TIME")]
        public string AnticipatedarrivalTime { get; set; }
        [XmlElement("ANTICIPATED_ARRIVAL_PORT_CD")]
        public string AnticipatedArrivalPortCd { get; set; }
        [XmlElement("ANTICIPATED_ARRIVAL_LOC")]
        public string AnticipatedArrivalLoc { get; set; }
        [XmlElement("LICENSE_PLATE_NO")]
        public string LicensePlateNo { get; set; }
        [XmlElement("LICENSE_PLATE_COUNTRY_CD")]
        public string LicensePlateCountryCd { get; set; }
        [XmlElement("LICENSE_PLATE_STATE_PROVINCE")]
        public string LicensePlateStateProvince { get; set; }
        [XmlElement("LICENSE_PLATE_ISSUER")]
        public string LicensePlateIssuer { get; set; }
        [XmlElement("LICENSE_PLATE_LOC_TYPE_CD")]
        public string LicensePlateLocTypeCd { get; set; }
        [XmlElement("INCLUDE_PRIOR_NOTICE")]
        public string IncludePriorNotice { get; set; }
        [XmlElement("PRIOR_NOTICE_CONFIRMATION_NO")]
        public string PriorNoticeConfirmationNo { get; set; }
        [XmlElement("IS_USER_ENTERED_PN_CONF_NO")]
        public string IsUserEnteredPnConfNo { get; set; }
        [XmlElement("EXPRESS_TRACKING_NO")]
        public string ExpressTrackingNo { get; set; }
        [XmlElement("FTZ_FIRMS_CD")]
        public string FtzFirmsCd { get; set; }
        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgFdaEsParties
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("PARTY_SEQ_NBR")]
        public decimal? PartySeqNbr { get; set; }
        [XmlElement("PARTY_ROLE")]
        public string PartyRole { get; set; }
        [XmlElement("PARTY_CUST_NO")]
        public string PartyCustNo { get; set; }
        [XmlElement("PARTY_ADDRESS_NO")]
        public decimal? PartyAddressNo { get; set; }
        [XmlElement("PARTY_CONTACT_NO")]
        public decimal? PartyContactNo { get; set; }
        [XmlElement("PARTY_CARRIER_CD")]
        public string PartyCarrierCd { get; set; }
        [XmlElement("PARTY_FIRMS_CD")]
        public string PartyFirmsCd { get; set; }
        [XmlElement("PARTY_MID_CD")]
        public string PartyMidCd { get; set; }
        [XmlElement("PARTY_ESTABLISHMENT_NO")]
        public string PartyEstablishmentNo { get; set; }
        [XmlElement("PARTY_ASSEMBLER_CD")]
        public string PartyAssemblerCd { get; set; }
        [XmlElement("PARTY_IRS_NO")]
        public string PartyIrsNo { get; set; }
        [XmlElement("PARTY_NUMBER")]
        public string PartyNumber { get; set; }
        [XmlElement("PARTY_NUMBER_TYPE")]
        public string PartyNumberType { get; set; }
        [XmlElement("PARTY_NAME")]
        public string PartyName { get; set; }
        [XmlElement("PARTY_ADDRESS_LINE_1")]
        public string PartyAddressLine1 { get; set; }
        [XmlElement("PARTY_ADDRESS_LINE_2")]
        public string PartyAddressLine2 { get; set; }
        [XmlElement("PARTY_CITY")]
        public string PartyCity { get; set; }
        [XmlElement("PARTY_STATE_PROVINCE")]
        public string PartyStateProvince { get; set; }
        [XmlElement("PARTY_COUNTRY")]
        public string PartyCountry { get; set; }
        [XmlElement("PARTY_POSTAL_CD")]
        public string PartyPostalCd { get; set; }
        [XmlElement("PARTY_INDIVIDUAL_NAME")]
        public string PartyIndividualName { get; set; }
        [XmlElement("PARTY_PHONE_NO")]
        public string PartyPhoneNo { get; set; }
        [XmlElement("PARTY_FAX_NO")]
        public string PartyFaxNo { get; set; }
        [XmlElement("PARTY_EMAIL_ADDRESS")]
        public string PartyEmailAddress { get; set; }
        [XmlElement("PARTY_CD")]
        public string PartyCd { get; set; }
        [XmlElement("CONTACT_TYPE")]
        public string ContactType { get; set; }
        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgFdaEsCountries
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("COUNTRY_SEQ_NBR")]
        public decimal? CountrySeqNbr { get; set; }
        [XmlElement("COUNTRY_CD")]
        public string CountryCd { get; set; }
        [XmlElement("COUNTRY_TYPE_CD")]
        public string CountryTypeCd { get;set; }
        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgFdaEsContainers
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("CONTAINER_NO")]
        public string ContainerNo { get; set; }
        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgFdaEsCompliance
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("COMPLIANCE_SEQ_NBR")]
        public decimal? ComplianceSeqNbr { get; set; }
        [XmlElement("COMPLIANCE_CODE")]
        public string ComplianceCode { get; set; }
        [XmlElement("COMPLIANCE_QUALIFIER")]
        public string ComplianceQualifier { get; set; }
        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgFdaEsIngredients
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("INGREDIENT_SEQ_NBR")]
        public decimal? IngredientSeqNbr { get; set; }
        [XmlElement("IS_ACTIVE_INGREDIENT")]
        public string IsActiveIngredient { get; set; }
        [XmlElement("INGREDIENT_NAME")]
        public string IngredientName { get; set; }
        [XmlElement("INGREDIENT_QTY")]
        public string IngredientQty { get; set; }
        [XmlElement("INGREDIENT_UOM")]
        public string IngredientUom { get; set; }
        [XmlElement("INGREDIENT_PERCENT")]
        public decimal? IngredientPercent { get; set; }
        [XmlElement("SCIENTIFIC_GENUS_NAME")]
        public string ScientificGenusName { get; set; }
        [XmlElement("SCIENTIFIC_SPECIES_NAME")]
        public string ScientificSpeciesName { get; set; }
        [XmlElement("SCIENTIFIC_SUB_SPECIES_NAME")]
        public string ScientificSubSpeciesName { get; set; }
        [XmlElement("TRADE_BRAND_NAME")]
        public string TradeBrandName { get; set; }
        [XmlElement("COUNTRY_CD")]
        public string CountryCd { get; set; }
        [XmlElement("COUNTRY_TYPE_CD")]
        public string CountryTypeCd { get; set; }
        [XmlElement("PRODUCT_DESCR")]
        public string ProductDescr { get; set; }
        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgFdaEsRemarks
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("REMARKS_SEQ_NBR")]
        public decimal? RemarksSeqNbr { get; set; }
        [XmlElement("REMARKS_TYPE_CD")]
        public string RemarksTypeCd { get; set; }
        [XmlElement("REMARKS_TEXT")]
        public string RemarksText { get; set; }
        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgFdaEsAddlLots
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("LOT_SEQ_NBR")]
        public decimal? LotSeqNbr { get; set; }
        [XmlElement("TEMPERATURE_QUALIFIER")]
        public string TemperatureQualifier { get; set; }
        [XmlElement("DEGREE_TYPE_CD")]
        public string DegreeTypeCd { get; set; }
        [XmlElement("IS_NEGATIVE_TEMP")]
        public string IsNegativeTemp { get; set; }
        [XmlElement("ACTUAL_TEMPERATURE")]
        public decimal? ActualTemperature { get; set; }
        [XmlElement("TEMPERATURE_LOCATION_CD")]
        public string TemperatureLocationCd { get; set; }
        [XmlElement("LOT_NUMBER_QUALIFIER_CD")]
        public string LotNumberQualifierCd { get; set; }
        [XmlElement("LOT_NUMBER")]
        public string LotNumber { get; set; }
        [XmlElement("LOT_PRODUCTION_START_DATE")]
        public string LotProductionStartDate { get; set; }
        [XmlElement("LOT_PRODUCTION_END_DATE")]
        public string LotProductionEndDate { get; set; }
        [XmlElement("PGA_LINE_VALUE")]
        public decimal? PgaLineValue { get; set; }
        [XmlElement("PGA_UNIT_VALUE")]
        public decimal? PgaUnitValue { get; set; }
        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    #endregion   
    #region NHTSA

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class NhtsaEs
    {
        [XmlElement("EDI_NHTSA_ES_PARTIES")]
        public PgEpaEsParties[] NhtsaParties { get; set; }
        [XmlElement("EDI_NHTSA_ES_REMARKS")]
        public PgEpaEsParties[] NhtsaRemarks { get; set; }
        [XmlElement("EDI_NHTSA_ES_PRODCUT")]
        public PgEpaEsParties[] NhtsaProduct { get; set; }
        [XmlElement("EDI_NHTSA_ES_DOCUMENTS")]
        public PgEpaEsParties[] NhtsaDocuments { get; set; }

        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("BOX_NO")]
        public string BoxNo { get; set; }
        [XmlElement("ENTITY_ROLE_CD")]
        public string EntityRoleCd { get; set; }
        [XmlElement("DATE_SIGNATURE")]
        public string DateSignature { get; set; }
        [XmlElement("PASSPORT_NO")]
        public string PassportNo { get; set; }
        [XmlElement("PASSPORT_COUNTRY_NO")]
        public string PassportCountryNo { get; set; }
        [XmlElement("SURETY_CD")]
        public string SuretyCd { get; set; }
        [XmlElement("BOND_NO")]
        public string BondNo { get; set; }
        [XmlElement("BOND_TYPE_CD")]
        public string BondTypeCd { get; set; }
        [XmlElement("BOND_AMT")]
        public decimal? BondAmt { get; set; }
        [XmlElement("IMPORT_PERMISSION_LETTER")]
        public string ImportPermissionLetter { get; set; }
        [XmlElement("PERMISSION_LETTER_QUANTITY")]
        public decimal? PermissionLetterQuantity { get; set; }
        [XmlElement("PERMISSION_LETTER_QTY_UOM_CD")]
        public string PermissionLetterQtyUomCd { get; set; }
        [XmlElement("PERMISSION_LETTER_SIGN_DATE")]
        public string PermissionLetterSignDate { get; set; }
        [XmlElement("REGISTERED_IMPORTER_NO")]
        public string RegisteredImporterNo { get; set; }
        [XmlElement("VEHICLE_ELIGIBILITY_NO")]
        public string VehicleEligibilityNo { get; set; }
        [XmlElement("EMBASSY_COUNTRY_CD")]
        public string EmbassyCountryCd { get; set; }
        [XmlElement("IS_ORIGINAL_VEHICLE_MFG")]
        public string IsOriginalVehicleMfg { get; set; }
        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("MODIFIED_TIME")]
        public string ModifiedTime { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class NhtsaEsParties
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("PARTY_SEQ_NBR")]
        public decimal? PartySeqNbr { get; set; }
        [XmlElement("PARTY_ROLE")]
        public string PartyRole { get; set; }
        [XmlElement("PARTY_CUST_NO")]
        public string PartyCustNo { get; set; }
        [XmlElement("PARTY_ADDRESS_NO")]
        public decimal? PartyAddressNo { get; set; }
        [XmlElement("PARTY_CONTACT_NO")]
        public decimal? PartyContactNo { get; set; }
        [XmlElement("PARTY_CARRIER_CD")]
        public string PartyCarrierCd { get; set; }
        [XmlElement("PARTY_FIRMS_CD")]
        public string PartyFirmsCd { get; set; }
        [XmlElement("PARTY_MID_CD")]
        public string PartyMidCd { get; set; }
        [XmlElement("PARTY_ESTABLISHMENT_NO")]
        public string PartyEstablishmentNo { get; set; }
        [XmlElement("PARTY_ASSEMBLER_CD")]
        public string PartyAssemblerCd { get; set; }
        [XmlElement("PARTY_IRS_NO")]
        public string PartyIrsNo { get; set; }
        [XmlElement("PARTY_NUMBER")]
        public string PartyNumber { get; set; }
        [XmlElement("PARTY_NUMBER_TYPE")]
        public string PartyNumberType { get; set; }
        [XmlElement("PARTY_NAME")]
        public string PartyName { get; set; }
        [XmlElement("PARTY_ADDRESS_LINE_1")]
        public string PartyAddressLine1 { get; set; }
        [XmlElement("PARTY_ADDRESS_LINE_2")]
        public string PartyAddressLine2 { get; set; }
        [XmlElement("PARTY_CITY")]
        public string PartyCity { get; set; }
        [XmlElement("PARTY_STATE_PROVINCE")]
        public string PartyStateProvince { get; set; }
        [XmlElement("PARTY_COUNTRY")]
        public string PartyCountry { get; set; }
        [XmlElement("PARTY_POSTAL_CD")]
        public string PartyPostalCd { get; set; }
        [XmlElement("PARTY_INDIVIDUAL_NAME")]
        public string PartyIndividualName { get; set; }
        [XmlElement("PARTY_PHONE_NO")]
        public string PartyPhoneNo { get; set; }
        [XmlElement("PARTY_FAX_NO")]
        public string PartyFaxNo { get; set; }
        [XmlElement("PARTY_EMAIL_ADDRESS")]
        public string PartyEmailAddress { get; set; }
        [XmlElement("PARTY_CD")]
        public string PartyCd { get; set; }
        [XmlElement("CONTACT_TYPE")]
        public string ContactType { get; set; }
        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("MODIFIED_TIME")]
        public string ModifiedTime { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class NhtsaEsRemarks
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }

        [XmlElement("REMARKS_SEQ_NBR")]
        public decimal? RemarksSeqNbr { get; set; }
        [XmlElement("REMARKS_TYPE_CD")]
        public string RemarksTypeCd { get; set; }
        [XmlElement("REMARKS_CD")]
        public string RemarksCd { get; set; }
        [XmlElement("REMARKS_TEXT")]
        public string RemarksText { get; set; }

        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class NhtsaEsProduct
    {
        [XmlElement("EDI_NHTSA_ES_ADDL_ITEM_ID")]
        public NhtsaEsAddlItemId[] NhtsaEsAddlItems { get; set; }

        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("PRODUCT_SEQ_NBR")]
        public decimal? ProductSeqNbr { get; set; }
        [XmlElement("TRADE_BRAND_NAME")]
        public string TradeBrandName { get; set; }
        [XmlElement("MODEL")]
        public string Model { get; set; }
        [XmlElement("MODEL_YEAR")]
        public decimal? ModelYear { get; set; }
        [XmlElement("MANUFACTURE_MONTH_YEAR")]
        public decimal? ManufactureMonthYear { get; set; }
        [XmlElement("DRIVE_SIDE")]
        public string DriveSide { get; set; }
        [XmlElement("ITEM_IDENTITY_QUAL")]
        public string ItemIdentityQual { get; set; }
        [XmlElement("ITEM_IDENTITY_NBR")]
        public string ItemIdentityNbr { get; set; }
        [XmlElement("CATEGORY_TYPE_CD")]
        public string CategoryTypeCd { get; set; }
        [XmlElement("CATEGORY_CD")]
        public string CategoryCd { get; set; }
        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class NhtsaEsAddlItemId
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }

        [XmlElement("PRODUCT_SEQ_NBR")]
        public decimal? ProductSeqNbr { get; set; }
        [XmlElement("ITEM_ID_SEQ_NBR")]
        public decimal? ItemIdSeqNbr { get; set; }
        [XmlElement("ITEM_IDENTITY_NBR")]
        public string ItemIdentityNbr { get; set; }

        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class NhtsaEsDocuments
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }

        [XmlElement("DOCUMENT_SEQ_NBR")]
        public decimal? DocumentSeqNbr { get; set; }
        [XmlElement("DOCUMENT_ID_CD")]
        public string DocumentIdCd { get; set; }
        [XmlElement("ENTITY_ROLE_CD")]
        public string EntityRoleCd { get; set; }
        [XmlElement("DATE_SIGNATURE")]
        public string DateSignature { get; set; }

        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    #endregion
    #region APHIS

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgAphisEs
    {
        [XmlElement("EDI_PG_APHIS_ES_PERMITS")]
        public PgAphisEsPermits[] PgAphisEsPermits { get; set; }
        [XmlElement("EDI_PG_APHIS_ES_CONTAINERS")]
        public PgAphisEsContainers[] PgAphisEsContainers { get; set; }
        [XmlElement("EDI_PG_APHIS_ES_COMPONENTS")]
        public PgAphisEsComponents[] PgAphisEsComponents { get; set; }
        [XmlElement("EDI_PG_APHIS_ES_PARTIES")]
        public PgAphisEsParties[] PgAphisEsParties { get; set; }
        [XmlElement("EDI_PG_APHIS_ES_DOCUMENTS")]
        public PgAphisEsDocuments[] PgAphisEsDocuments { get; set; }
        [XmlElement("EDI_PG_APHIS_ES_ROUTING")]
        public PgAphisEsRouting[] PgAphisEsRouting { get; set; }
        [XmlElement("EDI_PG_APHIS_ES_REMARKS")]
        public PgAphisEsRemarks[] PgAphisEsRemarks { get; set; }
        [XmlElement("EDI_PG_APHIS_ES_INSPECTION")]
        public PgAphisEsInspection[] PgAphisEsInspection { get; set; }


        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }

        [XmlElement("PG_SEQ_NBR")]
        public decimal? ProductSeqNbr { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public string DetailedDescription { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? LineValue { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public string UseQtyForSpeciesCountry { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public string DeclarationEntityCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public string DeclarationCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public string DeclarationCert { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public string DateSignature { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? ImporterAddressNo { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? ImporterContactNo { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public string ImporterIndividualName { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public string ImporterPhoneNo { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public string ImporterFaxNo { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public string ImporterEmailAddress { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public string ImporterName { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public string ImporterAddressLine1 { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public string ImporterCity { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public string ImporterStateProvince { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public string ImporterCountry { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public string ImporterPostalCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public string PartyRole { get; set; }
        [XmlElement("PRODUCT_CODE_QUAL_1")]
        public string ProductCodeQual1 { get; set; }
        [XmlElement("PRODUCT_CODE_ID_1")]
        public string ProductCodeId1 { get; set; }
        [XmlElement("PRODUCT_CODE_QUAL_2")]
        public string ProductCodeQual2 { get; set; }
        [XmlElement("PRODUCT_CODE_ID_2")]
        public string ProductCodeId2 { get; set; }
        [XmlElement("PRODUCT_CODE_QUAL_3")]
        public string ProductCodeQual3 { get; set; }
        [XmlElement("PRODUCT_CODE_ID_3")]
        public string ProductCodeId3 { get; set; }
        [XmlElement("PRODUCT_CODE_QUAL_4")]
        public string ProductCodeQual4 { get; set; }
        [XmlElement("PRODUCT_CODE_ID_4")]
        public string ProductCodeId4 { get; set; }
        [XmlElement("PACKAGING_QUANTITY_1")]
        public string PackagingQuantity1 { get; set; }
        [XmlElement("PACKAGING_UOM_CD_1")]
        public string PackagingUomCd1 { get; set; }
        [XmlElement("PACKAGING_QUANTITY_2")]
        public string PackagingQuantity2 { get; set; }
        [XmlElement("PACKAGING_UOM_CD_2")]
        public string PackagingUomCd2 { get; set; }
        [XmlElement("PACKAGING_QUANTITY_3")]
        public string PackagingQuantity3 { get; set; }
        [XmlElement("PACKAGING_UOM_CD_3")]
        public string PackagingUomCd3 { get; set; }
        [XmlElement("PACKAGING_QUANTITY_4")]
        public string PackagingQuantity4 { get; set; }
        [XmlElement("PACKAGING_UOM_CD_4")]
        public string PackagingUomCd4 { get; set; }
        [XmlElement("PACKAGING_QUANTITY_5")]
        public string PackagingQuantity5 { get; set; }
        [XmlElement("PACKAGING_UOM_CD_5")]
        public string PackagingUomCd5 { get; set; }
        [XmlElement("PACKAGING_QUANTITY_6")]
        public string PackagingQuantity6 { get; set; }
        [XmlElement("PACKAGING_UOM_CD_6")]
        public string PackagingUomCd6 { get; set; }
        [XmlElement("PRODUCT_CATEGORY_TYPE_CD")]
        public string ProductCategoryTypeCd { get; set; }

        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgAphisEsPermits
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }

        [XmlElement("PRODUCT_SEQ_NBR")]
        public decimal? ProductSeqNbr { get; set; }
        [XmlElement("PERMIT_SEQ_NBR")]
        public decimal? PermitSeqNbr { get; set; }
        [XmlElement("PERMIT_TYPE")]
        public string PermitType { get; set; }
        [XmlElement("PERMIT_TYPE_CD")]
        public string PermitTypeCd { get; set; }
        [XmlElement("PERMIT_NUMBER")]
        public string PermitNumber { get; set; }
        [XmlElement("PERMIT_DATE_TYPE")]
        public string PermitDateType { get; set; }
        [XmlElement("PERMIT_DATE")]
        public string PermitDate { get; set; }

        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgAphisEsContainers
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("PRODUCT_SEQ_NBR")]
        public decimal? ProductSeqNbr { get; set; }

        [XmlElement("CONTAINER_NO")]
        public string ContainerNo { get; set; }

        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgAphisEsParties
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("PRODUCT_SEQ_NBR")]
        public decimal? ProductSeqNbr { get; set; }
        [XmlElement("PARTY_SEQ_NBR")]
        public decimal? PartySeqNbr { get; set; }
        [XmlElement("PARTY_ROLE")]
        public string PartyRole { get; set; }
        [XmlElement("PARTY_CUST_NO")]
        public string PartyCustNo { get; set; }
        [XmlElement("PARTY_ADDRESS_NO")]
        public decimal? PartyAddressNo { get; set; }
        [XmlElement("PARTY_CONTACT_NO")]
        public decimal? PartyContactNo { get; set; }
        [XmlElement("PARTY_CARRIER_CD")]
        public string PartyCarrierCd { get; set; }
        [XmlElement("PARTY_FIRMS_CD")]
        public string PartyFirmsCd { get; set; }
        [XmlElement("PARTY_MID_CD")]
        public string PartyMidCd { get; set; }
        [XmlElement("PARTY_ESTABLISHMENT_NO")]
        public string PartyEstablishmentNo { get; set; }
        [XmlElement("PARTY_ASSEMBLER_CD")]
        public string PartyAssemblerCd { get; set; }
        [XmlElement("PARTY_IRS_NO")]
        public string PartyIrsNo { get; set; }
        [XmlElement("PARTY_NUMBER")]
        public string PartyNumber { get; set; }
        [XmlElement("PARTY_NUMBER_TYPE")]
        public string PartyNumberType { get; set; }
        [XmlElement("PARTY_NAME")]
        public string PartyName { get; set; }
        [XmlElement("PARTY_ADDRESS_LINE_1")]
        public string PartyAddressLine1 { get; set; }
        [XmlElement("PARTY_ADDRESS_LINE_2")]
        public string PartyAddressLine2 { get; set; }
        [XmlElement("PARTY_CITY")]
        public string PartyCity { get; set; }
        [XmlElement("PARTY_STATE_PROVINCE")]
        public string PartyStateProvince { get; set; }
        [XmlElement("PARTY_COUNTRY")]
        public string PartyCountry { get; set; }
        [XmlElement("PARTY_POSTAL_CD")]
        public string PartyPostalCd { get; set; }
        [XmlElement("PARTY_INDIVIDUAL_NAME")]
        public string PartyIndividualName { get; set; }
        [XmlElement("PARTY_PHONE_NO")]
        public string PartyPhoneNo { get; set; }
        [XmlElement("PARTY_FAX_NO")]
        public string PartyFaxNo { get; set; }
        [XmlElement("PARTY_EMAIL_ADDRESS")]
        public string PartyEmailAddress { get; set; }
        [XmlElement("PARTY_CD")]
        public string PartyCd { get; set; }
        [XmlElement("CONTACT_TYPE")]
        public string ContactType { get; set; }

        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgAphisEsDocuments
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }

        [XmlElement("PRODUCT_SEQ_NBR")]
        public decimal? ProductSeqNbr { get; set; }
        [XmlElement("DOCUMNENT_SEQ_NBR")]
        public decimal? DocumentSeqNbr { get; set; }
        [XmlElement("DOCUMENT_ID_CD")]
        public string DocumentIdCd { get; set; }
        [XmlElement("ENTITY_ROLE_CD")]
        public string EntityRoleCd { get; set; }
        [XmlElement("DATE_SIGNATURE")]
        public decimal? DateSignature { get; set; }
        [XmlElement("SUPPORTING_DOCUMENT")]
        public string SuupportingDocument { get; set; }
        [XmlElement("CONFORMANCE_DECLARATION")]
        public string ConformanceDeclaration { get; set; }
        [XmlElement("DECLARATION_CD")]
        public string DeclarationCd { get; set; }
        [XmlElement("DECLARATION_CERTIFICATION")]
        public string DeclarationCertification { get; set; }
        [XmlElement("INVOICE_NUMBER")]
        public string InvoiceNumber { get; set; }
        [XmlElement("COMPLIANCE_DESCRIPTION")]
        public string ComplianceDescription { get; set; }

        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgAphisEsRouting
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }

        [XmlElement("PRODUCT_SEQ_NBR")]
        public decimal? ProductSeqNbr { get; set; }
        [XmlElement("ROUTING_SEQ_NBR")]
        public decimal? RoutingSeqNbr { get; set; }
        [XmlElement("ROUTING_TYPE_CD")]
        public string RoutingTypeCd { get; set; }
        [XmlElement("ROUTING_COUNTRY_CD")]
        public string RoutingCountryCd { get; set; }
        [XmlElement("ROUTING_STATE_PROV")]
        public string RoutingStateProv { get;set; }

        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgAphisEsRemarks
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }

        [XmlElement("PRODUCT_SEQ_NBR")]
        public decimal? ProductSeqNbr { get; set; }
        [XmlElement("REMARKS_SEQ_NBR")]
        public decimal? RemarksSeqNbr { get; set; }
        [XmlElement("REMARKS_TYPE_CD")]
        public string RemarksTypeCd { get; set; }
        [XmlElement("REMARKS_CD")]
        public string RemarksCd { get; set; }
        [XmlElement("REMARKS_TEXT")]
        public string RemarksText { get; set; }

        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgAphisEsInspection
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("PRODUCT_SEQ_NBR")]
        public decimal? ProductSeqNbr { get; set; }

        [XmlElement("INSPECTION_SEQ_NBR")]
        public decimal? InspectionSeqNbr { get; set; }
        [XmlElement("INSPACTION_STATUS_CD")]
        public string InspectionStatusCd { get; set; }
        [XmlElement("INSPECTION_ARRIVAL_DATE")]
        public decimal? InspectionArrivalDate { get; set; }
        [XmlElement("INSPECTION_ARRIVAL_LOC_TYPE_CD")]
        public string InspectionArrivalLocTypeCd { get; set; }
        [XmlElement("INSPECTION_ARRIVAL_LOC")]
        public string InspectionArrivalLoc { get; set; }

        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgAphisEsComponents
    {
        [XmlElement("EDI_PG_APHIS_ES_ADDL_COUNTRIES")]
        public PgAphisEsAddlCountries[] PgAphisEsAddlCountries { get; set; }
        [XmlElement("EDI_PG_APHIS_ES_ADD_SCIENTIFIC")]
        public PgAphisEsAddScientific[] PgAphisEsAddScientific { get; set; }
        [XmlElement("EDI_PG_APHIS_ES_COUNTRIES")]
        public PgAphisEsCountries[] PgAphisEsCountries { get; set; }
        [XmlElement("EDI_PG_APHIS_ES_CMDTY_CHAR")]
        public PgAphisEsCmdtyChar[] PgAphisEsCmdtyChar { get; set; }
        [XmlElement("EDI_PG_APHIS_ES_ITEM_ID")]
        public PgAphisEsItemId[] PgAphisEsItemId { get; set; }

        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("PRODUCT_SEQ_NBR")]
        public decimal? ProductSeqNbr { get; set; }
        [XmlElement("COMPONENT_SEQ_NBR")]
        public decimal? ComponentSeqNbr { get; set; }

        [XmlElement("COMPONENT_NAME")]
        public string ComponentName { get; set; }
        [XmlElement("COMPONENT_UOM")]
        public string ComponentUom { get; set; }
        [XmlElement("SCIENTIFIC_GENUS_NAME")]
        public string ScientificGenusName { get; set; }
        [XmlElement("SCIENTIFIC_SPECIES_NAME")]
        public string ScientificSpeciesName { get; set; }
        [XmlElement("COUNTRY_HARVESTED")]
        public string CountryHarvested { get; set; }

        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgAphisEsAddlCountries
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("PRODUCT_SEQ_NBR")]
        public decimal? ProductSeqNbr { get; set; }
        [XmlElement("COMPONENT_SEQ_NBR")]
        public decimal? ComponentSeqNbr { get; set; }

        [XmlElement("COUNTRY_HARVESTED")]
        public string CountryHarvested { get; set; }

        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgAphisEsAddScientific
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("PRODUCT_SEQ_NBR")]
        public decimal? ProductSeqNbr { get; set; }

        [XmlElement("COMPONENT_SEQ_NBR")]
        public decimal? ComponentSeqNbr { get; set; }
        [XmlElement("SCIENTIFIC_SEQ_NBR")]
        public decimal? ScientificSeqNbr { get; set; }
        [XmlElement("SCIENTIFIC_GENUS_NAME")]
        public string ScientificGenusName { get; set; }
        [XmlElement("SCIENTIFIC_SPECIES_NAME")]
        public string ScientificSpeciesName { get; set; }

        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgAphisEsCountries
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }
        [XmlElement("PRODUCT_SEQ_NBR")]
        public decimal? ProductSeqNbr { get; set; }

        [XmlElement("COMPONENT_SEQ_NBR")]
        public decimal? ComponentSeqNbr { get; set; }
        [XmlElement("COUNTRY_SEQ_NBR")]
        public decimal? CountrySeqNbr { get; set; }
        [XmlElement("COUNTRY_CD")]
        public string CountryCd { get; set; }
        [XmlElement("COUNTRY_TYPE_CD")]
        public string CountryTypeCd { get; set; }
        [XmlElement("GEOGRAPHIC_LOCATION")]
        public string GeographicLocation { get; set; }
        [XmlElement("PROCESSING_START_DATE")]
        public decimal? ProcessingStartDate { get; set; }
        [XmlElement("PROCESSING_STOP_DATE")]
        public decimal? ProcessingStopDate { get; set; }
        [XmlElement("PROCESSING_DESCR")]
        public string ProcessingDescr { get; set; }

        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgAphisEsCmdtyChar
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }

        [XmlElement("PRODUCT_SEQ_NBR")]
        public decimal? ProductSeqNbr { get; set; }
        [XmlElement("COMPONENT_SEQ_NBR")]
        public decimal? ComponentSeqNbr { get; set; }
        [XmlElement("COMM_CHAR_SEQ_NBR")]
        public decimal? CommCharSeqNbr { get; set; }
        [XmlElement("CATEGORY_CD")]
        public string CategoryCd { get; set; }
        [XmlElement("COMMODITY_QUAL_CD")]
        public string CommodityQualCd { get; set; }
        [XmlElement("COMMODITY_CHAR_QUAL_CD")]
        public string CommodityCharQualCd { get; set; }
        [XmlElement("COMMODITY_CHAR_DESCR")]
        public string CommodityCharDescr { get; set; }

        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kewill.com/Customs/edi")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kewill.com/Customs/edi", IsNullable = false)]
    public partial class PgAphisEsItemId
    {
        [XmlElement("MANUFACTURER_ID")]
        public string ManufacturerId { get; set; }
        [XmlElement("COMM_INV_NO")]
        public string CommInvNo { get; set; }
        [XmlElement("DATE_INVOICE")]
        public string DateInvoice { get; set; }
        [XmlElement("COMM_INV_LINE_NO")]
        public int? CommInvLineNo { get; set; }
        [XmlElement("TARIFF_LINE_NO")]
        public string TariffLineNo { get; set; }
        [XmlElement("PG_CD")]
        public string PgCd { get; set; }
        [XmlElement("PG_SEQ_NBR")]
        public decimal? PgSeqNbr { get; set; }

        [XmlElement("PRODUCT_SEQ_NBR")]
        public decimal? ProductSeqNbr { get; set; }
        [XmlElement("COMPONENT_SEQ_NBR")]
        public decimal? ComponentSeqNbr { get; set; }
        [XmlElement("ITEM_ID_SEQ_NBR")]
        public decimal? ItemIdSeqNbr { get; set; }
        [XmlElement("ITEM_IDENTITY_NBR")]
        public string ItemIdentityNbr { get; set; }

        [XmlElement("CREATED_BY")]
        public string CreatedBy { get; set; }
        [XmlElement("CREATED_DATE")]
        public string CreatedDate { get; set; }
        [XmlElement("MODIFIED_BY")]
        public string ModifiedBy { get; set; }
        [XmlElement("MODIFIED_DATE")]
        public string ModifiedDate { get; set; }
        [XmlElement("DATE_UPDATED")]
        public string DateUpdated { get; set; }
        [XmlElement("TIME_UPDATED")]
        public string TimeUpdated { get; set; }
    }

    #endregion
    
    #endregion
    #endregion
}
