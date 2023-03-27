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
    public static class XmlDocumentExtensions
    {
        public static XmlDocument LoadXmlFile(string fileName)
        {
            XmlDocument xmlDocument = new XmlDocument();
            try
            {
                xmlDocument.Load(fileName);
            }
            catch (XmlException ex)
            {
                Log.ForContext("Source Context", "XmlExtensions").Error(ex, "Method:{name}", "LoadXmlFile");
            }
            return xmlDocument;
        }

        public static XmlNodeList GetNodeList(this XmlDocument source, string nodeName)
        {
            return source.GetElementsByTagName(nodeName);
        }

        public static XmlNode GetSpecificNode(this XmlDocument source, string xPath)
        {
            return source.SelectSingleNode(xPath);
        }
    }
}
