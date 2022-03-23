<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        mijn eerst ASP.NET pagina</div>
        <p>
            <asp:Button ID="btnPostBack" runat="server" Text="Druk op mij!" />
        </p>
        <asp:Calendar ID="calKalender" runat="server"></asp:Calendar>
        <p>
            <asp:TextBox ID="txtNaam" runat="server" MaxLength="25">Typ hier je naam</asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnDoeIets" runat="server" OnClick="btnDoeIets_Click" Text="Verzenden" />
        </p>
        <p>
            <asp:Label ID="lblBoodschap" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
