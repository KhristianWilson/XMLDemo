using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

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

        protected void Button2_Click(object sender, EventArgs e)
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

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}