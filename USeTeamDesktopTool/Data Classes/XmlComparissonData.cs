using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USeTeamDesktopTool.Data_Classes
{
    public class XmlComparissonData
    {
        public List<SingleDifferenceData> AllFileDifferencesList { get; set; }

        public XmlComparissonData()
        {
            AllFileDifferencesList = new List<SingleDifferenceData>();
        }
    }

    public class SingleDifferenceData
    {
        //Add, Remove, Change
        public string AlterationType { get; set; }
        public string InitialValue { get; set; }
        public string FinalValue { get; set; }
        public string NodeName { get; set; }
        public string ParentNodeName { get; set; }
        public string OriginalDocPath { get; set; }
    }
      
}
