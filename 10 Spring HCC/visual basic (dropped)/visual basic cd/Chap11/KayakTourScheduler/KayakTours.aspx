<%@ Page Language="vb" AutoEventWireup="false" Inherits="Calendar.KayakTour" CodeFile="KayakTours.aspx.vb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
<HEAD>
<title>Kayak Tour Scheduler</title>
<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
<meta content="JavaScript" name="vs_defaultClientScript">
<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
</HEAD>
<body>
<form id="Form1" method="post" runat="server">
<H1>Kayak Tour Scheduler</H1>
<H4>
<TABLE id="Table1" style="WIDTH: 712px; HEIGHT: 288px" cellSpacing="1" cellPadding="1"
					width="712" border="0">
<TR>
<TD style="WIDTH: 285px; HEIGHT: 16px"></TD>
<TD style="WIDTH: 30px; HEIGHT: 16px"></TD>
<TD style="HEIGHT: 16px"></TD>
</TR>
<TR>
<TD style="WIDTH: 285px" vAlign="top">
<p><STRONG>Select a date for a new kayak tour:</STRONG></p>
<asp:calendar id="calTours" runat="server" BorderStyle="Inset" VisibleDate="2004-03-01" TitleFormat="Month"
								ShowGridLines="True" Font-Bold="True" Font-Names="Arial" Height="280px"
								Width="264px" BorderColor="Blue">
<DayStyle ForeColor="Black"></DayStyle>
</asp:calendar></TD>
<TD style="WIDTH: 30px"></TD>
<TD vAlign="top">
<P><STRONG>Tour Title:</STRONG></P>
<P><asp:textbox id="txtTitle" runat="server" Width="288px"></asp:textbox>&nbsp;
<asp:button id="btnAdd" runat="server" Width="64px" Text="Add"></asp:button></P>
<P><STRONG>Current Tours:</STRONG></P>
<P><asp:listbox id="lstTours" runat="server" Font-Bold="True" Font-Names="Arial" Height="184px"
									Width="368px"></asp:listbox></P>
</TD>
</TR>
</TABLE>
</H4>
<H4>
<P><asp:label id="lblMessage" runat="server" Font-Bold="True" Width="360px" ForeColor="Red"></asp:label></P>
</H4>
</form>
</body>
</HTML>
