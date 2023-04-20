using System;
using System.Collections.Generic;
using System.Text;
using GTC.Extensions;
using Newtonsoft.Json;
using System.Linq;
using System.IO;

namespace MsThreatModelParser
{
    public class ThreatListItem
    {
        public string threatId { get; set; }

        [JsonIgnore]
        public string includeStr { get; set; }

        [JsonIgnore]
        public string excludeStr { get; set; }

        public ThreatListItem() { }

        public ThreatListItem(string id, string inc, string exc)
        {
            threatId = id;
            includeStr = inc;
            excludeStr = exc;
        }
    }
}
