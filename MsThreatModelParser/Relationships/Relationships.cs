using System;
using System.Collections.Generic;
using System.Text;
using GTC.Extensions;
using Newtonsoft.Json;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace MsThreatModelParser
{
    public class Relationships
    {
        #region -- Properties -----
        public string TemplateName { get; set; }

        public Summaries summaries { get; private set; }

        public List<string> allElementIds { get; set; }

        public List<string> elementsWithoutThreats { get; set; }
        
        public List<string> elementsWithThreats { get; set; }

        public List<string> threatsWithoutElementRelationships { get; set; }
        
        public List<string> threatsWithElementRelationships { get; set; }

        public List<string> elementsWithGuidId { get; set; }

        public List<string> threatIds { get; set; }

        [JsonIgnore]
        public Dictionary<string, int> allIncludeThreatFilterValues { get; set; }

        [JsonIgnore]
        public Dictionary<string, int> allExcludeThreatFilterValues { get; set; }

        public List<KeyValuePair<string, int>> sorted_allIncludeThreatFilterValues { get; set; }

        public List<KeyValuePair<string, int>> sorted_allExcludeThreatFilterValues { get; set; }

        public Dictionary<string, ThreatCategoryEx> threatCategories { get; set; }

        public Dictionary<string, GenericElementEx> genericList { get; set; }
        #endregion

        #region -- Constructors -----
        public Relationships()
        {
            TemplateName = string.Empty;
            genericList = new Dictionary<string, GenericElementEx>();
            threatCategories = new Dictionary<string, ThreatCategoryEx>();
            allElementIds = new List<string>();
            elementsWithoutThreats = new List<string>();
            elementsWithThreats = new List<string>();
            threatsWithoutElementRelationships = new List<string>();
            threatsWithElementRelationships = new List<string>();
            elementsWithGuidId = new List<string>();
            threatIds = new List<string>();
            allIncludeThreatFilterValues = new Dictionary<string, int>();
            allExcludeThreatFilterValues = new Dictionary<string, int>();
            summaries = new Summaries();
        }

        public Relationships(KnowledgeBaseThreatCategory[] categories, string template)
        {
            TemplateName = template;
            genericList = new Dictionary<string, GenericElementEx>();
            threatCategories = new Dictionary<string, ThreatCategoryEx>();
            allElementIds = new List<string>();
            elementsWithoutThreats = new List<string>();
            elementsWithThreats = new List<string>();
            threatsWithoutElementRelationships = new List<string>();
            threatsWithElementRelationships = new List<string>();
            elementsWithGuidId = new List<string>();
            threatIds = new List<string>();
            allIncludeThreatFilterValues = new Dictionary<string, int>();
            allExcludeThreatFilterValues = new Dictionary<string, int>();
            summaries = new Summaries();
        }
        #endregion

        #region -- methods -----
        public void AddThreatCategory(KnowledgeBaseThreatCategory kbtc)
        {
            string sName = kbtc.Id;
            ThreatCategoryEx tcex = new ThreatCategoryEx(kbtc);
            threatCategories.Add(sName, tcex);
        }

        public void AddThreat(KnowledgeBaseThreatType kbtt)
        {
            string sCategory = kbtt.Category;
            threatIds.Add(kbtt.Id);

            if (threatCategories.ContainsKey(sCategory) == false)
            {
                Console.WriteLine($"Error in AddThreat - Could not find category {sCategory}");
            }
            else
            {
                ThreatTypeEx ttex = new ThreatTypeEx(kbtt);
                threatCategories[sCategory].AddThreatType(ttex);
                summaries.threatCount++;
                foreach(var includeFilter in ttex.includes)
                    allIncludeThreatFilterValues.AddOrUpdateCount(includeFilter);
                foreach (var excludeFilter in ttex.excludes)
                    allExcludeThreatFilterValues.AddOrUpdateCount(excludeFilter);
            }

        }

        public void AddGeneric(KnowledgeBaseElementType kbet)
        {
            string sName = kbet.ID;
            GenericElementEx geex = new GenericElementEx(kbet);
            genericList.Add(sName, geex);
            summaries.genericElementCount++;
            allElementIds.Add(sName);
            if (Guid.TryParse(sName, out Guid sTemp) == true)
                elementsWithGuidId.Add($"GENERIC: {sName}: {geex.Name}");

        }

        public void AddStandard(KnowledgeBaseElementType2 kbet2)
        {
            string parentName = kbet2.ParentElement;
            if(genericList.ContainsKey(parentName) == false)
            {
                Console.WriteLine($"Error in AddStandard - Could not find parent {parentName}");
            }
            else
            {
                StandardElementEx seex = new StandardElementEx(kbet2);
                genericList[parentName].AddStandardElement(seex);
                summaries.standardElementCount++;
                allElementIds.Add(seex.ID);
                if (Guid.TryParse(seex.ID, out Guid sTemp) == true)
                    elementsWithGuidId.Add($"STANDARD: {parentName} - {seex.ID}: {seex.Name}");
            }
        }

        public void BuildThreatListsForElements()
        {
            foreach(var item in genericList)
            {
                // first handle the generic level
                foreach (var category in threatCategories.Values)
                {
                    foreach(var threat in category.threatTypes)
                    {
                        if(threat.Value.includes.Contains(item.Key))
                        {
                            item.Value.threatTypesTiedToThisElement.Add(threat.Key);
                        }
                    }
                }
                if (item.Value.threatTypesTiedToThisElement.Count == 0)
                    elementsWithoutThreats.Add($"GENERIC: {item.Key}");
                else
                    elementsWithThreats.Add($"GENERIC: {item.Key}");


                // now handle all the standard entries inside the generic level
                foreach (var element in item.Value.StandardElements)
                {
                    foreach (var category in threatCategories.Values)
                    {
                        foreach (var threat in category.threatTypes)
                        {
                            if (threat.Value.includes.Contains(element.Key))
                            {
                                element.Value.threatTypesTiedToThisElement.Add(threat.Key);
                            }
                        }
                    }
                    if (element.Value.threatTypesTiedToThisElement.Count == 0)
                        elementsWithoutThreats.Add($"STANDARD: {item.Key} - {element.Key}");
                    else
                        elementsWithThreats.Add($"STANDARD: {item.Key} - {element.Key}");

                }
            }
        }

        public void BuildThreatsWithoutElementRelationships()
        {
            foreach(var category in threatCategories.Values)
            {
                foreach(var threat in category.threatTypes.Values)
                {
                    bool elementWasFound = false;
                    foreach(string inc in threat.includes)
                    {
                        if (allElementIds.Contains(inc))
                            elementWasFound = true;
                    }
                    if (elementWasFound == false)
                        threatsWithoutElementRelationships.Add(threat.Name);
                    else
                        threatsWithElementRelationships.Add(threat.Name);

                }
            }
        }

        public void SaveRelationships(string filename)
        {
            allElementIds.Sort();
            elementsWithoutThreats.Sort();
            elementsWithThreats.Sort();
            threatsWithoutElementRelationships.Sort();
            threatsWithElementRelationships.Sort();
            threatIds.Sort();
            BuildSortedDictionaries();

            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                sw.Write(JsonConvert.SerializeObject(this, Formatting.Indented));
            }
        }

        public void SaveAllIncludesAndExcludes(string filename)
        {
            IncAndExc i_and_e = new IncAndExc(this.threatCategories);
            
            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                sw.Write(JsonConvert.SerializeObject(i_and_e, Formatting.Indented));
            }
        }

        public void BuildSummaries()
        {
            summaries.allElementCount = allElementIds.Count;
            summaries.elementsWithoutThreatsCount = elementsWithoutThreats.Count;
            summaries.elementsWithThreatsCount = elementsWithThreats.Count;
            summaries.threatsWithoutElementRelationshipsCount = threatsWithoutElementRelationships.Count;
            summaries.threatsWithElementRelationshipsCount = threatsWithElementRelationships.Count;
        }

        private void BuildSortedDictionaries()
        {
            sorted_allIncludeThreatFilterValues = allIncludeThreatFilterValues.AsEnumerable().OrderByDescending(v => v.Value).ToList();
            sorted_allExcludeThreatFilterValues = allExcludeThreatFilterValues.AsEnumerable().OrderByDescending(v => v.Value).ToList();
        }
        #endregion
    }

    public class Summaries
    {
        public int threatCount { get; set; }

        public int genericElementCount { get; set; }

        public int standardElementCount { get; set; }

        public int allElementCount { get; set; }

        public int elementsWithoutThreatsCount { get; set; }

        public int elementsWithThreatsCount { get; set; }

        public int threatsWithoutElementRelationshipsCount { get; set; }

        public int threatsWithElementRelationshipsCount { get; set; }

        public Summaries()
        {
            genericElementCount = 0;
            standardElementCount = 0;
            allElementCount = 0;
            elementsWithoutThreatsCount = 0;
            elementsWithThreatsCount = 0;
            threatsWithoutElementRelationshipsCount = 0;
            threatsWithElementRelationshipsCount = 0;
        }
    }

    public static class Behaviors
    {
        public static string GetBehavior(string representation)
        {
            /*
            Shape	        Behavior
            =============================
            Ellipse	        Target
            BorderBoundary	Boundary
            Line	        Flow
            LineBoundary	Boundary
            Rectangle	    Target
            Annotation	    Free Text Annotation
            ParallelLines	Target
            */
            switch (representation)
            {
                case "Ellipse":
                    return "Target";
                case "BorderBoundary":
                    return "Boundary";
                case "Line":
                    return "Flow";
                case "LineBoundary":
                    return "Boundary";
                case "Rectangle":
                    return "Target";
                case "ParallelLines":
                    return "Target";
                case "Annotation":
                    return "Annotation";
                default:
                    return string.Empty;
            }
        }
    }
}
