using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USeTeamDesktopTool.Data_Classes
{
    public class MappingSchema
    {
        public List<SingleDataElement> SchemaElements { get; set; }

        public MappingSchema()
        {
            SchemaElements = new List<SingleDataElement>();
        }
    }

    public class SingleDataElement
    {
        [JsonProperty("nodeid")]
        public int NodeId { get; set; }
        [JsonProperty("nodename")]
        public string NodeName { get; set; }
        [JsonProperty("elementid")]
        public int ElementId { get; set; }
        [JsonProperty("elementname")]
        public string ElementName { get; set; }
        [JsonProperty("isprimarykey")]
        public bool IsPrimaryKey { get; set; }
        [JsonProperty("fieldtype")]
        public string FieldType { get; set; }
        [JsonProperty("maxlegnth")]
        public int MaxLegnth { get; set; }
        [JsonProperty("useteamnotes")]
        public string USeTeamNotes { get; set; }
        [JsonProperty("implementationtarget")]
        public List<String> ImplementationTarget { get; set; }
        
    }
}
