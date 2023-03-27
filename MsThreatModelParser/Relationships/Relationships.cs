using System;
using System.Collections.Generic;
using System.Text;
using GTC.Extensions;
using Newtonsoft.Json;
using System.Linq;
using System.IO;

namespace MsThreatModelParser
{
    public class Relationships
    {
        public string TemplateName { get; set; }

        public Dictionary<string, ThreatCategoryEx> threatCategories { get; set;}
        
        public Dictionary<string, GenericElementEx> genericList { get; set; }



        public Relationships()
        {
            TemplateName = string.Empty;
            genericList = new Dictionary<string, GenericElementEx>();
            threatCategories = new Dictionary<string, ThreatCategoryEx>();
        }

        public Relationships(KnowledgeBaseThreatCategory[] categories, string template)
        {
            TemplateName = template;
            genericList = new Dictionary<string, GenericElementEx>();
            threatCategories = new Dictionary<string, ThreatCategoryEx>();
        }

        public void AddThreatCategory(KnowledgeBaseThreatCategory kbtc)
        {
            string sName = kbtc.Id;
            ThreatCategoryEx tcex = new ThreatCategoryEx(kbtc);
            threatCategories.Add(sName, tcex);
        }

        public void AddThreat(KnowledgeBaseThreatType kbtt)
        {
            string sCategory = kbtt.Category;
            if (threatCategories.ContainsKey(sCategory) == false)
            {
                Console.WriteLine($"Error in AddThreat - Could not find category {sCategory}");
            }
            else
            {
                ThreatTypeEx ttex = new ThreatTypeEx(kbtt);
                threatCategories[sCategory].AddThreatType(ttex);
            }

        }

        public void AddGeneric(KnowledgeBaseElementType kbet)
        {
            string sName = kbet.ID;
            GenericElementEx geex = new GenericElementEx(kbet);
            genericList.Add(sName, geex);
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
                            var threatItem = new ThreatListItem(
                                threat.Key,
                                threat.Value.includeStr,
                                threat.Value.excludeStr);
                            item.Value.threatTypesTiedToThisElement.Add(threatItem);
                        }
                    }
                }

                // now handle all the standard entries inside the generic level
                foreach(var element in item.Value.StandardElements)
                {
                    foreach (var category in threatCategories.Values)
                    {
                        foreach (var threat in category.threatTypes)
                        {
                            if (threat.Value.includes.Contains(element.Key))
                            {
                                var threatItem = new ThreatListItem(
                                    threat.Key,
                                    threat.Value.includeStr,
                                    threat.Value.excludeStr);
                                element.Value.threatTypesTiedToThisElement.Add(threatItem);
                            }
                        }
                    }
                }
            }
        }

        public void SaveRelationships(string filename)
        {
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
    }

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

            //List<string> tmpInc = new List<String>();
            //List<string> tmpExc = new List<String>();

            foreach(var category in threatCategories.Values)
            {
                foreach(var threat in category.threatTypes)
                {
                    if (String.IsNullOrEmpty(threat.Value.includeStr) == false
                        && threat.Value.includeStr != " ")
                        includes.Add(threat.Value.includeStr);
                    if (String.IsNullOrEmpty(threat.Value.excludeStr) == false
                        && threat.Value.excludeStr != " ")
                        excludes.Add(threat.Value.excludeStr);
                }
            }
            includes.Sort();
            excludes.Sort();
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
