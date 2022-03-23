<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Hoofdstuk9Maandnaam.aspx.cs" Inherits="Hoofdstuk9Maandnaam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Maandnaam: 
        <asp:TextBox ID="txbMaand" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" Text="Missie van de maand" Width="170px" />
        <br />
        <br />
        <asp:Label ID="lblOutput" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
