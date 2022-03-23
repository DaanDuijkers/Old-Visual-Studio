<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inlogpagina</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Menu ID="MenuPaginas" runat="server" Orientation="Horizontal"></asp:Menu>

        <asp:Panel ID="pnlPagina" runat="server" Height="401px" OnLoad="pnlPagina_Load">
        </asp:Panel>
    </div>
    </form>
</body>
</html>
