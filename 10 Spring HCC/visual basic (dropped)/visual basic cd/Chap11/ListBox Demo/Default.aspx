<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ListBox Demo</title>
</head>
<body>
    <form id="form1" runat="server">
 
    <h1>ListBox Demo</h1>
    
    Kayak Store Sales Staff
    
    <br />
	<br />
	<br />
    
    <asp:ListBox ID="lstSalesStaff" runat="server">
		<asp:ListItem>Adam</asp:ListItem>
		<asp:ListItem>Brenda</asp:ListItem>
		<asp:ListItem>Dave</asp:ListItem>
		<asp:ListItem>Frank</asp:ListItem>
    
    
    
    </asp:ListBox>
 
 
 
    <br />
	<br />
	<asp:Button ID="Button1" runat="server" Text="OK" />
	<br />
	<br />Selected Index: 	<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
 
 
 
    </form>
</body>
</html>
