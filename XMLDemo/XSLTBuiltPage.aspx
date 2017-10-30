<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XSLTBuiltPage.aspx.cs" Inherits="XMLDemo.XSLTBuiltPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:xml runat="server" DocumentSource="~/MenuXSLT.xml" TransformSource="~/XSLT.xslt"></asp:xml>
        </div>
    </form>
</body>
</html>
