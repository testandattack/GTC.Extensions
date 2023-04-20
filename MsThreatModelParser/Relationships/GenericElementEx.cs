using System;
using System.Collections.Generic;
using System.Text;
using GTC.Extensions;
using Newtonsoft.Json;
using System.Linq;
using System.IO;

namespace MsThreatModelParser
{
    public class GenericElementEx
    {
        [JsonIgnore]
        public KnowledgeBaseElementType GenericElement { get; set; }
        
        public string ID { get; set; }

        public string Name { get; set; }

        public string Behavior { get; set; }

        public Dictionary<string, StandardElementEx> StandardElements { get; set; }

        public List<string> threatTypesTiedToThisElement { get; set; }

        public GenericElementEx()
        {
            GenericElement = new KnowledgeBaseElementType();
            ID = string.Empty;
            Name = string.Empty;
            Behavior = string.Empty;
            StandardElements = new Dictionary<string, StandardElementEx>();
            threatTypesTiedToThisElement = new List<string>();
        }

        public GenericElementEx(KnowledgeBaseElementType kbet)
        {
            GenericElement = kbet;
            ID = kbet.ID;
            Name = kbet.Name;
            Behavior = Behaviors.GetBehavior(kbet.Representation);
            StandardElements = new Dictionary<string, StandardElementEx>();
            threatTypesTiedToThisElement = new List<string>();
        }

        public void AddStandardElement(StandardElementEx elementEx)
        {
            if(StandardElements.ContainsKey(elementEx.ID) == true)
            {
                Console.WriteLine($"Found duplicate entry in StandardElements: {ID}, {elementEx.ID}");
                return;
            }
            StandardElements.Add(elementEx.ID, elementEx);
        }
    }
}
