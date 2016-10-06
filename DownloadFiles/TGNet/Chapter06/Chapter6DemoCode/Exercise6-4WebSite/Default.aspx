<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtTester" runat="server"></asp:TextBox>
        <asp:Label ID="lblTester" runat="server" Text="Tester Name"></asp:Label><br />
        <asp:TextBox ID="txtAppName" runat="server"></asp:TextBox>
        <asp:Label ID="lblAppName" runat="server" Text="Application Name"></asp:Label><br />
        <asp:TextBox ID="txtBuildNumber" runat="server"></asp:TextBox>
        <asp:Label ID="lblBuildNumber" runat="server" Text="Build Number"></asp:Label><br />
        <asp:TextBox ID="txtDateReported" runat="server"></asp:TextBox>
        <asp:Label ID="lblDateReported" runat="server" Text="Date Reported"></asp:Label><br />
        <asp:Label ID="lblDescription" runat="server" Text="Description of Bug"></asp:Label><br />
        <asp:TextBox ID="txtDescription" runat="server" Height="214px" Width="491px"></asp:TextBox>&nbsp;
        <br />
        <asp:Label ID="lblFileName" runat="server" Text="FileName"></asp:Label>
        <asp:TextBox ID="txtFileName" runat="server">C:\BugReport.csv</asp:TextBox>&nbsp;
        <asp:Button ID="btnSubmitBug" runat="server" Text="Submit Bug" Width="154px" />
        <br />
        <br />
        <asp:Label ID="lblStatus" runat="server" Text="Status:" Width="492px"></asp:Label></div>
    </form>
</body>
</html>
