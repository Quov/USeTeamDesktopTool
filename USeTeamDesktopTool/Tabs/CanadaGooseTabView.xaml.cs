using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using USeTeamDesktopTool.Data_Classes;

namespace USeTeamDesktopTool
{
    /// <summary>
    /// Interaction logic for SaveTabView.xaml
    /// </summary>
    public partial class CanadaGooseTabView : System.Windows.Controls.UserControl
    {
        CanadaGooseModel newCGFile;

        public CanadaGooseTabView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fileName = null;
            //SELECT FILE

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Select Canada Goose File";
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
                    fileName = filename;
                }
            }

            string content = System.IO.File.ReadAllText(fileName);

            //FIX LINE ENDINGS
            content = Regex.Replace(content, @"\n", "");
            content = Regex.Replace(content, @"\r", "\r\n");

            var invalidPathChars = content.Where(Path.GetInvalidPathChars().Contains).ToArray();
            if (invalidPathChars.Length > 0)
            {
                Console.WriteLine("invalid path chars: " + string.Join(string.Empty, invalidPathChars));
            }

            //Load data from the file
            newCGFile = LoadAdhocDate(content);

            //TODO: Add verification of the data to ensure the current process doesnt blow up
            //TODO: Auto-augment the data for known data issues?

            DataTable table = new DataTable();
            table = ToDataTable<CanadaGooseHeader>(newCGFile.CGHeader);
            HeaderDG.ItemsSource = newCGFile.CGHeader;

            DataTable table2 = new DataTable();
            table2 = ToDataTable<CanadaGooseSingleLine>(newCGFile.AllCGLines);
            LineDG.ItemsSource = newCGFile.AllCGLines;
        }

        public CanadaGooseModel LoadAdhocDate(string adhocFile)
        {
            CanadaGooseModel newCGFile = new CanadaGooseModel();

            using (StringReader reader = new StringReader(adhocFile))
            {
                string line;
                int i = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if(i == 1)
                    {
                        CanadaGooseHeader header = CanadaGooseHeader.FromCsv(line);
                        //DoSomething(line); or //save line into List<string>
                        newCGFile.CGHeader.Add(header);
                    }

                    if(i > 2)
                    {
                        CanadaGooseSingleLine newLine = CanadaGooseSingleLine.FromCsv(line);
                        newCGFile.AllCGLines.Add(newLine);
                    }
                    
                    i++;
                }
            }

            return newCGFile;
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

        private void AugmentLineBTN_Click(object sender, RoutedEventArgs e)
        {
            //TODO: add check to ensure model is not blank
            CanadaGooseAugmentWindow newWindow = new CanadaGooseAugmentWindow(newCGFile, HeaderDG, LineDG);
            newWindow.Show();
        }
    }
}
