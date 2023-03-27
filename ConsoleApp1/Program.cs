using MsThreatModelParser;
using System;

namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {
            ManageKnowledgeBase mkb = new ManageKnowledgeBase();

            mkb.Read("SampleTemplate.xml");
            mkb.PopulateExtendedModels();
            mkb.relationships.BuildThreatListsForElements();
            mkb.relationships.SaveRelationships($"c:\\temp\\{mkb.knowledgeBase.Manifest.name}-Relationship.json");
            mkb.relationships.SaveAllIncludesAndExcludes($"c:\\temp\\{mkb.knowledgeBase.Manifest.name}-IncAndExc.json");
        }

    }
}
