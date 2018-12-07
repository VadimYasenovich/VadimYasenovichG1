using System.IO;
using System.Reflection;
using System.Xml;

namespace UkrNetTests.Utils
{
    public static class XmlHelpers
    {
        public static XmlDocument CreateXml(string filePath)
        {
            var pathToFileDir = Assembly.GetExecutingAssembly()
                .CodeBase.Replace("file:///", string.Empty);

            var pathToFile = Path.Combine(Path.GetDirectoryName(pathToFileDir), filePath);
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(pathToFile);
            return xmlDoc;

        }
        public static XmlNode GetNodeByTagName(string nodeTagName, string filePath)
        {
            var xmlDoc = CreateXml(filePath);
            var nodeXpath = "//" + nodeTagName;
            var node = xmlDoc.SelectSingleNode(nodeXpath);
            return node;
        }

        public static XmlNode GetNodeByTagName(string nodeTagName, XmlDocument xmlFile)
        {
            var nodeXpath = "//" + nodeTagName;
            var node = xmlFile.SelectSingleNode(nodeXpath);
            return node;
        }

        public static string GetNodeText(string nodeTagName, string filePath = "Data/XMLFile1.xml")
        {
            XmlNode node = GetNodeByTagName(nodeTagName, filePath);
            return node.InnerText;
        }
    }
}
