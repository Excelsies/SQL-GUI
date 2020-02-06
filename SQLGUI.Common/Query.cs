using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace SQLGUI.Common
{
    public class Query
    {
        public string queryName { get; set; }
        public string queryText { get; set; }
        public List<string> paramList { get; set; }
        public List<string> sqlServers { get; set; }
        public string database { get; set; }

        public override string ToString()
        {
            return this.queryName;
        }

        public XDocument SaveNewQuery(XDocument sqlXML, string name, string queryText, List<string> servers, List<string> parameters, string db)
        {
            XElement queryElement = new XElement("Query",
            new XElement("Name", name),
            new XElement("QueryText", queryText)
            );

            foreach (string parameter in parameters)
            {
                queryElement.Add(new XElement("QueryParameter", parameter));
            }

            foreach (string server in servers)
            {
                queryElement.Add(new XElement("sqlServer", server));
            }

            if (db != null)
                queryElement.Add(new XElement("database", db));

            sqlXML.Element("SQLGUI").Element("Queries").Add(
            queryElement
            );

            return sqlXML;
        }

        public XDocument DeleteFromXML(XDocument sqlXML, string query)
        {

            sqlXML.Descendants("Query").Where(x => (string)x.Element("Name") == query).Remove();

            return sqlXML;

        }

        public static List<Query> LoadAllFromXML(string PathToXML)
        {
            List<Query> queries = new List<Query>();

            List<XElement> elements = new List<XElement>();

            using (XmlReader reader = XmlReader.Create(PathToXML))
            {
                reader.MoveToContent();
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "Query")
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
                Query s = new Query();
                s.queryName = v.Element("Name").Value;
                s.queryText = v.Element("QueryText").Value;
                try
                {

                    s.paramList = v.Descendants("QueryParameter").Select(x => x.Value).ToList();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                try
                {

                    s.sqlServers = v.Descendants("sqlServer").Select(x => x.Value).ToList();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                try
                {

                    s.database = v.Element("database").Value;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                queries.Add(s);
            }

            return queries;
        }


    }
}
