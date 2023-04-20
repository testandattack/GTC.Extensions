using System;
using System.Collections.Generic;
using System.Text;
using GTC.Extensions;
using Newtonsoft.Json;
using System.Linq;
using System.IO;

namespace MsThreatModelParser
{
    public class IncAndExc
    {
        public List<string> includes { get; set; }
        public List<string> excludes { get; set; }

        public IncAndExc()
        {
            includes = new List<string>();
            excludes = new List<string>();
        }

        public IncAndExc(Dictionary<string, ThreatCategoryEx> threatCategories)
        {
            includes = new List<string>();
            excludes = new List<string>();

            foreach(var category in threatCategories.Values)
            {
                foreach(var threat in category.threatTypes)
                {
                    if (String.IsNullOrEmpty(threat.Value.includeStr) == false
                        && threat.Value.includeStr != " ")
                    {
                        includes.Add(threat.Value.includeStr);
                    }
                    if (String.IsNullOrEmpty(threat.Value.excludeStr) == false
                        && threat.Value.excludeStr != " ")
                    {
                        excludes.Add(threat.Value.excludeStr);
                    }
                }
            }
            includes.Sort();
            excludes.Sort();
        }
    }
}

