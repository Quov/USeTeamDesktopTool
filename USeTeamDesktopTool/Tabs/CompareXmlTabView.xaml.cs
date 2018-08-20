using KellermanSoftware.CompareNetObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using USeTeamDesktopTool.Data_Classes;
using USeTeamDesktopTool.Functions;


namespace USeTeamDesktopTool
{
    /// <summary>
    /// Interaction logic for SaveTabView.xaml
    /// </summary>
    public partial class CompareTabView : System.Windows.Controls.UserControl
    {

        public string filename1 = string.Empty;
        public string filename2 = string.Empty;


        public CompareTabView()
        {
            InitializeComponent();
        }

        private void CompareFilesBTN_Click(object sender, RoutedEventArgs e)
        {
            //Check if file 1 is safe and valid.
            if (FileOneTB.Text == null || FileOneTB.Text == string.Empty)
            {
                System.Windows.MessageBox.Show("File 1 not selected, please select");
                return;
            }

            if (!File.Exists(FileOneTB.Text))
            {
                System.Windows.MessageBox.Show("File 1 doesnt exist, please select another file");
                return;
            }

            //Check if file 2 is safe and valid.
            if (FileTwoTB.Text == null || FileTwoTB.Text == string.Empty)
            {
                System.Windows.MessageBox.Show("File 2 not selected, please select");
                return;
            }

            if (!File.Exists(FileTwoTB.Text))
            {
                System.Windows.MessageBox.Show("File 2 doesnt exist, please select another file");
                return;
            }

            //TODO: Need to add log item.
            //TODO: Need to review process and develop method to summarize the differences, rather than page through the entire file.
            //TODO: Develop method to cleanup old compare files on program start
            //TODO: Refactor the paths to be at the proper location within the APP

            DoCompare(FileOneTB.Text, FileTwoTB.Text);
        }

        public void DoCompare(string file1, string file2)
        {
            string tempFilePath1 = null;
            string tempFilePath2 = null;

            tempFilePath1 = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + @"\Data\temp1.xml";
            tempFilePath2 = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + @"\Data\temp2.xml";


            DataGridViewCompare.ItemsSource = null;
            DataGridViewCompare.Columns.Clear();
            try
            {
                XmlComparissonData compareData = new XmlComparissonData();

                StreamReader str = new StreamReader(file1);
                StreamReader str2 = new StreamReader(file2);

                //TODO: If checkbox is checked, we need to remove the 'revised' elements and replace with the originals. perhaps do a search of all elements with a -X?
                //TODO: If checked, we should load a file into memory, revise necessary nodes, ala XMLTest1Replace Functions, and push the resulting string to the streamreader
                //TODO: Perhaps add logic to only look for 1 or 2 character revision.
                if (FileOneRevisionCB.IsChecked ?? false)
                {
                    str.Close();
                    XMLTest1Replace fieldReplacer = new XMLTest1Replace();
                    Regex BeforeDash = new Regex(".*(?=\\-)");
                    Regex AfterDash = new Regex("(\\d+)[^-]*$");
                    string NewMasterBill = null;
                    string NewMasterBillWM = null;
                    string NewCommInv = null;

                    XMLTest1Replace matchEntry = new XMLTest1Replace();

                    XmlDocument doc = new XmlDocument();
                    doc.Load(file1);

                    XmlNamespaceManager namespaces = new XmlNamespaceManager(doc.NameTable);
                    namespaces.AddNamespace("dft", "http://www.kewill.com/Customs/edi");

                    XmlNodeList WorkMgmtNode = doc.SelectNodes("/dft:SHIPMENT/dft:SHIPMENT_MAIN/dft:DASHBOARD_WORK_MGMT", namespaces);
                    foreach (XmlNode node in WorkMgmtNode)
                    {
                        if (node["MASTER_BILL"] != null) { NewMasterBillWM = node["MASTER_BILL"].InnerText; }
                    }

                    XmlNodeList GeneralShipmentInformation = doc.SelectNodes("/dft:SHIPMENT/dft:SHIPMENT_MAIN/dft:EDI_SHIPMENT_HEADER", namespaces);
                    foreach (XmlNode node in GeneralShipmentInformation)
                    {
                        if (node["MASTER_BILL"] != null) { NewMasterBill = node["MASTER_BILL"].InnerText; }
                    }

                    String NewMasterBill2 = BeforeDash.Match(NewMasterBill).ToString();
                    String NewMasterBillWM2 = BeforeDash.Match(NewMasterBillWM).ToString();

                    XmlNodeList elemList = doc.GetElementsByTagName("MASTER_BILL");
                    for (int i = 0; i < elemList.Count; i++)
                    {
                        elemList[i].InnerText = NewMasterBill2;
                    }

                    XmlNodeList WorkMgmtNode2 = doc.SelectNodes("/dft:SHIPMENT/dft:SHIPMENT_MAIN/dft:DASHBOARD_WORK_MGMT", namespaces);
                    foreach (XmlNode node in WorkMgmtNode2)
                    {
                        if (node["MASTER_BILL"] != null) { node["MASTER_BILL"].InnerText = NewMasterBillWM2; }
                    }

                    XmlNodeList commInv = doc.SelectNodes("/dft:SHIPMENT//dft:COMM_INV_NO", namespaces);
                    foreach (XmlNode node in commInv)
                    {
                        if (node.InnerText != null) { NewCommInv = node.InnerText; }
                        NewCommInv = BeforeDash.Match(NewCommInv).ToString();
                        if (node.InnerText != null) { node.InnerText = NewCommInv; }
                    }

                    //TODO: Add Master_bill_addl

                    doc.Save(tempFilePath1);
                    //TODO: make this store in temp location and delete
                    str = new StreamReader(tempFilePath1);
                }

                if (FileTwoRevisionCB.IsChecked ?? false)
                {
                    str2.Close();
                    XMLTest1Replace fieldReplacer = new XMLTest1Replace();
                    Regex BeforeDash = new Regex(".*(?=\\-)");
                    Regex AfterDash = new Regex("(\\d+)[^-]*$");
                    string NewMasterBill = null;
                    string NewMasterBillWM = null;
                    string NewCommInv = null;

                    XMLTest1Replace matchEntry = new XMLTest1Replace();

                    XmlDocument doc = new XmlDocument();
                    doc.Load(file2);

                    XmlNamespaceManager namespaces = new XmlNamespaceManager(doc.NameTable);
                    namespaces.AddNamespace("dft", "http://www.kewill.com/Customs/edi");

                    XmlNodeList WorkMgmtNode = doc.SelectNodes("/dft:SHIPMENT/dft:SHIPMENT_MAIN/dft:DASHBOARD_WORK_MGMT", namespaces);
                    foreach (XmlNode node in WorkMgmtNode)
                    {
                        if (node["MASTER_BILL"] != null) { NewMasterBillWM = node["MASTER_BILL"].InnerText; }
                    }

                    XmlNodeList GeneralShipmentInformation = doc.SelectNodes("/dft:SHIPMENT/dft:SHIPMENT_MAIN/dft:EDI_SHIPMENT_HEADER", namespaces);
                    foreach (XmlNode node in GeneralShipmentInformation)
                    {
                        if (node["MASTER_BILL"] != null) { NewMasterBill = node["MASTER_BILL"].InnerText; }
                    }

                    String NewMasterBill2 = BeforeDash.Match(NewMasterBill).ToString();
                    String NewMasterBillWM2 = BeforeDash.Match(NewMasterBillWM).ToString();

                    XmlNodeList elemList = doc.GetElementsByTagName("MASTER_BILL");
                    for (int i = 0; i < elemList.Count; i++)
                    {
                        elemList[i].InnerText = NewMasterBill2;
                    }

                    XmlNodeList WorkMgmtNode2 = doc.SelectNodes("/dft:SHIPMENT/dft:SHIPMENT_MAIN/dft:DASHBOARD_WORK_MGMT", namespaces);
                    foreach (XmlNode node in WorkMgmtNode2)
                    {
                        if (node["MASTER_BILL"] != null) { node["MASTER_BILL"].InnerText = NewMasterBillWM2; }
                    }

                    XmlNodeList commInv = doc.SelectNodes("/dft:SHIPMENT//dft:COMM_INV_NO", namespaces);
                    foreach (XmlNode node in commInv)
                    {
                        if (node.InnerText != null) { NewCommInv = node.InnerText; }
                        NewCommInv = BeforeDash.Match(NewCommInv).ToString();
                        if (node.InnerText != null) { node.InnerText = NewCommInv; }
                    }

                    //TODO: Add Master_bill_addl

                    doc.Save(tempFilePath2);
                    //TODO: make this store in temp location and delete
                    str2 = new StreamReader(tempFilePath2);
                }

                XmlSerializer xSerializer = new XmlSerializer(typeof(Shipment));

                Shipment shipmentOne = (Shipment)xSerializer.Deserialize(str);
                Shipment shipmentTwo = (Shipment)xSerializer.Deserialize(str2);

                ComparisonConfig config = new ComparisonConfig();
                config.MembersToIgnore.Add("Length");
                config.MembersToIgnore.Add("LongLength");

                //TODO: add this as a user defineable exclusion
                config.MembersToIgnore.Add("MatchEntry");
                config.MembersToIgnore.Add("SubSubBill");
                config.MembersToIgnore.Add("MatchShipment");

                //TODO: REMOVE THIS!!!!
                config.MembersToIgnore.Add("MasterBill");

                config.MaxDifferences = 9999;
                config.IgnoreCollectionOrder = true;

                var spec = new Dictionary<Type, IEnumerable<string>>();
                //TODO : Add a spec for each main element that have the potential of multiple instances within the file
                spec.Add(typeof(ShipmentHeaderFlex), new string[] { "MasterBill", "HouseBill", "SubBill", "SubSubBill" });
                spec.Add(typeof(ShipmentId), new string[] { "MasterBill", "HouseBill", "SubBill", "SubSubBill", "SeqNo" });
                spec.Add(typeof(ShipmentDate), new string[] { "MasterBill", "HouseBill", "SubBill", "SubSubBill", "TracingDateNo" });
                spec.Add(typeof(InvoiceHeader), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice" });
                spec.Add(typeof(InvoiceHeaderFlex), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice" });
                spec.Add(typeof(InvoiceAddresses), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "PartiesQualifier" });
                spec.Add(typeof(InvoiceLine), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo" });
                spec.Add(typeof(InvoiceParty), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo", "PartiesQualifier" });
                spec.Add(typeof(InvoiceLineFlex), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo" });
                spec.Add(typeof(InvoiceLineTariffClass), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo", "TariffNo", "TariffLineNo" });

                spec.Add(typeof(PgEs), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo", "TariffLineNo", "PgCd", "PgSeqNbr" });

                spec.Add(typeof(PgEpaEs), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo", "TariffLineNo", "PgCd", "PgSeqNbr" });
                spec.Add(typeof(PgEpaEsParties), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo", "TariffLineNo", "PgCd", "PgSeqNbr", "PartySeqNbr" });
                spec.Add(typeof(PgEpaEsProdComp), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo", "TariffLineNo", "PgCd", "PgSeqNbr", "ComponentSeqNbr" });
                spec.Add(typeof(PgEpaEsAddlItemId), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo", "TariffLineNo", "PgCd", "PgSeqNbr", "ItemSeqNbr" });
                spec.Add(typeof(PgEpaEsRemarks), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo", "TariffLineNo", "PgCd", "PgSeqNbr", "RemarksSeqNbr" });

                spec.Add(typeof(PgFdaEs), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo", "TariffLineNo", "PgCd", "PgSeqNbr" });
                spec.Add(typeof(PgFdaEsParties), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo", "TariffLineNo", "PgCd", "PgSeqNbr", "PartySeqNbr" });
                spec.Add(typeof(PgFdaEsCountries), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo", "TariffLineNo", "PgCd", "PgSeqNbr", "CountrySeqNbr" });
                spec.Add(typeof(PgFdaEsContainers), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo", "TariffLineNo", "PgCd", "PgSeqNbr", "ContainerNo" });
                spec.Add(typeof(PgFdaEsCompliance), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo", "TariffLineNo", "PgCd", "PgSeqNbr", "ComplianceSeqNbr" });
                spec.Add(typeof(PgFdaEsIngredients), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo", "TariffLineNo", "PgCd", "PgSeqNbr", "IngredientSeqNbr" });
                spec.Add(typeof(PgFdaEsRemarks), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo", "TariffLineNo", "PgCd", "PgSeqNbr", "RemarksSeqNbr" });
                spec.Add(typeof(PgFdaEsAddlLots), new string[] { "ManufacturerId", "CommInvNo", "DateInvoice", "CommInvLineNo", "TariffLineNo", "PgCd", "PgSeqNbr", "LotSeqNbr" });

                config.CollectionMatchingSpec = spec;
           
                CompareLogic compareLogic = new CompareLogic(config);

                ComparisonResult result = compareLogic.Compare(shipmentOne, shipmentTwo);

                Regex r = new Regex("(?<=\\.)[^.]*$");

                //ISSUES: Doesnt show if an additional item exists, such as a 2nd invoice header. Shows count and legnth differences.
                //ISSUES: Figure out a better way to display the differneces in added/removed elements like EDI_INVOICE_HEADER
                //          - Perhaps add functionality to equalize like nodes, such as revisions with an appended -X in certain elements. (MasterBill, CommInvNo, MasterBillAddl)
                //          - Maybe a checkbox to mark for comparing revisions?

                if (result.AreEqual)
                    System.Windows.MessageBox.Show("These Files are identical.");

                foreach (var diff in result.Differences)
                {
                    if (diff.Object1Value.ToString() == "(null)")
                    {
                        SingleDifferenceData diffData = new SingleDifferenceData();
                        diffData.AlterationType = "ADDED";
                        diffData.NodeName = r.Match(diff.PropertyName).ToString();
                        diffData.ParentNodeName = r.Match(diff.ParentPropertyName).ToString();
                        if (diff.Object1Value == "USeTeamDesktopTool.Data_Classes.InvoiceHeader")
                        {
                            diffData.InitialValue = "VIEW XML";
                        }
                        else
                        {
                            diffData.InitialValue = diff.Object1Value;
                        }

                        if (diff.Object2Value == "USeTeamDesktopTool.Data_Classes.InvoiceHeader")
                        {
                            diffData.FinalValue = "VIEW XML";
                        }
                        else
                        {
                            diffData.FinalValue = diff.Object2Value;
                        }
                        diffData.OriginalDocPath = diff.ParentPropertyName;
                        compareData.AllFileDifferencesList.Add(diffData);
                    }
                    else if (diff.Object2Value.ToString() == "(null)")
                    {
                        SingleDifferenceData diffData = new SingleDifferenceData();
                        diffData.AlterationType = "REMOVED";
                        diffData.NodeName = r.Match(diff.PropertyName).ToString();
                        diffData.ParentNodeName = r.Match(diff.ParentPropertyName).ToString();
                        if(diff.Object1Value == "USeTeamDesktopTool.Data_Classes.InvoiceHeader")
                        {
                            diffData.InitialValue = "VIEW XML";
                        }
                        else
                        {
                            diffData.InitialValue = diff.Object1Value;
                        }

                        if(diff.Object2Value == "USeTeamDesktopTool.Data_Classes.InvoiceHeader")
                        {
                            diffData.FinalValue = "VIEW XML";
                        }
                        else
                        {
                            diffData.FinalValue = diff.Object2Value;
                        }
                        
                        diffData.OriginalDocPath = diff.ParentPropertyName;
                        compareData.AllFileDifferencesList.Add(diffData);
                    }
                    else if (diff.Object1Value != diff.Object2Value)
                    {
                        SingleDifferenceData diffData = new SingleDifferenceData();
                        diffData.AlterationType = "CHANGED";
                        diffData.NodeName = r.Match(diff.PropertyName).ToString();
                        diffData.ParentNodeName = r.Match(diff.ParentPropertyName).ToString();
                        diffData.InitialValue = diff.Object1Value;
                        diffData.FinalValue = diff.Object2Value;
                        diffData.OriginalDocPath = diff.ParentPropertyName;
                        compareData.AllFileDifferencesList.Add(diffData);
                    }
                }

                DataTable table = new DataTable();
                table = ToDataTable<SingleDifferenceData>(compareData.AllFileDifferencesList);
                DataGridViewCompare.ItemsSource = compareData.AllFileDifferencesList;

                //STEP 2 : Use Parsed Path to gather nodes and paths from the initial document.
                //STEP 3 : If needed, used Parsed Path to gather data from the second comparison document.
                //STEP 4 : Build method to consolidate and display the changes only. Using the .out file, we should be able to go back through the two
                //         documents and get the node name and possibly display it as follows
                //
                //           DIFF_TYPE | PATH                                        | NODE_NAME  | INITIAL_VALUE | FINAL_VALUE
                //           --------------------------------------------------------------------------------------------------
                //           CHANGE    | SHIPMENT/SHIPMENT_MAIN/DASHBOARD_WORK_MGMT/ | PROCESS_CD | U             | P
                // 
                str.Close();
                str2.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
                System.Windows.MessageBox.Show("An error occured. Contact the correct handsome edi guy.");
            }
            
            if(File.Exists(tempFilePath1))
            {
                File.Delete(tempFilePath1);
            }
            if(File.Exists(tempFilePath2))
            {
                File.Delete(tempFilePath2);
            }
        }

        private void SelectFileOneBTN_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Select XML File";
            openFileDialog1.Multiselect = false;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openFileDialog1.FileNames)
                {
                    FileOneTB.Text = filename;
                }
            }
        }

        private void SelectFileTwoBTN_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.InitialDirectory = @"C:\";
            openFileDialog2.Title = "Select XML File";
            openFileDialog2.Multiselect = false;
            openFileDialog2.CheckFileExists = true;
            openFileDialog2.CheckPathExists = true;
            openFileDialog2.DefaultExt = "xml";
            openFileDialog2.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog2.FilterIndex = 1;
            openFileDialog2.RestoreDirectory = true;
            openFileDialog2.ReadOnlyChecked = true;
            openFileDialog2.ShowReadOnly = true;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openFileDialog2.FileNames)
                {
                    FileTwoTB.Text = filename;
                }
            }
        }

        public string GetXPathToNode(XmlNode node)
        {
            if (node.NodeType == XmlNodeType.Attribute)
            {
                // attributes have an OwnerElement, not a ParentNode; also they have             
                // to be matched by name, not found by position             
                return String.Format("{0}/@{1}", GetXPathToNode(((XmlAttribute)node).OwnerElement), node.Name);
            }
            if (node.ParentNode == null)
            {
                // the only node with no parent is the root node, which has no path
                return "";
            }

            // Get the Index
            int indexInParent = 1;
            XmlNode siblingNode = node.PreviousSibling;
            // Loop thru all Siblings
            while (siblingNode != null)
            {
                // Increase the Index if the Sibling has the same Name
                if (siblingNode.Name == node.Name)
                {
                    indexInParent++;
                }
                siblingNode = siblingNode.PreviousSibling;
            }

            //the path to a node is the path to its parent, plus "/node()[n]", where n is its position among its siblings.
            return String.Format("{0}/{1}[{2}]", GetXPathToNode(node.ParentNode), node.Name, indexInParent);
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

        static int GetNodePosition(XmlNode child)
        {
            for (int i = 0; i < child.ParentNode.ChildNodes.Count; i++)
            {
                if (child.ParentNode.ChildNodes[i] == child)
                {
                    // tricksy XPath, not starting its positions at 0 like a normal language
                    return i + 1;
                }
            }
            throw new InvalidOperationException("Child node somehow not found in its parent's ChildNodes property.");
        }

        static string GetXPathToNode2(XmlNode node)
        {
            if (node.NodeType == XmlNodeType.Attribute)
            {
                // attributes have an OwnerElement, not a ParentNode; also they have
                // to be matched by name, not found by position
                return String.Format(
                    "{0}/@{1}",
                    GetXPathToNode2(((XmlAttribute)node).OwnerElement),
                    node.Name
                    );
            }
            if (node.ParentNode == null)
            {
                // the only node with no parent is the root node, which has no path
                return "";
            }
            // the path to a node is the path to its parent, plus "/node()[n]", where 
            // n is its position among its siblings.
            return String.Format(
                "{0}/node()[{1}]",
                GetXPathToNode2(node.ParentNode),
                GetNodePosition(node)
                );
        }

    }
}
