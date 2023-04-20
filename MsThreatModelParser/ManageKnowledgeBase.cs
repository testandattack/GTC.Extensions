using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace MsThreatModelParser
{
    public class ManageKnowledgeBase
    {
        public KnowledgeBase knowledgeBase { get; set; }

        public Relationships relationships { get; set; }

        public ThreatModel threatModel { get; set; }


        public void ReadKnowledgeBase(string fileName)
        {
            XmlSerializer ser = new XmlSerializer(typeof(KnowledgeBase));
            using (XmlReader reader = XmlReader.Create(fileName))
            {
                knowledgeBase = (KnowledgeBase)ser.Deserialize(reader);
            }
        }

        public void ReadThereatModel(string fileName)
        {
            XmlSerializer ser = new XmlSerializer(typeof(ThreatModel));
            using (XmlReader reader = XmlReader.Create(fileName))
            {
                threatModel = (ThreatModel)ser.Deserialize(reader);
            }
        }

        public void PopulateExtendedModels()
        {
            relationships = new Relationships(knowledgeBase.ThreatCategories, knowledgeBase.Manifest.name);

            foreach(var genericElement in knowledgeBase.GenericElements)
            {
                relationships.AddGeneric(genericElement);
            }

            foreach(var standardElement in knowledgeBase.StandardElements)
            {
                relationships.AddStandard(standardElement);
            }

            foreach(var threatCategory in knowledgeBase.ThreatCategories)
            {
                relationships.AddThreatCategory(threatCategory);
            }

            foreach(var threatType in knowledgeBase.ThreatTypes)
            {
                relationships.AddThreat(threatType);
            }

            relationships.BuildThreatListsForElements();
            relationships.BuildThreatsWithoutElementRelationships();
            relationships.BuildSummaries();
        }
    }
}
