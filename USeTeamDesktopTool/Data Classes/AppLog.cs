using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USeTeamDesktopTool.Data_Classes
{
    public class LoggedItems
    {
        [JsonProperty("Type")]
        public string Type { get; set; }
        [JsonProperty("DateTime")]
        public DateTime DateTime { get; set; }
        [JsonProperty("Desc")]
        public string Desc { get; set; }
    }
}
