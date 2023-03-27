using System;
using System.Collections.Generic;
using System.Text;
using GTC.Extensions;
using Newtonsoft.Json;
using System.Linq;
using System.IO;

namespace MsThreatModelParser
{
    public class StandardElementEx
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Behavior { get; set; }

        public List<ThreatListItem> threatTypesTiedToThisElement { get; set; }

        [JsonIgnore]
        public KnowledgeBaseElementType2 standardElement { get; set; }

        public StandardElementEx()
        {
            standardElement = new KnowledgeBaseElementType2();
            ID = string.Empty;
            Name = string.Empty;
            Behavior = string.Empty;
            threatTypesTiedToThisElement = new List<ThreatListItem>();
        }

        public StandardElementEx(KnowledgeBaseElementType2 kbet2)
        {
            standardElement = kbet2;
            ID = kbet2.ID;
            Name = kbet2.Name;
            Behavior = Behaviors.GetBehavior(kbet2.Representation);
            threatTypesTiedToThisElement = new List<ThreatListItem>();
        }
    }
}
