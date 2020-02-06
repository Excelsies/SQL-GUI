using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace SQLGUI.Common
{
    public class SQLServer
    {
        public string ServerName { get; set; }
        public bool WindowsAuthentication { get; set; }
        public List<string> ServerCredentials { get; set; }

        public override string ToString()
        {

            return this.ServerName;
        }

        public XDocument SaveAdjustedServer(XDocument sqlXML, string name, string WindowsAuthentication, string server, string username, string password)
        {
            sqlXML.Descendants("Server").Where(x => (string)x.Element("name") == server).Single().Element("ServerCredentials").Value = password;
            sqlXML.Descendants("Server").Where(x => (string)x.Element("name") == server).Single().Element("ServerCredentials").Value = username;
            sqlXML.Descendants("Server").Where(x => (string)x.Element("name") == server).Single().Element("WindowsAuthentication").Value = WindowsAuthentication;
            sqlXML.Descendants("Server").Where(x => (string)x.Element("name") == server).Single().Element("name").Value = name;

            return sqlXML;
        }

        public XDocument SaveNewServer(XDocument sqlXML, string name, string WindowsAuthentication, string username, string password)
        {
            sqlXML.Element("SQLGUI").Element("Servers").Add(
            new XElement("Server",
            new XElement("name", name),
            new XElement("WindowsAuthentication", WindowsAuthentication),
            new XElement("ServerCredentials", username),
            new XElement("ServerCredentials", password)
            ));


            return sqlXML;
        }

        public XDocument DeleteFromXML(XDocument sqlXML, string server)
        {

            sqlXML.Descendants("Server").Where(x => (string)x.Element("name") == server).Remove();

            return sqlXML;

        }


        public static List<SQLServer> LoadAllFromXML(string PathToXML)
        {
            List<SQLServer> servers = new List<SQLServer>();

            List<XElement> elements = new List<XElement>();

            using (XmlReader reader = XmlReader.Create(PathToXML))
            {
                reader.MoveToContent();
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "Server")
                        {
                            XElement el = XNode.ReadFrom(reader) as XElement;
                            if (el != null)
                            {
                                elements.Add(el);
                            }
                        }
                    }
                }
            }
            foreach (XElement v in elements)

            {
                SQLServer s = new SQLServer();
                s.ServerName = v.Element("name").Value;
                try
                {
                    if (v.Element("WindowsAuthentication").Value == "true" || v.Element("WindowsAuthentication").Value == "True")
                    {
                        s.WindowsAuthentication = true;
                        s.ServerCredentials = new List<string>() { null, null };
                    }
                    else
                    {
                        s.WindowsAuthentication = false;
                        s.ServerCredentials = v.Descendants("ServerCredentials").Select(x => x.Value).ToList();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                servers.Add(s);
            }


            return servers;
        }
    }
}
