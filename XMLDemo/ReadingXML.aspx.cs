using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace XMLDemo
{
    public partial class ReadingXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnXPath_Click(object sender, EventArgs e)
        {
            txtDisplay.InnerText = "";
            XmlDocument document = new XmlDocument();
            document.Load(Server.MapPath(("~/Menu.xml")));
            XmlNode food = document.SelectSingleNode("breakfast_menu/food[name = 'Belgian Waffles']");
            txtDisplay.InnerText = food.InnerXml;
        }

        protected void BtnXPathSearch_Click(object sender, EventArgs e)
        {
            txtDisplay.InnerText = "";
            XmlDocument document = new XmlDocument();
            document.Load(Server.MapPath(("~/Menu.xml")));
            XmlNodeList foods = document.SelectNodes("//name");
            foreach (XmlNode food in foods)
            {
                txtDisplay.InnerText += food.InnerXml + Environment.NewLine;
            }
        }

        protected void BtnXPathDocument_Click(object sender, EventArgs e)
        {
            txtDisplay.InnerText = "";
            XPathDocument xPathDocument = new XPathDocument(Server.MapPath(("~/Menu.xml")));
            XPathNavigator navigator = xPathDocument.CreateNavigator();

            XPathNodeIterator iterator = navigator.SelectChildren(XPathNodeType.
            Element);

            while (iterator.MoveNext())
            {
                txtDisplay.InnerText += (iterator.Current.Value) + Environment.NewLine;
            }
        }

        protected void BtnXReader_Click(object sender, EventArgs e)
        {
            txtDisplay.InnerText = "";
            StreamReader xmlStream = new StreamReader(Server.MapPath(("~/Menu.xml")));
            using (XmlReader reader = XmlReader.Create(xmlStream))
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            txtDisplay.InnerText += (reader.Name + Environment.NewLine);
                            break;
                        case XmlNodeType.Text:
                            txtDisplay.InnerText += (reader.Value + Environment.NewLine);
                            break;
                        case XmlNodeType.EndElement:
                            txtDisplay.InnerText += (reader.Name + Environment.NewLine);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        protected void BtnLINQ_Click(object sender, EventArgs e)
        {
            txtDisplay.InnerText = "";
            XDocument doc = new XDocument();
            doc = XDocument.Load(Server.MapPath(("~/Menu.xml")));
            IEnumerable<XElement> foodcost = doc.Descendants().Where(x => x.Name ==
            "price");
            foreach (XElement cost in foodcost)
            {
                txtDisplay.InnerText += (cost.Value + Environment.NewLine);
            }
        }

        protected void btnLINQ2_Click(object sender, EventArgs e)
        {
            txtDisplay.InnerText = "";
            XDocument doc = new XDocument();
            doc = XDocument.Load(Server.MapPath(("~/Menu.xml")));
            List<XElement> food = doc.Descendants()
            .Where(x => x.Name == "calories" && (int.Parse(x.Value) >= 650 && int.
            Parse(x.Value) <= 900))
            .Select(x => x.Parent).ToList();

            foreach (XElement cost in food)
            {
                txtDisplay.InnerText += (cost.Value + Environment.NewLine);
            }

        }
    }
}