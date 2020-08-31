<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Event Demo</title>
</head>
<body>
    <form id="form1" runat="server">

    <h1>Events</h1>
    Enter your name:&nbsp;
	
	<asp:TextBox ID="txtName" runat="server" Width="255px"></asp:TextBox>
    &nbsp;<asp:Button ID="btnOk" runat="server" Text="OK" /><br />
		<br />
		<br />
    
    <asp:ListBox ID="lstEvents" runat="server" Height="112px" Width="325px"></asp:ListBox>
    
    </form>
</body>
</html>
