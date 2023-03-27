using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Serilog;
using System.Linq;
using System.Xml.Linq;
using GTC.Extensions;

namespace GTC.XmlExtensions
{
    public static class XmlElementExtensions
    {
        public static string IgnoreableElement = "xsRF4567gz2";

        /// <summary>
        /// Reads an XML file and loads the document into an XElement object
        /// </summary>
        /// <param name="fileName">The full name of the file containing the XML to read.</param>
        /// <returns></returns>
        public static XElement LoadXmlFileIntoElement(string fileName)
        {
            try
            {
                return XElement.Load(fileName);

            }
            catch (XmlException ex)
            {
                Log.ForContext("Source Context", "XmlExtensions").Error(ex, "Method:{name}", "LoadXmlFile");
            }
            return null;
        }

        #region -- Get Element Items -----
        public static List<XElement> GetElementsWithNameContaining(this XElement source, string nameContains)
        {
            return GetElementsWithNameContaining(source, nameContains, IgnoreableElement);
        }

        public static List<XElement> GetElementsWithNameContaining(this XElement source, string nameContains, string elementToIgnore)
        {
            var nodeList2 = source.Elements()
                .DescendantsAndSelf()
                .Where(item => item.Name.ToString().Contains(nameContains)
                    && item.Name.ToString().Contains(elementToIgnore) == false)
                .ToList();
            return nodeList2;
        }

        public static List<XElement> GetElementsWithName(this XElement source, string elementName)
        {
            return GetElementsWithName(source, elementName, IgnoreableElement);
        }

        public static List<XElement> GetElementsWithName(this XElement source, string elementName, string elementToIgnore)
        {
            var nodeList2 = source.Elements()
                .DescendantsAndSelf()
                .Where(item => item.Name == elementName
                    && item.Name != elementToIgnore)
                .ToList();
            return nodeList2;
        }

        public static List<XElement> GetElementsWithSubNodeContainingAttributeValue(this XElement source, string attributeValue)
        {
            return GetElementsWithSubNodeContainingAttributeValue(source, attributeValue, IgnoreableElement);
        }

        public static List<XElement> GetElementsWithSubNodeContainingAttributeValue(this XElement source, string attributeValue, string elementToIgnore)
        {
            var nodeList = source.Elements()
                .DescendantsAndSelf()
                .Where(item => item.Attributes()
                    .FirstOrDefault(attrib => attrib.Value == attributeValue) != null
                    && item.Name != elementToIgnore)
                .ToList();
            
            var parentList = new List<XElement>();
            foreach(XElement node in nodeList)
            {
                parentList.Add(node.Parent);
            }

            return parentList;
        }
        #endregion

        #region -- Get Attribute Items -----
        public static List<string> GetAttributeValueForElements(this XElement source, string elementName, string attributeName)
        {
            // Pass in a random name that would never be found since this call assumes we are not ignoring any elements
            return GetAttributeValueForElements(source, elementName, attributeName, false, IgnoreableElement);
        }

        public static List<string> GetAttributeValueForElements(this XElement source, string elementName, string attributeName, bool addNodeAncestry)
        {
            // Pass in a random name that would never be found since this call assumes we are not ignoring any elements
            return GetAttributeValueForElements(source, elementName, attributeName, addNodeAncestry, IgnoreableElement);
        }

        public static List<string> GetAttributeValueForElements(this XElement source, string elementName, string attributeName, string elementToIgnore)
        {
            return GetAttributeValueForElements(source, elementName, attributeName, false, elementToIgnore);
        }

        public static List<string> GetAttributeValueForElements(this XElement source, string elementName, string attributeName, bool addNodeAncestry, string elementToIgnore)
        {
            var nodeList = source.Elements()
                .DescendantsAndSelf()
                .Where(item => item.Name.ToString() == elementName
                    && item.Name != elementToIgnore)
                .ToList();

            List<string> attributeValues = new List<string>();

            foreach(var node in nodeList)
            {
                string ancestry = addNodeAncestry ? $"\t\tAncestry:{node.BuildAncestry()}" : "";
                attributeValues.Add($"{node.Attribute(attributeName).Value}{ancestry}");
            }
            return attributeValues;
        }

        public static string GetAttributeValueForElement(this XElement source, string attributeName, string defaultValue)
        {
            var sName = source.Attributes().Where(a => a.Name == attributeName).FirstOrDefault();
            if(sName != null)
            {
                return sName.Value;
            }
            else
            {
                return defaultValue;
            }
        }

        public static string GetAttributeValueForSubNode(this XElement source, string subNodeName, string attributeName)
        {
            return GetAttributeValueForSubNode(source, subNodeName, attributeName, IgnoreableElement);
        }

        public static string GetAttributeValueForSubNode(this XElement source, string subNodeName, string attributeName, string elementToIgnore)
        {
            var subNodes = source.Elements()
                .DescendantsAndSelf()
                .Where(item => item.Name.LocalName == subNodeName
                    && item.Name.ToString().Contains(elementToIgnore) == false);
            if (subNodes == null || subNodes.Count() == 0)
                return null;

            var subNode = subNodes.First();

            string str = subNode.Attribute(attributeName).Value;
            return str;
        }

        public static string GetAttributeValueForSubNodeWithNodeContaining(this XElement source, string subNodeName, string attributeName)
        {
            return GetAttributeValueForSubNodeWithNameContaining(source, subNodeName, attributeName, IgnoreableElement);
        }

        // source.Elements().DescendantsAndSelf().Where(item => item.Name.LocalName == subNodeName)

        public static string GetAttributeValueForSubNodeWithNameContaining(this XElement source, string subNodeName, string attributeName, string elementToIgnore)
        {
            var subNodes = source.Elements()
                .DescendantsAndSelf()
                .Where(item => item.Name.ToString().Contains(subNodeName)
                    && item.Name.ToString().Contains(elementToIgnore) == false);
            if (subNodes == null || subNodes.Count() == 0)
                return null;

            var subNode = subNodes.First();
            if (subNode.HasAttributes && subNode.Attribute(attributeName) != null)
            {
                string str = subNode.Attribute(attributeName).Value;
                return str;
            }
            return null;
        }

        public static List<string> GetAttributeValueForSubNodesWithNameContaining(this XElement source, string subNodeName, string attributeName)
        {
            return GetAttributeValueForSubNodesWithNameContaining(source, subNodeName, attributeName, false, IgnoreableElement);
        }

        public static List<string> GetAttributeValueForSubNodesWithNameContaining(this XElement source, string subNodeName, string attributeName, bool addAncestry)
        {
            return GetAttributeValueForSubNodesWithNameContaining(source, subNodeName, attributeName, addAncestry, IgnoreableElement);
        }

        public static List<string> GetAttributeValueForSubNodesWithNameContaining(this XElement source, string subNodeName, string attributeName, bool addAncestry, string elementToIgnore)
        {
            var subNodes = source.Elements()
                .DescendantsAndSelf()
                .Where(item => item.Name.ToString().Contains(subNodeName)
                    && item.Name.ToString().Contains(elementToIgnore) == false);
            if (subNodes == null || subNodes.Count() == 0)
                return null;

            List<string> versions = new List<string>();

            foreach (var subNode in subNodes)
            {
                if (addAncestry)
                    versions.Add($"{subNode.Attribute(attributeName).Value}     {subNode.BuildAncestry()}");
                else
                    versions.Add(subNode.Attribute(attributeName).Value);
            }
            return versions;
        }
        #endregion

        #region -- Ancestry -----
        public static string BuildAncestry(this XElement currentNode)
        {
            string currentTree = $"{currentNode.GetNodeName()}";

            // Are we at the root?
            if (currentNode.Parent == null)
            {
                return currentTree;
            }
            else
            {
                return BuildAncestry(currentTree, currentNode.Parent);
            }
        }

        private static string BuildAncestry(string currentTree, XElement currentNode)
        {
            string newTree = $"{currentNode.GetNodeName()}->{currentTree}";

            // Are we at the root?
            if (currentNode.Parent == null)
            {
                return currentTree;
            }
            else
            {
                return BuildAncestry(newTree, currentNode.Parent);
            }
        }

        public static string GetRootItem(this XElement currentNode)
        {
            return GetRootItemFromAncestry(currentNode.BuildAncestry());
        }

        public static string GetRootItemFromAncestry(this string source)
        {
            if (source.StartsWith("References->"))
                return source.FindSubString("References->", "->");
            else
                return "Main Policy";
        }
        #endregion

        #region -- Other Methods -----
        public static bool ContainsSubNode(this XElement source, string subNodeName)
        {
            var subNodes = source.GetElementsWithNameContaining(subNodeName);
            if (subNodes != null && subNodes.Count > 0)
                return true;
            return false;
        }

        public static string GetNodeName(this XElement source)
        {
            return source.GetAttributeValueForElement("name", source.Name.LocalName); 
        }
        #endregion
    }
}
