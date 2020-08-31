<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Taekwondo Student Registration</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            <img align="top" src="cho_mag.jpg" style="width: 81px; height: 114px" />&nbsp; Taekwondo
            Student Registration<br />
            <hr />
        </h1>
        <p>
        </p>
        <p>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="First Name: "></asp:Label>
            <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox></p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Last Name: "></asp:Label><asp:TextBox
                ID="txtLast" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
            &nbsp;
        </p>
    </div>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Blue" Height="57px" Width="378px"></asp:Label><br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/cho_mag.jpg" />
    </form>
</body>
</html>
