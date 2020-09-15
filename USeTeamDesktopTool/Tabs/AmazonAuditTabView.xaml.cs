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
    public partial class AmazonAuditTabView : System.Windows.Controls.UserControl
    {
        public AmazonAuditTabView()
        {
            InitializeComponent();
        }

        private void SelectAssistRerportBTN_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Select Assist Report File";
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

        private void SelectDBFileBTN_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Select Parts DB File";
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
                    PartDBTB.Text = filename;
                }
            }
        }

        private void RunAnalysisBTN_Click(object sender, RoutedEventArgs e)
        {
            AmznAssist newAssist = new AmznAssist();
            AmznAdHoc newAdHoc = new AmznAdHoc();
            AssistError newErrors = new AssistError();

            newAssist = LoadAssistCsv(PartDBTB.Text);
            newAdHoc = LoadAdHocData(AssistReportTB.Text);

            foreach (AdHocItem item in newAdHoc.AllAdhocItems)
            {
                SingleAmznAssist assistItem = newAssist.AllAmznList.Where(x => x.ASIN == item.PartNo).FirstOrDefault();
                double correctValue = 0;
                double test = 0;
                if (assistItem != null)
                {
                    //test = RoundUp(assistItem.AssistValue, 2);
                    test = assistItem.AssistValue;
                    correctValue = test * item.CommQty;
                }
                if (Math.Round(correctValue, 2) != (RoundUp(item.AssistValue, 2) / 100))
                {
                    //CREATE ERROR RECORD TO DISPLAY HERE
                    SingleAssistError newError = new SingleAssistError();
                    newError.FileNo = item.FileNo;
                    newError.ClientNo = item.ClientNo;
                    newError.CommInvNo = item.CommInvNo;
                    newError.CommInvLineNo = item.CommInvLineNo;
                    newError.CommQty = item.CommQty;
                    newError.Uom = item.Uom;
                    newError.PartNo = item.PartNo;
                    newError.ForeignValue = item.ForeignValue;
                    //newError.AssistValue = (RoundUp(item.AssistValue,2)/100);
                    newError.AssistValue = item.AssistValue/100;
                    newError.FileLogged = item.FileLogged;
                    newError.CR = item.CR;
                    newError.ES = item.ES;
                    //if (assistItem != null) { newError.AmznAssistValuePerPart = RoundUp(assistItem.AssistValue,2); }
                    if (assistItem != null) { newError.AmznAssistValuePerPart = assistItem.AssistValue; }
                    newError.CorrectAssistValue = correctValue;
                    newError.Status = "FAIL";
                    if (assistItem == null || assistItem.ASIN == "")
                    {
                        
                        newError.PartStatus = "NO PART FOUND IN CAT FILE";
                    }
                    else
                    {
                        newError.PartStatus = "PART FOUND IN CAT FILE";
                    }
                    newErrors.AllAssistErrors.Add(newError);
                }
                else
                {
                    SingleAssistError newError = new SingleAssistError();
                    newError.FileNo = item.FileNo;
                    newError.ClientNo = item.ClientNo;
                    newError.CommInvNo = item.CommInvNo;
                    newError.CommInvLineNo = item.CommInvLineNo;
                    newError.CommQty = item.CommQty;
                    newError.Uom = item.Uom;
                    newError.PartNo = item.PartNo;
                    newError.ForeignValue = item.ForeignValue;
                    //newError.AssistValue = (RoundUp(item.AssistValue, 2) / 100);
                    newError.AssistValue = item.AssistValue/100;
                    newError.FileLogged = item.FileLogged;
                    newError.CR = item.CR;
                    newError.ES = item.ES;
                    //if (assistItem != null) { newError.AmznAssistValuePerPart = RoundUp(assistItem.AssistValue,2); }
                    if (assistItem != null) { newError.AmznAssistValuePerPart = assistItem.AssistValue; }
                    newError.CorrectAssistValue = correctValue;
                    newError.Status = "PASS";
                    if (assistItem == null || assistItem.ASIN == "")
                    {
                        newError.Status = "FAIL";
                        newError.PartStatus = "NO PART FOUND IN CAT FILE";
                    }
                    else
                    {
                        newError.PartStatus = "PART FOUND IN CAT FILE";
                    }
                    newErrors.AllAssistErrors.Add(newError);
                }
            }

            DataTable table = new DataTable();
            table = ToDataTable<SingleAssistError>(newErrors.AllAssistErrors);
            DataGridViewDG.ItemsSource = newErrors.AllAssistErrors;

            double totalItems = newErrors.AllAssistErrors.Count();
            double totalErrorItems = newErrors.AllAssistErrors.Where(x => x.Status == "FAIL").Count();
            double accuracyPercentage = ((totalItems - totalErrorItems) / totalItems) * 100;

            AccPercLabel.Content = "Accuracy Rate : " + accuracyPercentage.ToString("f2") + " %";
            if (accuracyPercentage >= 95)
            {
                AccPercLabel.Foreground = System.Windows.Media.Brushes.Green;
            }
            else if (accuracyPercentage >= 85 && accuracyPercentage < 95)
            {
                AccPercLabel.Foreground = System.Windows.Media.Brushes.Orange;
            }
            else
            {
                AccPercLabel.Foreground = System.Windows.Media.Brushes.Red;
            }
        }

        private void ExcelOutputBTN_Click_1(object sender, RoutedEventArgs e)
        {
            ExportToExcel<SingleAssistError, List<SingleAssistError>> s = new ExportToExcel<SingleAssistError, List<SingleAssistError>>();
            s.dataToPrint = (List<SingleAssistError>)DataGridViewDG.ItemsSource;
            s.GenerateReport();
        }

        private AmznAdHoc LoadAdHocData(string adhocFile)
        {
            AmznAdHoc newAmznAdHoc = new AmznAdHoc();
            //TODO : ADD CHECK HERE
            List<AdHocItem> values = File.ReadAllLines(adhocFile)
                                           .Skip(1)
                                           .Select(v => AdHocItem.FromCsv(v))
                                           .ToList();
            newAmznAdHoc.AllAdhocItems = values;
            return newAmznAdHoc;
        }

        private AmznAssist LoadAssistCsv(string assistFileCsv)
        {
            AmznAssist newAmznAssist = new AmznAssist();

            List<SingleAmznAssist> values = File.ReadAllLines(assistFileCsv)
                                           .Skip(1)
                                           .Select(v => SingleAmznAssist.FromCsv(v))
                                           .ToList();
            newAmznAssist.AllAmznList = values;
            return newAmznAssist;


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
