<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 style="color:blue">Selecteer een datum in de kalender</h1>
        <p style="color:blue">
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </p>
        <h3>U heeft de onderstaande datum geselecteerd:</h3>
        <br />
        <asp:Label ID="lblDatum" runat="server"></asp:Label>
        <br />
        <h3>U bent nu</h3>
        <p>&nbsp;</p>
        <p>
            <asp:Label ID="lblLeeftijd" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnLaatZien" runat="server" Text="Laat Zien" style="background-color:green"/>
        </p>

    </div>
    </form>
</body>
</html>
