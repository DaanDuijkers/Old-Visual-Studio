﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="hoofdstuk9Opdracht9.aspx.cs" Inherits="hoofdstuk9Opdracht9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>De nationale begroetingssite</h1>
        <br />
        Geef uw naam in: 
        <asp:TextBox ID="txbNaam" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" Text="Druk hier voor de begroeting" Width="231px" />
        <br />
        <br />
        <asp:Label ID="lblOutput" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
