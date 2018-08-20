using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace USeTeamDesktopTool.Functions
{
    class XMLTest1Replace
    {
        public void xmlNodeParse(XmlDocument fileName, string node1Name, string node1replacevalue)
        {
            XmlDocument doc = fileName;
            XmlNamespaceManager namespaces = new XmlNamespaceManager(doc.NameTable);
            namespaces.AddNamespace("dft", "http://www.kewill.com/Customs/edi");

            XmlNodeList elemList = doc.GetElementsByTagName(node1Name);
            for(int i = 0; i < elemList.Count; i++)
            {
                elemList[i].InnerText = node1replacevalue;
            }
        }

        public void xmlNodeParseMBWM(XmlDocument fileName, string node1replacevalue)
        {
            //Create the XmlDocument.
            XmlDocument doc = fileName;
            //doc.Load(xmlDocPath);

            XmlNamespaceManager namespaces = new XmlNamespaceManager(doc.NameTable);
            namespaces.AddNamespace("dft", "http://www.kewill.com/Customs/edi");

            XmlNodeList WorkMgmtNode =
                   doc.SelectNodes("/dft:SHIPMENT/dft:SHIPMENT_MAIN/dft:DASHBOARD_WORK_MGMT", namespaces);

            //XmlNodeList elemList = doc.GetElementsByTagName(node1name);
            foreach (XmlNode node in WorkMgmtNode)
            {
                if (node["MASTER_BILL"] != null) { node["MASTER_BILL"].InnerText = node1replacevalue; }
            }
        }

        //TODO: ADD CUST NO LOGIC TO ACCOUNT FOR SUPPLIER PARTY 'CUST_NO' FIELD. 
        //      PERHAPS STORE THE FLEX FIELD BEFORE THE SET AND REPLACE IT AFTERWARDS FOR THE SU PARTY?

        public void xmlNodeParseEntryNo(XmlDocument fileName)
        {
            //Create the XmlDocument.
            XmlDocument doc = fileName;
            //doc.Load(xmlDocPath);

            XmlNamespaceManager namespaces = new XmlNamespaceManager(doc.NameTable);
            namespaces.AddNamespace("dft", "http://www.kewill.com/Customs/edi");

            XmlNodeList EntryNo = doc.SelectNodes("/dft:SHIPMENT//dft:ENTRY_NO", namespaces);

            //XmlNodeList elemList = doc.GetElementsByTagName(node1name);
            foreach (XmlNode node in EntryNo)
            {
                node.ParentNode.RemoveChild(node);
            }
        }

        public void xmlNodeParseCommInv(XmlDocument fileName, string original, string newValue)
        {
            XmlDocument doc = fileName;
            XmlNamespaceManager namespaces = new XmlNamespaceManager(doc.NameTable);
            namespaces.AddNamespace("dft", "http://www.kewill.com/Customs/edi");

            XmlNodeList commInv = doc.SelectNodes("/dft:SHIPMENT//dft:COMM_INV_NO", namespaces);

            foreach (XmlNode node in commInv)
            {
                if (node.InnerText == original)
                {
                    node.InnerText = newValue;
                }
            }
        }
    }
}
