using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using USeTeamDesktopTool.Data_Classes;
using USeTeamDesktopTool.Data_Classes.AmercareAudit;
using USeTeamDesktopTool.Functions;

namespace USeTeamDesktopTool
{
    /// <summary>
    /// Interaction logic for AmazonAuditTabView.xaml
    /// </summary>
    public partial class AmercareAuditTabView : System.Windows.Controls.UserControl
    {
        public AmercareAuditTabView()
        {
            InitializeComponent();
        }

        private void SelectAdhocRerportBTN_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Select Adhoc Report File";
            openFileDialog1.Multiselect = false;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "csv";
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string filename in openFileDialog1.FileNames)
                {
                    AdhocReportTB.Text = filename;
                }
            }
        }

        private void SelectOoclFileBTN_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Select OOCL ACR File";
            openFileDialog1.Multiselect = false;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "xlsx";
            openFileDialog1.Filter = "EXCEL files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string filename in openFileDialog1.FileNames)
                {
                    OoclTB.Text = filename;
                }
            }
        }

        private void SelectInvAdhocBTN_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Select Adhoc Report File";
            openFileDialog1.Multiselect = false;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "csv";
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string filename in openFileDialog1.FileNames)
                {
                    InvAdhocTB.Text = filename;
                }
            }
        }

        private void RunAnalysisBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                IEnumerable<DataRow> sheetData = LoadOocltData(OoclTB.Text);
                OoclAcrData newOoclFile = new OoclAcrData();
                AmercareShipmentDataAdhoc newAdhocFile = new AmercareShipmentDataAdhoc();
                AmercareMissingShipmentData missingShipments = new AmercareMissingShipmentData();
                AmercareShipmentDataCommAdhoc newShipmentAdhoc = new AmercareShipmentDataCommAdhoc();

                int i = 0;
                int maxRows = sheetData.Count();
                string currentBL = null;

                #region DataExtract - OOCL ACR Report
                foreach (DataRow row in sheetData)
                {
                    i++;
                    if (i > 6)
                    {
                        if (!string.IsNullOrEmpty(row.ItemArray[0].ToString()))
                        {
                            currentBL = row.ItemArray[0].ToString();
                        }
                        else
                        {
                            SingleOoclRecord newRecord = new SingleOoclRecord();
                            newRecord.Bl = currentBL;
                            if (!string.IsNullOrEmpty(row.ItemArray[1].ToString())) { newRecord.Po = Convert.ToString(row.ItemArray[1].ToString()); }
                            if (!string.IsNullOrEmpty(row.ItemArray[2].ToString())) { newRecord.Vessel = row.ItemArray[2].ToString(); }
                            if (!string.IsNullOrEmpty(row.ItemArray[3].ToString())) { newRecord.Voyage = row.ItemArray[3].ToString(); }
                            if (!string.IsNullOrEmpty(row.ItemArray[4].ToString())) { newRecord.FirstPostAdvice = Convert.ToDateTime(row.ItemArray[4].ToString()); }
                            if (!string.IsNullOrEmpty(row.ItemArray[5].ToString())) { newRecord.ProductCode = row.ItemArray[5].ToString(); }
                            if (!string.IsNullOrEmpty(row.ItemArray[7].ToString())) { newRecord.Container = row.ItemArray[7].ToString(); }
                            if (!string.IsNullOrEmpty(row.ItemArray[8].ToString())) { newRecord.Pol = row.ItemArray[8].ToString(); }
                            if (!string.IsNullOrEmpty(row.ItemArray[9].ToString())) { newRecord.Pod = row.ItemArray[9].ToString(); }
                            if (!string.IsNullOrEmpty(row.ItemArray[10].ToString())) { newRecord.CargoFND = row.ItemArray[10].ToString(); }
                            if (!string.IsNullOrEmpty(row.ItemArray[11].ToString())) { newRecord.CargoFNDEta = Convert.ToDateTime(row.ItemArray[11].ToString()); }
                            if (!string.IsNullOrEmpty(row.ItemArray[12].ToString())) { newRecord.Carrier = row.ItemArray[12].ToString(); }
                            if (!string.IsNullOrEmpty(row.ItemArray[13].ToString())) { newRecord.CarrierFNDEta = Convert.ToDateTime(row.ItemArray[13].ToString()); }
                            if (!string.IsNullOrEmpty(row.ItemArray[14].ToString())) { newRecord.PodEta = Convert.ToDateTime(row.ItemArray[14].ToString()); }
                            if (!string.IsNullOrEmpty(row.ItemArray[16].ToString())) { newRecord.FwBl = row.ItemArray[16].ToString(); }
                            if (!string.IsNullOrEmpty(row.ItemArray[23].ToString())) { newRecord.DeliveredDate = Convert.ToDateTime(row.ItemArray[23].ToString()); }
                            newOoclFile.AllOoclRecords.Add(newRecord);
                        }
                    }
                }
                #endregion

                #region DataExtract - Adhoc Report Shipment
                newAdhocFile = LoadAdHocData(AdhocReportTB.Text);
                #endregion

                #region DataExtract - Adhoc Report (Podium Data)
                string[] lines = File.ReadAllLines(InvAdhocTB.Text);
                int lineCount = 0;
                foreach (string line in lines)
                {
                    string currentLineTxt = line;
                    currentLineTxt = currentLineTxt.Replace("\"", "");
                    lineCount++;
                    if (lineCount > 1)
                    {
                        string[] values = currentLineTxt.Split(',');
                        EvolveShipmentHeader matchingShipment = newShipmentAdhoc.AllShipments.Where(x => x.FileNo == Convert.ToInt32(values[0])).FirstOrDefault();
                        if (matchingShipment != null)
                        {
                            EvolveShipmentCI currentInvoice = matchingShipment.AllInvoices.Where(x => x.InvoiceNumber == Convert.ToString(values[1])).FirstOrDefault();
                            if (currentInvoice != null)
                            {
                                EvolveCILine currentLine = currentInvoice.AllLines.Where(x => x.LineNo == Convert.ToInt32(values[4])).FirstOrDefault();
                                if (currentLine != null)
                                {
                                    //THIS SHOULD NEVER BE HIT!
                                }
                                else
                                {
                                    EvolveCILine newLine = new EvolveCILine();
                                    newLine.LineNo = Convert.ToInt32(values[4]);
                                    newLine.PartNumber = Convert.ToString(values[5]);
                                    newLine.LinePONumber = Convert.ToString(values[6]);
                                    newLine.ContainerNumber = Convert.ToString(values[7]);
                                    currentInvoice.AllLines.Add(newLine);
                                }
                            }
                            else
                            {
                                EvolveShipmentCI newCI = new EvolveShipmentCI();
                                newCI.InvoiceNumber = Convert.ToString(values[1]);
                                newCI.CIPONumber = Convert.ToString(values[2]);
                                newCI.Desc1Ci = Convert.ToString(values[3]);
                                if (Convert.ToString(values[3]).StartsWith("POD: "))
                                {
                                    string podString = Convert.ToString(values[3]).Substring(5, Convert.ToString(values[3]).Length - 5).Trim();
                                    string[] split = podString.Split('-');
                                    newCI.BL = split[0];
                                    newCI.Container = split[1];
                                }
                                matchingShipment.AllInvoices.Add(newCI);

                                EvolveShipmentCI newInvoiceInList = matchingShipment.AllInvoices.Where(x => x.InvoiceNumber == newCI.InvoiceNumber).FirstOrDefault();

                                EvolveCILine newLine = new EvolveCILine();
                                newLine.LineNo = Convert.ToInt32(values[4]);
                                newLine.PartNumber = Convert.ToString(values[5]);
                                newLine.LinePONumber = Convert.ToString(values[6]);
                                newLine.ContainerNumber = Convert.ToString(values[7]);
                                newInvoiceInList.AllLines.Add(newLine);
                            }
                        }
                        else
                        {
                            //create new record
                            EvolveShipmentHeader newShipment = new EvolveShipmentHeader();
                            newShipment.FileNo = Convert.ToInt32(values[0]);
                            newShipmentAdhoc.AllShipments.Add(newShipment);

                            EvolveShipmentHeader newShipmentInList = newShipmentAdhoc.AllShipments.Where(x => x.FileNo == newShipment.FileNo).FirstOrDefault();

                            EvolveShipmentCI newCI = new EvolveShipmentCI();
                            newCI.InvoiceNumber = Convert.ToString(values[1]);
                            newCI.CIPONumber = Convert.ToString(values[2]);
                            newCI.Desc1Ci = Convert.ToString(values[3]);
                            if (Convert.ToString(values[3]).StartsWith("POD: "))
                            {
                                string podString = Convert.ToString(values[3]).Substring(5, Convert.ToString(values[3]).Length - 5).Trim();
                                string[] split = podString.Split('-');
                                newCI.BL = split[0];
                                newCI.Container = split[1];
                            }
                            newShipmentInList.AllInvoices.Add(newCI);

                            EvolveShipmentCI newInvoiceInList = newShipmentInList.AllInvoices.Where(x => x.InvoiceNumber == newCI.InvoiceNumber).FirstOrDefault();

                            EvolveCILine newLine = new EvolveCILine();
                            newLine.LineNo = Convert.ToInt32(values[4]);
                            newLine.PartNumber = Convert.ToString(values[5]);
                            newLine.LinePONumber = Convert.ToString(values[6]);
                            newLine.ContainerNumber = Convert.ToString(values[7]);
                            newInvoiceInList.AllLines.Add(newLine);
                        }
                    }
                }
                #endregion

                #region Analysis

                foreach (SingleOoclRecord ooclRecord in newOoclFile.AllOoclRecords)
                {
                    string test = ooclRecord.Bl.ToString().Substring(4, ooclRecord.Bl.ToString().Length - 4);
                    SingleRecord evolveMatch = newAdhocFile.AllRecords.Where(x => x.HouseBL == test
                                                                            || x.MasterBL == test).FirstOrDefault();

                    //Checks to see if we have a record in the 'Shipment' adhoc
                    //If it doesnt, it logs this items as a 'Error' at the header level
                    if (evolveMatch == null)
                    {
                        SingleMissingShipment matchingRecord = missingShipments.AllMissingRecords.Where(x => x.Bl == ooclRecord.Bl
                                                                                                        && x.Vessel == ooclRecord.Vessel
                                                                                                        && x.Voyage == ooclRecord.Voyage
                                                                                                        && x.Pol == ooclRecord.Pol
                                                                                                        && x.Pod == ooclRecord.Pod
                                                                                                        && x.CarrierFNDEta == ooclRecord.CarrierFNDEta).FirstOrDefault();
                        if (matchingRecord == null)
                        {
                            SingleMissingShipment newShipment = new SingleMissingShipment
                            {
                                Bl = ooclRecord.Bl,
                                Vessel = ooclRecord.Vessel,
                                Voyage = ooclRecord.Voyage,
                                Pol = ooclRecord.Pol,
                                Pod = ooclRecord.Pod,
                                CarrierFNDEta = ooclRecord.CarrierFNDEta,
                                ShipmentErrorDesc = "SHIPMENT DOES NOT EXIST IN EVOLVE"
                            };
                            missingShipments.AllMissingRecords.Add(newShipment);
                        }

                    }
                    else
                    {
                        //DO CHECK TO SEE IF C/R WAS ACCEPTED, IF NOT, OOCL HAS NEVER GOTTEN THAT FILE. 'FILE EXISTS BUT DOES NOT HAVE C/R'
                        if (evolveMatch.CRAccepted == null)
                        {
                            SingleMissingShipment matchingRecord = missingShipments.AllMissingRecords.Where(x => x.Bl == ooclRecord.Bl
                                                                                                        && x.Vessel == ooclRecord.Vessel
                                                                                                        && x.Voyage == ooclRecord.Voyage
                                                                                                        && x.Pol == ooclRecord.Pol
                                                                                                        && x.Pod == ooclRecord.Pod
                                                                                                        && x.CarrierFNDEta == ooclRecord.CarrierFNDEta
                                                                                                        && x.LiiCrAccepted == evolveMatch.CRAccepted
                                                                                                        && x.ShipmentErrorDesc == "SHIPMENT EXISTS IN EVOLVE, BUT DOES NOT HAVE A CARGO RELEASE").FirstOrDefault();

                            if (matchingRecord == null)
                            {
                                SingleMissingShipment newShipment = new SingleMissingShipment
                                {
                                    Bl = ooclRecord.Bl,
                                    Vessel = ooclRecord.Vessel,
                                    Voyage = ooclRecord.Voyage,
                                    Pol = ooclRecord.Pol,
                                    Pod = ooclRecord.Pod,
                                    CarrierFNDEta = ooclRecord.CarrierFNDEta,
                                    LiiCrAccepted = evolveMatch.CRAccepted,
                                    ShipmentErrorDesc = "SHIPMENT EXISTS IN EVOLVE, BUT DOES NOT HAVE A CARGO RELEASE"
                                };
                                missingShipments.AllMissingRecords.Add(newShipment);
                            }
                        }
                        else
                        {
                            //This is if the shipment exists, it starts the compare process from the oocl ACR report to what we have on file and determines where the issue is
                            int fileNumber = evolveMatch.FileNo;
                            EvolveShipmentHeader matchingShipment = newShipmentAdhoc.AllShipments.Where(x => x.FileNo == fileNumber).FirstOrDefault();
                            if (matchingShipment != null)
                            {
                                string bl = ooclRecord.Bl;
                                string poNumber = ooclRecord.Po;
                                string partNumber = ooclRecord.ProductCode;
                                string container = ooclRecord.Container;

                                string errorString = "";

                                bool poMatch = false;
                                bool containerMatch = false;
                                bool blMatch = false;

                                EvolveShipmentCI currentInvoice = matchingShipment.AllInvoices.Where(x => x.BL == bl).FirstOrDefault();
                                if (currentInvoice == null)
                                {
                                    errorString = "MISSING/INCORRECT BL IN DESC_1_CI at CI_HEADER";

                                    SingleMissingShipment newMissing = new SingleMissingShipment
                                    {
                                        Bl = ooclRecord.Bl,
                                        Vessel = ooclRecord.Vessel,
                                        Voyage = ooclRecord.Voyage,
                                        Pol = ooclRecord.Pol,
                                        Pod = ooclRecord.Pod,
                                        OoclContainer = container,
                                        OoclProductCode = partNumber,
                                        OoclPONumber = poNumber,
                                        CarrierFNDEta = ooclRecord.CarrierFNDEta,
                                        LiiFileNo = matchingShipment.FileNo,
                                        LiiCrAccepted = evolveMatch.CRAccepted,
                                        ShipmentErrorDesc = errorString
                                    };

                                    missingShipments.AllMissingRecords.Add(newMissing);
                                }
                                else
                                {
                                    SingleMissingShipment currShipment = missingShipments.AllMissingRecords.Where(x => x.Bl == ooclRecord.Bl
                                                                                                                    && x.Vessel == ooclRecord.Vessel
                                                                                                                    && x.Voyage == ooclRecord.Voyage
                                                                                                                    && x.Pol == ooclRecord.Pol
                                                                                                                    && x.Pod == ooclRecord.Pod).FirstOrDefault();
                                    //if (currShipment == null)
                                    //{
                                    //    //SEE IF MISSING EXISTS, IF IT DOES, USE IT, IF IT DOESNT, CREATE IT
                                    //    SingleMissingShipment newMissing = new SingleMissingShipment
                                    //    {
                                    //        Bl = ooclRecord.Bl,
                                    //        Vessel = ooclRecord.Vessel,
                                    //        Voyage = ooclRecord.Voyage,
                                    //        Pol = ooclRecord.Pol,
                                    //        Pod = ooclRecord.Pod,
                                    //        CarrierFNDEta = ooclRecord.CarrierFNDEta
                                    //    };
                                    //    missingShipments.AllMissingRecords.Add(newMissing);
                                    //}

                                    blMatch = true;
                                    IEnumerable<EvolveCILine> currentLines = currentInvoice.AllLines.Where(x => x.PartNumber == partNumber
                                                                                                            && x.LinePONumber == poNumber);
                                    //if(currentLines != null)
                                    if (!GeneralFunctions.IsNullOrEmpty(currentLines))
                                    {
                                        foreach (EvolveCILine line in currentLines)
                                        {
                                            errorString = "";
                                            if (line.LinePONumber == poNumber) { poMatch = true; }
                                            if (line.ContainerNumber == container) { containerMatch = true; }

                                            if (containerMatch == true && poMatch == false) { errorString = "PO DOES NOT MATCH (LINE CUST_REF)"; }
                                            if (containerMatch == false && poMatch == true) { errorString = "CONTAINER DOES NOT MATCH (LINE CONTAINER_NO)"; }
                                            if (containerMatch == true && poMatch == true) { errorString = "CONTAINER and PO Match : REVIEW PROCESS WITH ETEAM (LINE CUST_REF & LINE CONTAINER_NO)"; }
                                            if (containerMatch == false && poMatch == false) { errorString = "PO AND CONTAINER DO NOT MATCH (LINE CUST_REF & LINE CONTAINER_NO)"; }


                                            SingleMissingShipment currentMissing = missingShipments.AllMissingRecords.Where(x => x.Bl == bl
                                                                                                                            && x.Vessel == ooclRecord.Vessel
                                                                                                                            && x.Voyage == ooclRecord.Voyage
                                                                                                                            && x.Pol == ooclRecord.Pol
                                                                                                                            && x.Pod == ooclRecord.Pod
                                                                                                                            && x.CarrierFNDEta == ooclRecord.CarrierFNDEta).FirstOrDefault();
                                            SingleMissingShipment newMissing = new SingleMissingShipment
                                            {
                                                Bl = ooclRecord.Bl,
                                                Vessel = ooclRecord.Vessel,
                                                Voyage = ooclRecord.Voyage,
                                                Pol = ooclRecord.Pol,
                                                Pod = ooclRecord.Pod,
                                                CarrierFNDEta = ooclRecord.CarrierFNDEta,
                                                OoclContainer = container,
                                                OoclProductCode = partNumber,
                                                OoclPONumber = poNumber,
                                                LiiFileNo = matchingShipment.FileNo,
                                                LiiCrAccepted = evolveMatch.CRAccepted,
                                                LiiProductCode = line.PartNumber,
                                                LiiContainer = line.ContainerNumber,
                                                LiiPONumber = line.LinePONumber,
                                                LineErrorDesc = errorString
                                            };
                                            missingShipments.AllMissingRecords.Add(newMissing);
                                        }
                                    }
                                    else
                                    {
                                        //SingleMissingShipment currentMissing = missingShipments.AllMissingRecords.Where(x => x.Bl == bl
                                        //                                                                                    && x.Vessel == ooclRecord.Vessel
                                        //                                                                                    && x.Voyage == ooclRecord.Voyage
                                        //                                                                                    && x.Pol == ooclRecord.Pol
                                        //                                                                                    && x.Pod == ooclRecord.Pod
                                        //                                                                                    && x.CarrierFNDEta == ooclRecord.CarrierFNDEta).FirstOrDefault();

                                        errorString = "PART/PO COMBO DOES NOT MATCH ANYTHING IN THE FILE.";

                                        SingleMissingShipment currentMissing = new SingleMissingShipment
                                        {
                                            Bl = ooclRecord.Bl,
                                            Vessel = ooclRecord.Vessel,
                                            Voyage = ooclRecord.Voyage,
                                            Pol = ooclRecord.Pol,
                                            Pod = ooclRecord.Pod,
                                            CarrierFNDEta = ooclRecord.CarrierFNDEta,
                                            OoclContainer = container,
                                            OoclProductCode = partNumber,
                                            OoclPONumber = poNumber,
                                            LiiFileNo = matchingShipment.FileNo,
                                            LiiCrAccepted = evolveMatch.CRAccepted,
                                            LineErrorDesc = errorString
                                        };

                                        missingShipments.AllMissingRecords.Add(currentMissing);
                                    }
                                }
                            }

                        }
                    }
                }

                DataTable table = new DataTable();
                table = ToDataTable<SingleMissingShipment>(missingShipments.AllMissingRecords);
                DataGridViewDG.ItemsSource = missingShipments.AllMissingRecords;

                #endregion
            }
            catch (Exception z)
            {
                System.Windows.Forms.MessageBox.Show("An error occured running the analysis. Please contact Anthony Buchanan.");
            }
        }

        private void ExcelOutputBTN_Click_1(object sender, RoutedEventArgs e)
        {
            ExportToExcel<SingleMissingShipment, List<SingleMissingShipment>> s = new ExportToExcel<SingleMissingShipment, List<SingleMissingShipment>>();
            s.dataToPrint = (List<SingleMissingShipment>)DataGridViewDG.ItemsSource;
            s.GenerateReport();
        }

        private AmercareShipmentDataAdhoc LoadAdHocData(string adhocFile)
        {
            try
            {
                AmercareShipmentDataAdhoc newAdhoc = new AmercareShipmentDataAdhoc();
                //TODO : ADD CHECK HERE
                List<SingleRecord> values = File.ReadAllLines(adhocFile)
                                               .Skip(1)
                                               .Select(v => SingleRecord.FromCsv(v))
                                               .ToList();
                newAdhoc.AllRecords = values;
                return newAdhoc;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("An error occured loading the adhoc Shipment Data. Please contact Anthony Buchanan.");

                return null;
            }
        }

        private IEnumerable<DataRow> LoadOocltData(string assistFileCsv)
        {
            try
            {
                using (var stream = File.Open(assistFileCsv, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        string sheetName = "Report0";

                        var result = reader.AsDataSet();
                        var worksheet = result.Tables[sheetName];
                        var rows = from DataRow a in worksheet.Rows select a;

                        return rows;
                    }
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show("An error occured loading the OOCL ACR Report. Please contact Anthony Buchanan.");

                return null;               
            }          
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
            ExportToExcel<SingleMissingShipment, List<SingleMissingShipment>> s = new ExportToExcel<SingleMissingShipment, List<SingleMissingShipment>>();
            s.dataToPrint = (List<SingleMissingShipment>)DataGridViewDG.ItemsSource;
            s.GenerateReport();
        }
    
    }
}