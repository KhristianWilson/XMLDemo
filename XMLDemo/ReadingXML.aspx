<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadingXML.aspx.cs" Inherits="XMLDemo.ReadingXML" ValidateRequest="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 181px;
            width: 562px;
        }
        #txtDisplay {
            height: 216px;
            width: 618px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnXPath" runat="server" Text="XPath Single Node" OnClick="BtnXPath_Click" />
            <asp:Button ID="BtnXPathSearch" runat="server" Text="XPath Recursion Seach" OnClick="Button2_Click"/>
            <asp:Button ID="BtnXPathDocument" runat="server" Text="Button" OnClick="Button3_Click"/>
            <br />
            <br />
            <br />
            <br />
            <textarea id="txtDisplay" runat="server" cols="30" rows="50"></textarea>       
        </div>
    </form>
</body>
</html>
