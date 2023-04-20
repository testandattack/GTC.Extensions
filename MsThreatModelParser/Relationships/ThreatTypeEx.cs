using System;
using System.Collections.Generic;
using System.Text;
using GTC.Extensions;
using Newtonsoft.Json;
using System.Linq;
using System.IO;

namespace MsThreatModelParser
{
    public class ThreatTypeEx
    {
        [JsonIgnore]
        public KnowledgeBaseThreatType KnowledgeBaseThreatType { get; set; }

        public string Name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        public string includeStr { get; set; }

        public List<string> includes { get; set;}

        public string excludeStr { get; set; }

        public List<string> excludes { get; set; }
        
        public ThreatTypeEx()
        {
            KnowledgeBaseThreatType = new KnowledgeBaseThreatType();
            includes = new List<string>();
            excludes = new List<string>();
        }

        public ThreatTypeEx(KnowledgeBaseThreatType kbtt)
        {
            KnowledgeBaseThreatType = kbtt;
            Name = kbtt.ShortTitle;
            FillFilters(kbtt.GenerationFilters);
        }

        public ThreatTypeEx(KnowledgeBaseThreatType kbtt, List<KnowledgeBaseThreatCategory> kbtc)
        {
            KnowledgeBaseThreatType = kbtt;
            Name = kbtt.ShortTitle;
            
            var category = kbtc.Where(c => c.Id == kbtt.Category).FirstOrDefault();
            if (category != null)
                Category = category.Name;
            
            FillFilters(kbtt.GenerationFilters);
        }

        private void FillFilters(KnowledgeBaseThreatTypeGenerationFilters filters)
        {
            // Find all values inside single quotes and add to list
            includes = filters.Include.FindSubStrings('\'');
            // Find all values outside single quotes and add the ones with 
            // attributes (strings following a period
            var extraInc = filters.Include.FindSubStrings('\'', true)
                .Where(f => f.Contains("."))
                .ToList();
            if (extraInc != null && extraInc.Count > 0)
                foreach(string str in extraInc)
                    includes.Add(str.FindSubString(".", " ", true));
            // Save the unparsed string 
            includeStr = filters.Include;


            // Find all values inside single quotes and add to list
            excludes = filters.Exclude.FindSubStrings('\'');
            // Find all values outside single quotes and add the ones with 
            // attributes (strings following a period
            var extraExc = filters.Exclude.FindSubStrings('\'', true)
                .Where(f => f.Contains("."))
                .ToList();
            if (extraExc != null && extraExc.Count > 0)
                foreach (string str in extraExc)
                    excludes.Add(str.FindSubString(".", " ", true));
            // Save the unparsed string 
            excludeStr = filters.Exclude;
        }
    }
}
