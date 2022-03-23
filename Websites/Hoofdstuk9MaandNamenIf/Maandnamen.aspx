<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Maandnamen.aspx.cs" Inherits="Maandnamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Maand: 
        <asp:TextBox ID="txbInput" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" Text="Missie van de Maand" Width="170px" />
        <br />
        <br />
        <asp:Label ID="lblOutput" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
