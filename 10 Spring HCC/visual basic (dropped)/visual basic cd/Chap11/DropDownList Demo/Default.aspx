<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DropDownList Demo</title>
</head>
<body>
    <form id="form1" runat="server">
 
 <h1>DropDownList Demo</h1>
 
 <h4>Select a Kayak Tour</h4>
 
 
 
 
    <br />
	<asp:DropDownList ID="DropDownList1" runat="server" Height="34px" Width="227px">
		<asp:ListItem>(none)</asp:ListItem>
	</asp:DropDownList>
	<br />
	<br />Date: 	<asp:Label ID="Label1" runat="server"></asp:Label>
 
 
 
 
    </form>
</body>
</html>
