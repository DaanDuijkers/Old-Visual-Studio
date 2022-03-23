<%@ Page Language="C#" AutoEventWireup="true" CodeFile="opdracht7.aspx.cs" Inherits="opdracht7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Rapport resultaten</h1>
        Geef het cijfer in: 
        <asp:TextBox ID="txbGetal" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnBereken" runat="server" OnClick="btnBereken_Click" Text="Bepaal Resultaat" />
        <br />
        Het resultaat is: <asp:TextBox ID="txbResultaat" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>
