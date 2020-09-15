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
using USeTeamDesktopTool.Functions;

namespace USeTeamDesktopTool
{
    /// <summary>
    /// Interaction logic for AmazonAuditTabView.xaml
    /// </summary>
    public partial class BrpF1AuditTabView : System.Windows.Controls.UserControl
    {
        public BrpF1AuditTabView()
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

        private void RunAnalysisBTN_Click(object sender, RoutedEventArgs e)
        {
            BrpFile newBrpFile = new BrpFile();
            BrpFile newErrorFiles = new BrpFile();
            List<int> errorFileNoList = new List<int>();

            newBrpFile = LoadAdhocDate(AdhocReportTB.Text);

            foreach(SingleBrpEntry entry in newBrpFile.AllBrpEntries)
            {
                if(entry.DateOfEntry > entry.LastExtracted || entry.LockOnFinal > entry.LastExtracted ||
                    entry.ReleaseDate > entry.LastExtracted)
                {
                    if (entry.DateOfEntry != null && entry.LockOnFinal != null && entry.ReleaseDate != null)
                    {
                        newErrorFiles.AllBrpEntries.Add(entry);
                        errorFileNoList.Add(entry.FileNo);
                    }                   
                }
            }

            DataTable table = new DataTable();
            table = ToDataTable<SingleBrpEntry>(newErrorFiles.AllBrpEntries);
            DataGridViewDG.ItemsSource = newErrorFiles.AllBrpEntries;

            BrpAuditFileSelectPopup newPopup = new BrpAuditFileSelectPopup();
            newPopup.AddItemsToLB(errorFileNoList);
            newPopup.Show();

            System.Windows.Forms.MessageBox.Show("Found " + newErrorFiles.AllBrpEntries.Count + " Entrys to be retriggered.");
        }

        private void ExcelOutputBTN_Click_1(object sender, RoutedEventArgs e)
        {
            
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

        public BrpFile LoadAdhocDate(string adhocFile)
        {
            BrpFile newBrpFile = new BrpFile();
            List<SingleBrpEntry> values = File.ReadAllLines(adhocFile)
                                            .Skip(1)
                                            .Select(v => SingleBrpEntry.FromCsv(v))
                                            .ToList();
            newBrpFile.AllBrpEntries = values;
            return newBrpFile;
        }
    }
}
