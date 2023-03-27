using System;
using System.Collections.Generic;
using System.Text;
using GTC.Extensions;
using Newtonsoft.Json;
using System.Linq;
using System.IO;

namespace MsThreatModelParser
{
    public class ThreatCategoryEx
    {
        [JsonIgnore]
        public KnowledgeBaseThreatCategory KnowledgeBaseThreatCategory { get; set; }

        public string Name { get; set; }

        public Dictionary<string, ThreatTypeEx> threatTypes { get; set; }    
        
        public ThreatCategoryEx()
        {
            KnowledgeBaseThreatCategory = new KnowledgeBaseThreatCategory();
            threatTypes = new Dictionary<string, ThreatTypeEx>();
        }

        public ThreatCategoryEx(KnowledgeBaseThreatCategory kbtc)
        {
            KnowledgeBaseThreatCategory = kbtc;
            Name = kbtc.Name;
            threatTypes = new Dictionary<string, ThreatTypeEx>();
        }

        public void AddThreatType(ThreatTypeEx threat)
        {
            if(threatTypes.ContainsKey(threat.Name) == true)
            {
                Console.WriteLine($"Found duplicate entry in ThreatTypes: {threat.Name}");
                return;
            }
            threatTypes.Add(threat.Name, threat);
        }
    }
}
