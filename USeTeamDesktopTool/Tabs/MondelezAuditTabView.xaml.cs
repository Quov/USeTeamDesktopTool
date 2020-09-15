using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using USeTeamDesktopTool.Data_Classes;
using USeTeamDesktopTool.Functions;

namespace USeTeamDesktopTool
{
    /// <summary>
    /// Interaction logic for AmazonAuditTabView.xaml
    /// </summary>
    public partial class MondelezAuditTabView : System.Windows.Controls.UserControl
    {
        public MondelezAuditTabView()
        {
            InitializeComponent();
        }

        private void SelectPartiesAdhoctBTN_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Select Parties Adhoc File";
            openFileDialog1.Multiselect = false;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string filename in openFileDialog1.FileNames)
                {
                    AssistReportTB.Text = filename;
                }
            }
        }

        private void SelectContainerAdhocBTN_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Select Container Adhoc File";
            openFileDialog1.Multiselect = false;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string filename in openFileDialog1.FileNames)
                {
                    PartDBTB.Text = filename;
                }
            }
        }

        private void RunAnalysisBTN_Click(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\Users\abuchanan.LII01\Desktop\";

            MondelezPartiesAdhoc newParties = new MondelezPartiesAdhoc();
            MondelezContainerAdhoc newContainers = new MondelezContainerAdhoc();
            MondelezOceanReport newReport = new MondelezOceanReport();

            newParties = LoadPartyAdhocData(AssistReportTB.Text);
            newContainers = LoadContainerAdhocData(PartDBTB.Text);

            List<string> uniqueFiles = new List<string>();

            #region SHIPMENT BASED

            foreach (PartyItem currentRecord in newParties.AllPartyItems)
            {
                if (currentRecord.FileNo != null)
                {
                    string matchingRecord = uniqueFiles.Where(x => x.Contains(currentRecord.FileNo)).FirstOrDefault();
                    if (matchingRecord == null)
                    {
                        uniqueFiles.Add(currentRecord.FileNo);
                        //Create new record in the report
                        OceanReportRecord newRecord = new OceanReportRecord();
                        newRecord.ContainerNumbers = new List<string>();
                        newRecord.CustomerRefs = new List<string>();
                        newRecord.FileNo = currentRecord.FileNo;

                        newRecord.BrokerReferenceNumber = currentRecord.BrokerFiler + "-" + currentRecord.EntryNo;
                        newRecord.Shipper = currentRecord.ManufacturerName;
                        newRecord.POEEstimatedArrivalDate = currentRecord.ArrivalDatePortofEntry;
                        newRecord.CustomsReleaseDate = currentRecord.ReleaseDate;
                        newRecord.MasterBills = currentRecord.MasterBill;
                        newRecord.HouseBillNumbers = currentRecord.HouseBill;
                        newRecord.OriginCountry = currentRecord.CountryOfOriginName;

                        if (currentRecord.PartyRole == "UC")
                        {
                            newRecord.Consignee = currentRecord.PartyAddressLine1 + ", " + currentRecord.PartyCity + ", " + currentRecord.PartyStateProvince + ", " + "UNITED STATES, " + currentRecord.PartyPostalCd;
                        }

                        newReport.AllRecords.Add(newRecord);
                    }
                    else
                    {
                        //Get current record to the report and append data
                        OceanReportRecord selectedRecord = newReport.AllRecords.FirstOrDefault(x => x.FileNo == currentRecord.FileNo);
                        if (selectedRecord.Consignee == null)
                        {
                            if (currentRecord.PartyRole == "UC")
                            {
                                selectedRecord.Consignee = currentRecord.PartyAddressLine1 + ", " + currentRecord.PartyCity + ", " + currentRecord.PartyStateProvince + ", " + "UNITED STATES, " + currentRecord.PartyPostalCd;
                            }
                        }
                        if (selectedRecord.OriginCountry != currentRecord.CountryOfOriginName && !selectedRecord.OriginCountry.Contains(currentRecord.CountryOfOriginName))
                        {
                            selectedRecord.OriginCountry = selectedRecord.OriginCountry + ", " + currentRecord.CountryOfOriginName;
                        }
                    }
                }
            }

            foreach (ContainerItem currentContainerRecord in newContainers.AllContainerItems)
            {
                OceanReportRecord selectedRecord = newReport.AllRecords.FirstOrDefault(x => x.FileNo == currentContainerRecord.FileNo);
                if (selectedRecord != null)
                {
                    if (currentContainerRecord.ContainerNo != null && currentContainerRecord.ContainerNo != "")
                    {
                        selectedRecord.ContainerNumbers.Add(currentContainerRecord.ContainerNo);
                    }
                    if (currentContainerRecord.Description1 != null && currentContainerRecord.Description1 != "")
                    {
                        selectedRecord.CustomerRefs.Add(currentContainerRecord.Description1);
                    }
                    selectedRecord.ModeOfTransportationDescription = currentContainerRecord.TransModeDesc;
                    selectedRecord.VesselName = currentContainerRecord.Vessel;
                    selectedRecord.VoyageFlightNumber = currentContainerRecord.VoyageFlight;
                    selectedRecord.PortOfLoad = currentContainerRecord.PortOfLadingName;
                    selectedRecord.PortOfDischarge = currentContainerRecord.PortOfUnladingName;
                    selectedRecord.Carrier = currentContainerRecord.Carrier;
                    selectedRecord.CarrierName = currentContainerRecord.CarrierName;
                    selectedRecord.SailDate = currentContainerRecord.ISFEstimate;
                    selectedRecord.EquipmentTypeSize = currentContainerRecord.ContainerType + " " + currentContainerRecord.ContainerSize;
                    selectedRecord.MerchandiseDescriptionString = currentContainerRecord.DescOfGoods;

                }

                if(selectedRecord == null)
                {
                    OceanReportRecord newRecord = new OceanReportRecord();
                    newRecord.ContainerNumbers = new List<string>();
                    newRecord.CustomerRefs = new List<string>();

                    if (currentContainerRecord.ContainerNo != null && currentContainerRecord.ContainerNo != "")
                    {
                        newRecord.ContainerNumbers.Add(currentContainerRecord.ContainerNo);
                    }
                    if (currentContainerRecord.Description1 != null && currentContainerRecord.Description1 != "")
                    {
                        newRecord.CustomerRefs.Add(currentContainerRecord.Description1);
                    }
                    newRecord.FileNo = currentContainerRecord.FileNo;
                    newRecord.ModeOfTransportationDescription = currentContainerRecord.TransModeDesc;
                    newRecord.VesselName = currentContainerRecord.Vessel;
                    newRecord.VoyageFlightNumber = currentContainerRecord.VoyageFlight;
                    newRecord.PortOfLoad = currentContainerRecord.PortOfLadingName;
                    newRecord.PortOfDischarge = currentContainerRecord.PortOfUnladingName;
                    newRecord.Carrier = currentContainerRecord.Carrier;
                    newRecord.CarrierName = currentContainerRecord.CarrierName;
                    newRecord.SailDate = currentContainerRecord.ISFEstimate;
                    newRecord.EquipmentTypeSize = currentContainerRecord.ContainerType + " " + currentContainerRecord.ContainerSize;
                    newRecord.POEEstimatedArrivalDate = currentContainerRecord.ArrivalDatePOE;
                    newRecord.CustomsReleaseDate = currentContainerRecord.ReleaseDate;
                    newRecord.BrokerReferenceNumber = currentContainerRecord.Filer + "-" + currentContainerRecord.EntryNo;
                    newRecord.MerchandiseDescriptionString = currentContainerRecord.DescOfGoods;

                    newRecord.MasterBills = currentContainerRecord.MasterBill;
                    newRecord.HouseBillNumbers = currentContainerRecord.PrimaryHouseBill;

                    newReport.AllRecords.Add(newRecord);
                }
            }

            #endregion

            #region CONTAINER BASED

            //foreach (ContainerItem currentContainerRecord in newContainers.AllContainerItems)
            //{
            //    OceanReportRecord newRecord = new OceanReportRecord();

            //    newRecord.ContainerNumbers = new List<string>();
            //    newRecord.CustomerRefs = new List<string>();

            //    if (currentContainerRecord.ContainerNo != null && currentContainerRecord.ContainerNo != "")
            //    {
            //        newRecord.ContainerNumbers.Add(currentContainerRecord.ContainerNo);
            //    }
            //    if (currentContainerRecord.Description1 != null && currentContainerRecord.Description1 != "")
            //    {
            //        newRecord.CustomerRefs.Add(currentContainerRecord.Description1);
            //    }

            //    newRecord.FileNo = currentContainerRecord.FileNo;
            //    newRecord.ModeOfTransportationDescription = currentContainerRecord.TransModeDesc;
            //    newRecord.VesselName = currentContainerRecord.Vessel;
            //    newRecord.VoyageFlightNumber = currentContainerRecord.VoyageFlight;
            //    newRecord.MerchandiseDescription = currentContainerRecord.DescOfGoods;
            //    newRecord.PortOfLoad = currentContainerRecord.PortOfLadingName;
            //    newRecord.PortOfDischarge = currentContainerRecord.PortOfUnladingName;
            //    newRecord.Carrier = currentContainerRecord.Carrier;
            //    newRecord.CarrierName = currentContainerRecord.CarrierName;
            //    newRecord.OriginCountry = currentContainerRecord.COO;
            //    newRecord.EquipmentTypeSize = currentContainerRecord.ContainerType + " " + currentContainerRecord.ContainerSize;
            //    newRecord.SailDate = currentContainerRecord.ISFEstimate;

            //    newReport.AllRecords.Add(newRecord);
            //}

            //foreach (OceanReportRecord reportRecord in newReport.AllRecords)
            //{
            //    if (reportRecord.ModeOfTransportationDescription != null && reportRecord.ModeOfTransportationDescription != "Air    Non-Container")
            //    {
            //        foreach (string container in reportRecord.ContainerNumbers)
            //        {
            //            PartyItem currentParty = newParties.AllPartyItems.Where(x => x.ContainerNumber == container).FirstOrDefault();

            //            if (currentParty != null)
            //            {
            //                reportRecord.BrokerReferenceNumber = currentParty.BrokerFiler + "-" + currentParty.EntryNo;
            //                reportRecord.Shipper = currentParty.ManufacturerName;
            //                reportRecord.POEEstimatedArrivalDate = currentParty.ArrivalDatePortofEntry;
            //                reportRecord.CustomsReleaseDate = currentParty.ReleaseDate;
            //                reportRecord.MasterBills = currentParty.MasterBill;
            //                reportRecord.HouseBillNumbers = currentParty.HouseBill;

            //                if (currentParty.PartyRole == "UC")
            //                {
            //                    reportRecord.Consignee = currentParty.PartyAddressLine1 + ", " + currentParty.PartyCity + ", " + currentParty.PartyStateProvince + ", " + "UNITED STATES, " + currentParty.PartyPostalCd;
            //                }
            //            }
            //        }
            //    }

            //    if (reportRecord.ModeOfTransportationDescription == "Air    Non-Container")
            //    {
            //        PartyItem currentParty = newParties.AllPartyItems.Where(x => x.FileNo == reportRecord.FileNo).FirstOrDefault();
            //        if (currentParty != null)
            //        {
            //            reportRecord.BrokerReferenceNumber = currentParty.BrokerFiler + "-" + currentParty.EntryNo;
            //            reportRecord.Shipper = currentParty.ManufacturerName;
            //            reportRecord.POEEstimatedArrivalDate = currentParty.ArrivalDatePortofEntry;
            //            reportRecord.CustomsReleaseDate = currentParty.ReleaseDate;
            //            reportRecord.MasterBills = currentParty.MasterBill;
            //            reportRecord.HouseBillNumbers = currentParty.HouseBill;

            //            if (currentParty.PartyRole == "UC")
            //            {
            //                reportRecord.Consignee = currentParty.PartyAddressLine1 + ", " + currentParty.PartyCity + ", " + currentParty.PartyStateProvince + ", " + "UNITED STATES, " + currentParty.PartyPostalCd;
            //            }
            //        }
            //    }
            //}

            #endregion

            foreach (OceanReportRecord currentSelection in newReport.AllRecords)
            {
                string containerstring = "";
                foreach (string currentContainer in currentSelection.ContainerNumbers)
                {
                    if (containerstring == "")
                    {
                        containerstring = currentContainer;
                    }
                    else
                    {
                        containerstring = containerstring + ", " + currentContainer;
                    }
                }
                currentSelection.ContainerString = containerstring;

                string customerrefstring = "";
                foreach (string currentCustRef in currentSelection.CustomerRefs)
                {
                    if (customerrefstring == "")
                    {
                        customerrefstring = currentCustRef;
                    }
                    else
                    {
                        customerrefstring = customerrefstring + ", " + currentCustRef;
                    }
                }

                if(customerrefstring.StartsWith("PO #"))
                {
                    customerrefstring = customerrefstring.Substring(4, customerrefstring.Length - 4);
                }
                else if (customerrefstring.StartsWith("PO# "))
                {
                    customerrefstring = customerrefstring.Substring(4, customerrefstring.Length - 4);
                }
                else if (customerrefstring.StartsWith("PO-"))
                {
                    customerrefstring = customerrefstring.Substring(3, customerrefstring.Length - 3);
                }
                else if (customerrefstring.StartsWith("PO"))
                {
                    customerrefstring = customerrefstring.Substring(2, customerrefstring.Length - 2);
                }
                else if (customerrefstring.StartsWith("PO - "))
                {
                    customerrefstring = customerrefstring.Substring(5, customerrefstring.Length - 5);
                }
                else if (customerrefstring.StartsWith("po"))
                {
                    customerrefstring = customerrefstring.Substring(2, customerrefstring.Length - 2);
                }
                else if (customerrefstring.StartsWith("PO#"))
                {
                    customerrefstring = customerrefstring.Substring(3, customerrefstring.Length - 3);
                }

                currentSelection.CustomerRefString = customerrefstring;
            }

            MondelezOceanReport newReport2 = new MondelezOceanReport();

            foreach (OceanReportRecord currentRecord in newReport.AllRecords)
            {
                if(currentRecord.ContainerNumbers.Count > 0)
                {
                    foreach(string containers in currentRecord.ContainerNumbers)
                    {
                        OceanReportRecord report2Record = new OceanReportRecord();
                        report2Record.ArrivalWeek = currentRecord.ArrivalWeek;
                        report2Record.BrokerReferenceNumber = currentRecord.BrokerReferenceNumber;
                        report2Record.Carrier = currentRecord.Carrier;
                        report2Record.CarrierName = currentRecord.CarrierName;
                        report2Record.Consignee = currentRecord.Consignee;
                        report2Record.ContainerNumbers = currentRecord.ContainerNumbers;
                        report2Record.ContainerString = containers;
                        report2Record.CustomerRefs = currentRecord.CustomerRefs;                        
                        report2Record.CustomsReleaseDate = currentRecord.CustomsReleaseDate;
                        report2Record.DONumber = currentRecord.DONumber;
                        report2Record.EquipmentTypeSize = currentRecord.EquipmentTypeSize;
                        report2Record.FileNo = currentRecord.FileNo;
                        report2Record.HouseBillNumbers = currentRecord.HouseBillNumbers;
                        report2Record.InlandCarrierName = currentRecord.InlandCarrierName;
                        report2Record.LatestComment = currentRecord.LatestComment;
                        report2Record.MasterBills = currentRecord.MasterBills;                        
                        report2Record.ModeOfTransportationDescription = currentRecord.ModeOfTransportationDescription;
                        report2Record.OffTerminalFreeTime = currentRecord.OffTerminalFreeTime;
                        report2Record.OriginCountry = currentRecord.OriginCountry;
                        report2Record.POEEstimatedArrivalDate = currentRecord.POEEstimatedArrivalDate;
                        report2Record.PortOfDischarge = currentRecord.PortOfDischarge;
                        report2Record.PortOfLoad = currentRecord.PortOfLoad;
                        report2Record.SailDate = currentRecord.SailDate;
                        report2Record.Shipper = currentRecord.Shipper;
                        report2Record.VesselName = currentRecord.VesselName;
                        report2Record.VoyageFlightNumber = currentRecord.VoyageFlightNumber;

                        report2Record.MerchandiseDescription = currentRecord.MerchandiseDescription;
                        report2Record.MerchandiseDescriptionString = currentRecord.MerchandiseDescriptionString;

                        ContainerItem currentContainer = newContainers.AllContainerItems.First(x => x.ContainerNo == containers);

                        report2Record.CustomerRefString = currentContainer.Description1;

                        if (report2Record.CustomerRefString.StartsWith("PO - "))
                        {
                            report2Record.CustomerRefString = report2Record.CustomerRefString.Substring(5, report2Record.CustomerRefString.Length - 5);
                        }
                        else if (report2Record.CustomerRefString.StartsWith("PO #") || report2Record.CustomerRefString.StartsWith("PO# ") || report2Record.CustomerRefString.StartsWith("po# "))
                        {
                            report2Record.CustomerRefString = report2Record.CustomerRefString.Substring(4, report2Record.CustomerRefString.Length - 4);
                        }
                        else if (report2Record.CustomerRefString.StartsWith("PO-") || report2Record.CustomerRefString.StartsWith("PO#"))
                        {
                            report2Record.CustomerRefString = report2Record.CustomerRefString.Substring(3, report2Record.CustomerRefString.Length - 3);
                        }
                        else if (report2Record.CustomerRefString.StartsWith("PO") || report2Record.CustomerRefString.StartsWith("po"))
                        {
                            report2Record.CustomerRefString = report2Record.CustomerRefString.Substring(2, report2Record.CustomerRefString.Length - 2);
                        }

                        newReport2.AllRecords.Add(report2Record);
                    }
                }
                else if (currentRecord.ContainerNumbers.Count < 0)
                {
                    OceanReportRecord report2Record = currentRecord;

                    newReport2.AllRecords.Add(report2Record);
                }
            }

            //foreach(OceanReportRecord finalRecord in newReport2.AllRecords)
            //{
            //    IEnumerable<PartyItem> matchingParties = newParties.AllPartyItems.Where(x => x.FileNo == finalRecord.FileNo &&  finalRecord.CustomerRefString.Contains(x.CustRef));
            //    foreach(PartyItem current in matchingParties)
            //    {
            //        if(finalRecord.MerchandiseDescription == null)
            //        {
            //            finalRecord.MerchandiseDescription = new List<String>();
            //            finalRecord.MerchandiseDescription.Add(current.ProductDescription);
            //        }
            //        else
            //        {
            //            finalRecord.MerchandiseDescription.Add(current.ProductDescription);
            //        }
            //        //ADD ALL RELEVANT DESCRIPTIONS TO LIST (KEEP UNIQUENESS)
                    
            //        //if(finalRecord.MerchandiseDescription == null)
            //        //{
            //        //    if(current.ProductDescription.Length > 19)
            //        //    {
            //        //        finalRecord.MerchandiseDescription = current.ProductDescription.Substring(0, 20);
            //        //    }
            //        //    else
            //        //    {
            //        //        finalRecord.MerchandiseDescription = current.ProductDescription;
            //        //    }

            //        //}
            //        //else
            //        //{
            //        //    if (current.ProductDescription.Length > 19)
            //        //    {
            //        //        if (finalRecord.MerchandiseDescription != current.ProductDescription.Substring(0, 20) && !finalRecord.MerchandiseDescription.Contains(current.ProductDescription.Substring(0, 20)))
            //        //        {
            //        //            finalRecord.MerchandiseDescription = finalRecord.MerchandiseDescription + ", " + current.ProductDescription.Substring(0, 20);
            //        //        }
            //        //    }
            //        //    else
            //        //    {
            //        //        if (finalRecord.MerchandiseDescription != current.ProductDescription && !finalRecord.MerchandiseDescription.Contains(current.ProductDescription))
            //        //        {
            //        //            finalRecord.MerchandiseDescription = finalRecord.MerchandiseDescription + ", " + current.ProductDescription;
            //        //        }
            //        //    }
            //        //}
            //    }
            //}

            //foreach(OceanReportRecord finalRecord2 in newReport2.AllRecords)
            //{
            //    if(finalRecord2.MerchandiseDescription != null)
            //    {
            //        foreach (String desc in finalRecord2.MerchandiseDescription)
            //        {
            //            if (finalRecord2.MerchandiseDescriptionString == null)
            //            {
            //                if(desc.Length > 19)
            //                {
            //                    finalRecord2.MerchandiseDescriptionString = desc.Substring(0,20);
            //                }
            //                else
            //                {
            //                    finalRecord2.MerchandiseDescriptionString = desc;
            //                }                           
            //            }
            //            else
            //            {
            //                if (desc.Length > 19)
            //                {
            //                    finalRecord2.MerchandiseDescriptionString = finalRecord2.MerchandiseDescriptionString + ", " + desc.Substring(0, 20);
            //                }
            //                else
            //                {
            //                    finalRecord2.MerchandiseDescriptionString = finalRecord2.MerchandiseDescriptionString + ", " + desc;
            //                }
                            
            //            }

            //        }
            //    }
                
            //}

            DataTable table = new DataTable();
            table = ToDataTable<OceanReportRecord>(newReport2.AllRecords);
            DataGridViewDG.ItemsSource = newReport2.AllRecords;

            #region commentedout
            //double totalItems = newErrors.AllAssistErrors.Count();
            //double totalErrorItems = newErrors.AllAssistErrors.Where(x => x.Status == "FAIL").Count();
            //double accuracyPercentage = ((totalItems - totalErrorItems) / totalItems) * 100;

            //AccPercLabel.Content = "Accuracy Rate : " + accuracyPercentage.ToString("f2") + " %";
            //if (accuracyPercentage >= 95)
            //{
            //    AccPercLabel.Foreground = System.Windows.Media.Brushes.Green;
            //}
            //else if (accuracyPercentage >= 85 && accuracyPercentage < 95)
            //{
            //    AccPercLabel.Foreground = System.Windows.Media.Brushes.Orange;
            //}
            //else
            //{
            //    AccPercLabel.Foreground = System.Windows.Media.Brushes.Red;
            //}

            //using (StreamWriter writetext = new StreamWriter(filePath + @"\Mondelez_Container_Report_SHIPMENT_" + DateTime.Today.ToString("MMddyyyy") + ".csv"))
            //{
            //    writetext.WriteLine("Broker Reference Number|Mode of Transport Description|Master Bill(s)|House Bill Numbers|Vessel Name|Voyage Flight Number|Container Numbers|Merchandise Description|Port of Load|Port of Discharge|Customer Ref - Primary|Latest Comment|Delivery Order Number|Inland Carrier Name|Sail Date|POE Estimated Arrival Date|Customs Released Date|Consignee|Carrier|Carrier Name|Shipper / Place of Receipt |Origin Country|Equipment type / size|Broker Office Number|Arrival Week|Off Terminal Free Time");

            //    foreach (OceanReportRecord currentRecord in newReport.AllRecords)
            //    {
            //        string WriteLineTime = null;

            //        if ( currentRecord.BrokerReferenceNumber != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.BrokerReferenceNumber + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.ModeOfTransportationDescription != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.ModeOfTransportationDescription + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.MasterBills != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.MasterBills + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.HouseBillNumbers != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.HouseBillNumbers + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.VesselName != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.VesselName + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.VoyageFlightNumber != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.VoyageFlightNumber + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.ContainerString != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.ContainerString + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.MerchandiseDescription != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.MerchandiseDescription + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.PortOfLoad != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.PortOfLoad + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.PortOfDischarge != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.PortOfDischarge + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.CustomerRefString != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.CustomerRefString + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.LatestComment != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.LatestComment + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.DONumber != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.DONumber + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.InlandCarrierName != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.InlandCarrierName + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.SailDate != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.SailDate + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.POEEstimatedArrivalDate != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.POEEstimatedArrivalDate + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.CustomsReleaseDate != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.CustomsReleaseDate + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.Consignee != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.Consignee + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.Carrier != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.Carrier + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.CarrierName != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.CarrierName + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.Shipper != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.Shipper + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.OriginCountry != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.OriginCountry + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.EquipmentTypeSize != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.EquipmentTypeSize + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.ArrivalWeek != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.ArrivalWeek + "|";
            //        }
            //        else
            //        {
            //            WriteLineTime = WriteLineTime + "|";
            //        }

            //        if (currentRecord.OffTerminalFreeTime != null)
            //        {
            //            WriteLineTime = WriteLineTime + currentRecord.OffTerminalFreeTime + "|";
            //        }

            //        writetext.WriteLine(WriteLineTime);
            //    }
            //}
            #endregion

            using (var fldrDlg = new FolderBrowserDialog())
            {
                if (fldrDlg.ShowDialog() == DialogResult.OK)
                {
                    #region delimited output
                    //using (StreamWriter writetext = new StreamWriter(fldrDlg.SelectedPath + @"\Mondelez_Container_Report_CONTAINER_" + DateTime.Today.ToString("MMddyyyy") + ".txt"))
                    //    {
                    //        writetext.WriteLine("Broker Reference Number|Mode of Transport Description|Master Bill(s)|House Bill Numbers|Vessel Name|Voyage Flight Number|Container Numbers|Merchandise Description|Port of Load|Port of Discharge|Customer Ref - Primary|Latest Comment|Delivery Order Number|Inland Carrier Name|Sail Date|POE Estimated Arrival Date|Customs Released Date|Consignee|Carrier|Carrier Name|Shipper / Place of Receipt |Origin Country|Equipment type / size|Broker Office Number|Arrival Week|Off Terminal Free Time");

                    //        foreach (OceanReportRecord currentRecord in newReport2.AllRecords)
                    //        {
                    //            string WriteLineTime = null;

                    //            if (currentRecord.BrokerReferenceNumber != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.BrokerReferenceNumber + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.ModeOfTransportationDescription != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.ModeOfTransportationDescription + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.MasterBills != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.MasterBills + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.HouseBillNumbers != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.HouseBillNumbers + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.VesselName != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.VesselName + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.VoyageFlightNumber != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.VoyageFlightNumber + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.ContainerString != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.ContainerString + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.MerchandiseDescription != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.MerchandiseDescription + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.PortOfLoad != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.PortOfLoad + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.PortOfDischarge != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.PortOfDischarge + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.CustomerRefString != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.CustomerRefString + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.LatestComment != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.LatestComment + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.DONumber != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.DONumber + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.InlandCarrierName != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.InlandCarrierName + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.SailDate != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.SailDate + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.POEEstimatedArrivalDate != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.POEEstimatedArrivalDate + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.CustomsReleaseDate != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.CustomsReleaseDate + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.Consignee != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.Consignee + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.Carrier != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.Carrier + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.CarrierName != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.CarrierName + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.Shipper != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.Shipper + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.OriginCountry != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.OriginCountry + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.EquipmentTypeSize != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.EquipmentTypeSize + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.ArrivalWeek != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.ArrivalWeek + "|";
                    //            }
                    //            else
                    //            {
                    //                WriteLineTime = WriteLineTime + "|";
                    //            }

                    //            if (currentRecord.OffTerminalFreeTime != null)
                    //            {
                    //                WriteLineTime = WriteLineTime + currentRecord.OffTerminalFreeTime + "|";
                    //            }

                    //            writetext.WriteLine(WriteLineTime);
                    //        }
                    //    }
                    #endregion

                    #region Excel Output
                    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                    if (xlApp == null)
                    {
                        System.Windows.MessageBox.Show("Excel is not properly installed!!");
                        return;
                    }

                    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;

                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    xlWorkSheet.Cells[1, 2] = "Report Date:";
                    xlWorkSheet.Cells[1, 3] = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                    xlWorkSheet.Cells[1, 11] = "Estimate arrival date on or after:";

                    DateTime today = DateTime.Today;
                    DateTime todayminusoneeighty = today.AddDays(-180);

                    xlWorkSheet.Cells[1, 12] = todayminusoneeighty.ToString("dddd, dd MMMM yyyy");

                    xlWorkSheet.Cells[2, 2] = "Broker Reference Number";
                    xlWorkSheet.Cells[2, 3] = "Mode of Transport Description";
                    xlWorkSheet.Cells[2, 4] = "Master Bill(s)";
                    xlWorkSheet.Cells[2, 5] = "House Bill Numbers";
                    xlWorkSheet.Cells[2, 6] = "Vessel Name";
                    xlWorkSheet.Cells[2, 7] = "Voyage Flight Number";
                    xlWorkSheet.Cells[2, 8] = "Container Numbers";
                    xlWorkSheet.Cells[2, 9] = "Merchandise Description";
                    xlWorkSheet.Cells[2, 10] = "Port of Load";
                    xlWorkSheet.Cells[2, 11] = "Port of Discharge";
                    xlWorkSheet.Cells[2, 12] = "Customer Ref - Primary";
                    xlWorkSheet.Cells[2, 13] = "Latest Comment";
                    xlWorkSheet.Cells[2, 14] = "Delivery Order Number";
                    xlWorkSheet.Cells[2, 15] = "Inland Carrier Name";
                    xlWorkSheet.Cells[2, 16] = "Sail Date";
                    xlWorkSheet.Cells[2, 17] = "POE Estimated Arrival Date";
                    xlWorkSheet.Cells[2, 18] = "Customs Released Date";
                    xlWorkSheet.Cells[2, 19] = "Consignee";
                    xlWorkSheet.Cells[2, 20] = "Carrier";
                    xlWorkSheet.Cells[2, 21] = "Carrier Name";
                    xlWorkSheet.Cells[2, 22] = "Shipper / Place of Receipt ";
                    xlWorkSheet.Cells[2, 23] = "Origin Country";
                    xlWorkSheet.Cells[2, 24] = "Equipment type / size";
                    xlWorkSheet.Cells[2, 25] = "Broker Office Number";
                    xlWorkSheet.Cells[2, 26] = "Arrival Week";
                    xlWorkSheet.Cells[2, 27] = "Off Terminal Free Time";

                    int i = 2;
                    foreach (OceanReportRecord currentRecord in newReport2.AllRecords)
                    {
                        i++;
                        xlWorkSheet.Cells[i, 2] = currentRecord.BrokerReferenceNumber;
                        xlWorkSheet.Cells[i, 3] = currentRecord.ModeOfTransportationDescription;
                        xlWorkSheet.Cells[i, 4] = currentRecord.MasterBills;
                        xlWorkSheet.Cells[i, 5] = currentRecord.HouseBillNumbers;
                        xlWorkSheet.Cells[i, 6] = currentRecord.VesselName;
                        xlWorkSheet.Cells[i, 7] = currentRecord.VoyageFlightNumber;
                        xlWorkSheet.Cells[i, 8] = currentRecord.ContainerString;
                        xlWorkSheet.Cells[i, 9] = currentRecord.MerchandiseDescriptionString;
                        xlWorkSheet.Cells[i, 10] = currentRecord.PortOfLoad;
                        xlWorkSheet.Cells[i, 11] = currentRecord.PortOfDischarge;
                        xlWorkSheet.Cells[i, 12] = currentRecord.CustomerRefString;
                        xlWorkSheet.Cells[i, 13] = currentRecord.LatestComment;
                        xlWorkSheet.Cells[i, 14] = currentRecord.DONumber;
                        xlWorkSheet.Cells[i, 15] = currentRecord.InlandCarrierName;
                        xlWorkSheet.Cells[i, 16] = currentRecord.SailDate;
                        xlWorkSheet.Cells[i, 17] = currentRecord.POEEstimatedArrivalDate;
                        xlWorkSheet.Cells[i, 18] = currentRecord.CustomsReleaseDate;
                        xlWorkSheet.Cells[i, 19] = currentRecord.Consignee;
                        xlWorkSheet.Cells[i, 20] = currentRecord.Carrier;
                        xlWorkSheet.Cells[i, 21] = currentRecord.CarrierName;
                        xlWorkSheet.Cells[i, 22] = currentRecord.Shipper;
                        xlWorkSheet.Cells[i, 23] = currentRecord.OriginCountry;
                        xlWorkSheet.Cells[i, 24] = currentRecord.EquipmentTypeSize;
                        xlWorkSheet.Cells[i, 25] = "";
                        xlWorkSheet.Cells[i, 26] = currentRecord.ArrivalWeek;
                        xlWorkSheet.Cells[i, 27] = currentRecord.OffTerminalFreeTime;
                    }

                    // Set the columns to be autofit as per the content.
                    for (int x = 2; x < 28; x++)
                    {
                        xlWorkSheet.Columns[x].AutoFit();
                    }

                    Microsoft.Office.Interop.Excel.Range chartRange;
                    chartRange = xlWorkSheet.get_Range("b2", "aa" + i.ToString());
                    foreach (Microsoft.Office.Interop.Excel.Range cell in chartRange.Cells)
                    {
                        cell.BorderAround2();
                    }

                    chartRange.BorderAround2();

                    Microsoft.Office.Interop.Excel.Range headerRange;
                    headerRange = xlWorkSheet.get_Range("b2", "aa2");
                    foreach (Microsoft.Office.Interop.Excel.Range cell in headerRange.Cells)
                    {
                        cell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(0,53,148));
                        cell.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(242,169,80));
                        cell.Font.Bold = true;
                    }

                    //Here saving the file in xlsx
                    xlWorkBook.SaveAs(fldrDlg.SelectedPath + @"\Mondelez_Container_Report_CONTAINER_" + DateTime.Today.ToString("MMddyyyy"), Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, misValue,
                    misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    Marshal.ReleaseComObject(xlWorkSheet);
                    Marshal.ReleaseComObject(xlWorkBook);
                    Marshal.ReleaseComObject(xlApp);

                    System.Windows.MessageBox.Show("File has been created!");


                    #endregion

                }
            }

        }

        private void ExcelOutputBTN_Click_1(object sender, RoutedEventArgs e)
        {
            ExportToExcel<OceanReportRecord, List<OceanReportRecord>> s = new ExportToExcel<OceanReportRecord, List<OceanReportRecord>>();
            s.dataToPrint = (List<OceanReportRecord>)DataGridViewDG.ItemsSource;
            s.GenerateReport();
        }

        private MondelezContainerAdhoc LoadContainerAdhocData(string adhocFile)
        {
            MondelezContainerAdhoc newContainerAdhoc = new MondelezContainerAdhoc();
            //TODO : ADD CHECK HERE
            List<ContainerItem> values = File.ReadAllLines(adhocFile)
                                           .Skip(1)
                                           .Select(v => ContainerItem.FromCsv(v))
                                           .ToList();
            newContainerAdhoc.AllContainerItems = values;
            return newContainerAdhoc;
        }

        private MondelezPartiesAdhoc LoadPartyAdhocData(string assistFileCsv)
        {
            MondelezPartiesAdhoc newPartiesAdhoc = new MondelezPartiesAdhoc();

            List<PartyItem> values = File.ReadAllLines(assistFileCsv)
                                           .Skip(1)
                                           .Select(v => PartyItem.FromCsv(v))
                                           .ToList();
            newPartiesAdhoc.AllPartyItems = values;
            return newPartiesAdhoc;


        }

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        private void ExcelOutputBTN_Click(object sender, RoutedEventArgs e)
        {
            ExportToExcel<SingleAssistError, List<SingleAssistError>> s = new ExportToExcel<SingleAssistError, List<SingleAssistError>>();
            s.dataToPrint = (List<SingleAssistError>)DataGridViewDG.ItemsSource;
            s.GenerateReport();
        }

        public static double RoundUp(double input, int places)
        {
            double multiplier = Math.Pow(10, Convert.ToDouble(places));
            return Math.Ceiling(input * multiplier) / multiplier;
        }

    }
}
