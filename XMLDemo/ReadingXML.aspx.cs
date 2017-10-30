using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
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
    }
}