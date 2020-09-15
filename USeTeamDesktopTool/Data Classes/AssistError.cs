using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USeTeamDesktopTool.Data_Classes
{
    public class AssistError
    {
        public List<SingleAssistError> AllAssistErrors { get; set; }

        public AssistError()
        {
            AllAssistErrors = new List<SingleAssistError>();
        }
    }

    public class SingleAssistError
    {
        public string FileNo { get; set; }
        public int ClientNo { get; set; }
        public string CommInvNo { get; set; }
        public int CommInvLineNo { get; set; }
        public double CommQty { get; set; }
        public string Uom { get; set; }
        public string PartNo { get; set; }
        public double ForeignValue { get; set; }
        public double AssistValue { get; set; }
        public string FileLogged { get; set; }
        public string CR { get; set; }
        public string ES { get; set; }
        public double AmznAssistValuePerPart { get; set; }
        public double CorrectAssistValue { get; set; }
        public string Status { get; set; }
        public string PartStatus { get; set; }
    }

}
