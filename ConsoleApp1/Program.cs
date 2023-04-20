using MsThreatModelParser;
using System;

namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {
            ManageKnowledgeBase mkb = new ManageKnowledgeBase();

            mkb.ReadKnowledgeBase("SampleTemplate.xml");
            mkb.PopulateExtendedModels();
            mkb.relationships.SaveRelationships($"c:\\temp\\{mkb.knowledgeBase.Manifest.name}-Relationship.json");
            mkb.relationships.SaveAllIncludesAndExcludes($"c:\\temp\\{mkb.knowledgeBase.Manifest.name}-IncAndExc.json");

            mkb.ReadThereatModel("SampleModel.xml");
            Console.WriteLine("");
        }

    }
}
