<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" SelectCommand="Select CompanyName, Country from Customers where Country = 'USA'" DataFile="~/Northwind.mdb">
        </asp:AccessDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="AccessDataSource1">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
