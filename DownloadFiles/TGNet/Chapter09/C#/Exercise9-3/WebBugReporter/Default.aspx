<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <h1>Bug Reports Web Site</h1>
  <asp:Button ID="btnReportBug" runat="server" 
  Text="Report a Bug" Width="226px" OnClick="btnReportBug_Click" />
 <p />
   <asp:Button ID="btnViewBugs" runat="server" 
   Text="View Reported Bugs" Width="226px" OnClick="btnViewBugs_Click" />

    </div>
    </form>
</body>
</html>
