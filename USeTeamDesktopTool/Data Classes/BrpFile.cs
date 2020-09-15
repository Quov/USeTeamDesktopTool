using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USeTeamDesktopTool.Data_Classes
{
    public class BrpFile
    {
        public List<SingleBrpEntry> AllBrpEntries { get; set; }

        public BrpFile()
        {
            AllBrpEntries = new List<SingleBrpEntry>();
        }
    }

    public class SingleBrpEntry
    {
        public int FileNo { get; set; }
        public int ClientNo { get; set; }
        public int FilerCode { get; set; }
        public string EntryNo { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime? LockOnFinal { get; set; }
        public DateTime? DateOfEntry { get; set; }
        public DateTime? LastExtracted { get; set; }

        public static SingleBrpEntry FromCsv(string csvLine)
        {
            csvLine = csvLine.Replace("\"", "");
            string[] values = csvLine.Split(',');

            DateTime? RelDate = null;
            DateTime? LockDate = null;
            DateTime? EntryDate = null;
            DateTime? LastExtractDate = null;

            if (values[4] != null && values[5].Length > 0)
            {
                RelDate = Convert.ToDateTime(values[5]);
            }
            if (values[6] != null && values[7].Length > 0)
            {
                LockDate = Convert.ToDateTime(values[7]);
            }
            if (values[8] != null && values[9].Length > 0)
            {
                EntryDate = Convert.ToDateTime(values[9]);
            }
            if (values[10] != null && values[11].Length > 0)
            {
                LastExtractDate = Convert.ToDateTime(values[11]);
            }

            SingleBrpEntry newEntry = new SingleBrpEntry
            {
                FileNo = Convert.ToInt32(values[0]),
                ClientNo = Convert.ToInt32(values[1]),
                FilerCode = Convert.ToInt32(values[2]),
                EntryNo = Convert.ToString(values[3]),
                ReleaseDate = RelDate,
                LockOnFinal = LockDate,
                DateOfEntry = EntryDate,
                LastExtracted = LastExtractDate
            };

            return newEntry;
        }

    }
}
