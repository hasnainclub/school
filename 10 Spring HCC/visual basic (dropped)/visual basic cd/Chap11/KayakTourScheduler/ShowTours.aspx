<%@ Page Language="vb" AutoEventWireup="false" Inherits="Calendar.ShowTours" CodeFile="ShowTours.aspx.vb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Reserved Tour Dates</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<H2>View the Reserved Tour Dates</H2>
			<P>
				<asp:Calendar id="calTours" runat="server" Width="336px" Height="248px" Font-Bold="True" Font-Names="Arial"
					TitleFormat="Month" SelectionMode="None" BorderStyle="Outset"></asp:Calendar></P>
		</form>
	</body>
</HTML>
