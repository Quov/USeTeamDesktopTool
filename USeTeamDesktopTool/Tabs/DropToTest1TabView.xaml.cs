using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Threading;
using System.Xml;
using USeTeamDesktopTool.Data_Classes;
using USeTeamDesktopTool.Functions;

namespace USeTeamDesktopTool
{ 
    /// <summary>
    /// Interaction logic for SaveTabView.xaml
    /// </summary>
    public partial class DropToTest1TabView : System.Windows.Controls.UserControl
    {
        public string appDataFileLocation = "";        
        public string selectedFileName = "null";
        public string filePath = "";
        public int invCount = 0;
        public List<string> eachInvoice = new List<string>();
        EventLogging eventLogger = new EventLogging();    
        public string appLogFileLocation = "";
        public string clientNo = "";
        public string processCD = "";
        public object RecordEvent { get; private set; }

        public DropToTest1TabView()
        {
            InitializeComponent();
            //System.Windows.Controls.Control parent = this.Parent as System.Windows.Controls.Control;
            //parent.TabIndex = this.TabIndex;
            appDataFileLocation = eventLogger.GetAppDataFilePath();
            FilePathTB.Text = "";
            appLogFileLocation = eventLogger.GetAppLogFilePathName();
            //TODO: Add a "Checking for Drop folder access" popup.
            if(Directory.Exists(@"\\mdcdvbz500\HF\INBOUND") == true)
            {
                GenerateNewXmlDataBTN.IsEnabled = true;
            }
            else
            {
                GenerateNewXmlDataBTN.IsEnabled = false;
            }
            
        }

        private void SelectFileBTN_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Select XML File",
                Multiselect = false,
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "xml",
                Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFileName = null;
                invCount = 0;
                eachInvoice = new List<string>();
                foreach (string filename in openFileDialog1.FileNames)
                {
                    filePath = filename;
                    FilePathTB.Text = filePath;

                    var bc = new BrushConverter();
                    System.Windows.Media.Brush greenBack = (System.Windows.Media.Brush)bc.ConvertFrom("#FF6DEC73");
                    System.Windows.Media.Brush redBack = (System.Windows.Media.Brush)bc.ConvertFrom("#FFE06B6B");

                    XmlDocument doc = new XmlDocument();
                    doc.Load(filePath);

                    XmlNamespaceManager namespaces = new XmlNamespaceManager(doc.NameTable);
                    namespaces.AddNamespace("dft", "http://www.kewill.com/Customs/edi");

                    XmlNodeList WorkMgmtNode = doc.SelectNodes("/dft:SHIPMENT/dft:SHIPMENT_MAIN/dft:DASHBOARD_WORK_MGMT", namespaces);
                    foreach(XmlNode node in WorkMgmtNode)
                    {
                        if(node["MASTER_BILL"] != null){ ChangeTextBox(MasterBillDBTB, greenBack, node["MASTER_BILL"].InnerText); }
                        else{ ChangeTextBox(MasterBillDBTB, redBack, "NO VALUE IN FILE"); }
                        if (node["PROCESS_CD"] != null) { ChangeTextBox(ProcessCDTB, greenBack, node["PROCESS_CD"].InnerText); processCD = node["PROCESS_CD"].InnerText; }
                        else { ChangeTextBox(ProcessCDTB, redBack, "NO VALUE IN FILE"); }
                        if (node["CUST_NO"] != null) { ChangeTextBox(ClientNoTB, greenBack, node["CUST_NO"].InnerText); clientNo = node["CUST_NO"].InnerText; }
                        else { ChangeTextBox(ClientNoTB, redBack, "NO VALUE IN FILE"); }
                    }

                    XmlNodeList GeneralShipmentInformation = doc.SelectNodes("/dft:SHIPMENT/dft:SHIPMENT_MAIN/dft:EDI_SHIPMENT_HEADER", namespaces);
                    foreach(XmlNode node in GeneralShipmentInformation)
                    {
                        if (node["MASTER_BILL"] != null) { ChangeTextBox(MasterBillEETB, greenBack, node["MASTER_BILL"].InnerText); }
                        else { ChangeTextBox(MasterBillEETB, redBack, "NO VALUE IN FILE"); }
                        if (node["MATCH_ENTRY"] != null) { ChangeTextBox(MatchEntryTB, greenBack, node["MATCH_ENTRY"].InnerText); }
                        else { ChangeTextBox(MatchEntryTB, redBack, "NO VALUE IN FILE"); }
                        if (node["HOUSE_BILL"] != null) { ChangeTextBox(HouseBillTB, greenBack, node["HOUSE_BILL"].InnerText); }
                        else { ChangeTextBox(HouseBillTB, redBack, "NO VALUE IN FILE"); }
                        if (node["MATCH_SHIPMENT"] != null) { ChangeTextBox(MatchShipmentTB, greenBack, node["MATCH_SHIPMENT"].InnerText); }
                        else { ChangeTextBox(MatchShipmentTB, redBack, "NO VALUE IN FILE"); }
                        if (node["SUB_SUB_BILL"] != null) { ChangeTextBox(SubSubBillTB, greenBack, node["SUB_SUB_BILL"].InnerText); }
                        else { ChangeTextBox(SubSubBillTB, redBack, node["NO VALUE IN FILE"].InnerText); }
                        if (node["ENTRY_NO"] != null) { ChangeTextBox(EntryNoTB, greenBack, node["ENTRY_NO"].InnerText); }
                        else { ChangeTextBox(EntryNoTB, redBack, "NO VALUE IN FILE"); }

                    }

                    //TODO: 
                    XmlNodeList EDIInvoiceHeaderList = doc.SelectNodes("/dft:SHIPMENT/dft:SHIPMENT_MAIN/dft:EDI_SHIPMENT_HEADER/dft:EDI_INVOICE_HEADER", namespaces);
                    invCount = EDIInvoiceHeaderList.Count;

                    foreach (XmlNode commNode in EDIInvoiceHeaderList)
                    {
                        if(invCount > 1)
                        {
                            string invName = commNode["COMM_INV_NO"].InnerText;
                            eachInvoice.Add(invName);
                        }
                        else
                        {
                            if(commNode["COMM_INV_NO"] != null)
                            {
                                ChangeTextBox(CommInvNoTB1, greenBack, commNode["COMM_INV_NO"].InnerText);
                                //ChangeTextBox(CommInvNoTB2, redBack, "");
                                string invName = commNode["COMM_INV_NO"].InnerText;
                                eachInvoice.Add(invName);
                            }
                        }
                    }

                    if(invCount > 1)
                    {
                        ChangeTextBox(CommInvNoTB1, greenBack, eachInvoice[0]);
                        ChangeTextBox(CommInvNoTB2, greenBack, eachInvoice[invCount - 1]);
                    }
                }

                NewClientNoTB.Text = "";
                NewCommInvNoTB.Text = "";
                NewCommInvNoTB2.Text = "";
                NewEntryNoTB.Text = "";
                NewHouseBillTB.Text = "";
                NewMasterBillDBTB.Text = "";
                NewMasterBillEETB.Text = "";
                NewMatchShipmentTB.Text = "";
                NewMatchEntryTB.Text = "";
                NewProcessCDTB.Text = "";
                NewSubSubBillTB.Text = "";

            }
        }

        private void ChangeTextBox(System.Windows.Controls.TextBox textBox, System.Windows.Media.Brush backgroundColor, string value)
        {
            textBox.Text = value;
            textBox.Background = backgroundColor;
        }


        //TODO: Need to redo these below sections. We should now do the following :
        //              -   Need to access a file on a network drive. If file is locked, enter a loop that checks to see if unlocked every few seconds.
        //              -   When opened, lock file so other users cannot access
        //              -   load and update the file.
        //              -   save and close, unlocking the file
        private void GenerateNewXmlDataBTN_Click(object sender, RoutedEventArgs e)
        {
            NewMatchEntryTB.Text = "";
            NewSubSubBillTB.Text = "";
            NewMasterBillDBTB.Text = "";
            NewMasterBillEETB.Text = "";
            NewHouseBillTB.Text = "";
            NewMatchShipmentTB.Text = "";

            AppData appData = new AppData();
            
            //TODO : Change to server address
            appDataFileLocation = @"\\pdc-evs-file\US_Common\US_Brokerage\EDI\USeTeamDesktopTool\Data\AppData.json";

            if (WaitForFile(appDataFileLocation) == true)
            {
                using (FileStream fs = new FileStream(appDataFileLocation, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        appData = (AppData)serializer.Deserialize(sr, typeof(AppData));

                        string fmt = "00000";
                        string recentMatch = appData.MatchEntry;
                        string resultString = Regex.Match(recentMatch, @"\d+").Value;
                        int currentNo = Int32.Parse(resultString);
                        currentNo += 1;

                        string finalNo = currentNo.ToString(fmt);
                        string generateMatchNo = String.Format("AB" + finalNo);

                        //FORMAT "ABXXXXX"
                        NewMatchEntryTB.Text = generateMatchNo;
                        NewSubSubBillTB.Text = generateMatchNo;

                        //FORMAT "ABTESTXXXXX"
                        string generateMB = String.Format("ABTEST" + finalNo);
                        NewMasterBillDBTB.Text = generateMB;
                        NewMasterBillEETB.Text = "RDWY";

                        //FORMAT "ABXXX-XX"
                        string generateHBMS = String.Format("AB000-" + currentNo);
                        NewHouseBillTB.Text = generateHBMS;
                        NewMatchShipmentTB.Text = generateHBMS;

                        //FORMAT "ABTEST-XX"
                        recentMatch = appData.CommInvNo;
                        string resultStringInv = Regex.Match(recentMatch, @"\d+").Value;
                        int currentNoInv = Int32.Parse(resultStringInv);
                        //currentNoInv += 1;

                        if (invCount > 1)
                        {
                            string generateCI = String.Format("ABTESTING-" + currentNoInv);
                            NewCommInvNoTB.Text = generateCI;
                            int finalInvNo = currentNoInv + invCount - 1;
                            string generateCI2 = String.Format("ABTESTING-" + finalInvNo);
                            NewCommInvNoTB2.Text = generateCI2;
                        }
                        else
                        {
                            string generateCI = String.Format("ABTESTING-" + currentNoInv);
                            NewCommInvNoTB.Text = generateCI;
                        }
                        NewClientNoTB.Text = clientNo;
                        NewProcessCDTB.Text = processCD;


                        //private void DropFileToTest1BTN_Click(object sender, RoutedEventArgs e)
                        //{
                        //TODO: Add replace logic
                        string fileLoc = FilePathTB.Text;
                        XMLTest1Replace matchEntry = new XMLTest1Replace();

                        XmlDocument doc = new XmlDocument();
                        doc.Load(fileLoc);

                        string matchEntryNew = NewMatchEntryTB.Text;
                        string masterBillWMNew = NewMasterBillDBTB.Text;
                        string masterBillEENew = NewMasterBillEETB.Text;
                        string houseBillNew = NewHouseBillTB.Text;
                        string matchShipmentNew = NewMatchShipmentTB.Text;
                        string subSubBillnew = NewSubSubBillTB.Text;
                        string entryNoNew = NewEntryNoTB.Text;
                        string commInvNoNew = NewCommInvNoTB.Text;
                        string commInvNoNew2 = NewCommInvNoTB2.Text;
                        string clientNo2 = NewClientNoTB.Text;
                        string processCD2 = NewProcessCDTB.Text;

                        //matchEntry.xmlNodeParse(doc, "CUST_NO", clientNo2);
                        matchEntry.xmlNodeParse(doc, "PROCESS_CD", processCD2);
                        matchEntry.xmlNodeParse(doc, "MATCH_ENTRY", matchEntryNew);
                        matchEntry.xmlNodeParse(doc, "MASTER_BILL", masterBillEENew);
                        matchEntry.xmlNodeParse(doc, "MASTER_BILL_ADDL", masterBillWMNew);
                        matchEntry.xmlNodeParseMBWM(doc, masterBillWMNew);
                        matchEntry.xmlNodeParse(doc, "HOUSE_BILL", houseBillNew);
                        matchEntry.xmlNodeParse(doc, "MATCH_SHIPMENT", matchShipmentNew);
                        matchEntry.xmlNodeParse(doc, "SUB_SUB_BILL", subSubBillnew);
                        matchEntry.xmlNodeParseEntryNo(doc);

                        foreach (string invText in eachInvoice)
                        {
                            matchEntry.xmlNodeParseCommInv(doc, invText, commInvNoNew);

                            string recentMatch2 = commInvNoNew;
                            string resultString2 = Regex.Match(recentMatch2, @"\d+").Value;
                            int currentNo2 = Int32.Parse(resultString2);
                            currentNo2 = currentNo2 + 1;

                            commInvNoNew = String.Format("ABTESTING-" + currentNo2);
                        }

                        SaveFileDialog saveFileDialog1 = new SaveFileDialog
                        {
                            Title = "Save XML Files",
                            CheckFileExists = false,
                            CheckPathExists = true,
                            DefaultExt = ".xml",
                            Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                            FilterIndex = 1,
                            RestoreDirectory = true,
                            FileName = NewMatchEntryTB.Text,
                            InitialDirectory = @"\\mdcdvbz500\HF\INBOUND"
                        };

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            //TODO: ADD CHECKS TO ENSURE JSON FORMAT
                            string FILE = saveFileDialog1.FileName;
                            doc.Save(FILE);

                            //string json = File.ReadAllText(appDataFileLocation);
                            //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                            //jsonObj["LastUpdated"] = System.DateTime.Now;
                            //jsonObj["MatchEntry"] = matchEntryNew;
                            //jsonObj["MasterBillEE"] = masterBillEENew;
                            //jsonObj["MatchShipment"] = matchShipmentNew;

                            appData.LastUpdated = System.DateTime.Now;
                            appData.MatchEntry = matchEntryNew;
                            appData.MasterBillEE = masterBillEENew;
                            appData.MatchShipment = matchShipmentNew;

                            if (invCount > 1)
                            {
                                //jsonObj["CommInvNo"] = commInvNoNew2;
                                appData.CommInvNo = commInvNoNew2;
                            }
                            else
                            {
                                //jsonObj["CommInvNo"] = commInvNoNew;
                                appData.CommInvNo = commInvNoNew;
                            }

                            //string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                            //File.WriteAllText(appDataFileLocation, output);
                            string eventDescription = "New File was created and dropped to test 1 with MatchEntry of " + matchEntryNew + ".";
                            eventLogger.RecordEvent(appLogFileLocation, eventDescription, DateTime.Now, "Test1FileCreation");

                            sr.Close();
                        }
                    }

                    fs.Close();
                }

                File.SetAttributes(appDataFileLocation, FileAttributes.Normal);

                if (WaitForFile(appDataFileLocation) == true)
                {
                    using (StreamWriter sw = File.CreateText(appDataFileLocation))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(sw, appData);
                        sw.Close();
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show("The log file used to obtain the correct key elements is in use by another user. Please try again shortly. If this issues continues, please contact Anthony.");
                }

                File.SetAttributes(appDataFileLocation, FileAttributes.Normal);
            }
            else
            {
                //TODO: Add logic to see which folder was not accesible.
                System.Windows.MessageBox.Show("The log file used to obtain the correct key elements is in use by another user. Please try again shortly. If this issues continues, please contact Anthony.");
            }
            //}
        }

        /// <summary>
        /// Blocks until the file is not locked any more.
        /// </summary>
        /// <param name="fullPath"></param>
        bool WaitForFile(string fullPath)
        {
            int numTries = 0;
            while (true)
            {
                ++numTries;
                try
                {
                    // Attempt to open the file exclusively.
                    using (FileStream fs = new FileStream(fullPath,
                        FileMode.Open, FileAccess.ReadWrite,
                        FileShare.None, 100))
                    {
                        fs.ReadByte();

                        // If we got this far the file is ready
                        break;
                    }
                }
                catch (Exception ex)
                {
                    //Log.LogWarning(
                    //   "WaitForFile {0} failed to get an exclusive lock: {1}",
                    //    fullPath, ex.ToString());

                    if (numTries > 10)
                    {
                        //Log.LogWarning(
                            //"WaitForFile {0} giving up after 10 tries",
                        //    fullPath);
                        return false;
                    }

                    // Wait for the lock to be released
                    System.Threading.Thread.Sleep(500);
                }
            }

            //Log.LogTrace("WaitForFile {0} returning true after {1} tries",
                //fullPath, numTries);
            return true;
        }
    }
}
    