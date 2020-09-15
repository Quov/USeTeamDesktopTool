using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USeTeamDesktopTool.Data_Classes
{
    public class CanadaGooseJson
    {
        public List<SingleAugment> AllAugments { get; set; }

        public CanadaGooseJson()
        {
            AllAugments = new List<SingleAugment>();
        }
    }

    public class SingleAugment
    {
        [JsonProperty("augmenttype")]
        public string AugmentType { get; set; }
        [JsonProperty("initialvalue")]
        public string InitialValue { get; set; }
        [JsonProperty("finalvalue")]
        public string FinalValue { get; set; }


    }

}
