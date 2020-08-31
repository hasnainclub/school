<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BorderStyle Samples</title>
</head>
<body>
    <form id="form1" runat="server">

<br />

<asp:Button ID="Button1" runat="server" 
    BorderColor="Black" 
    BorderStyle="Solid" 
    BorderWidth="1px" 
    Text="BorderStyle = Solid, BorderWidth = 1" Width="337px" />

<p />

<asp:Button ID="Button2" runat="server" 
    BorderColor="Black" 
    BorderStyle="Dotted" 
    BorderWidth="3px" 
    Text="BorderStyle = Dotted, BorderWidth = 3" Width="339px" />

<p />

<asp:Button ID="Button3" runat="server" 
    BorderColor="Black" 
    BorderStyle="Groove" 
    BorderWidth="5px" 
    Text="BorderStyle = Groove, BorderWidth = 5" Width="340px" />

<p />

<asp:Button ID="Button4" runat="server" 
    BorderColor="Black" 
    BorderStyle="Outset" 
    BorderWidth="8px" 
    Text="BorderStyle = Outset, BorderWidth = 8" Width="341px" />

<p />

    </form>
</body>
</html>
