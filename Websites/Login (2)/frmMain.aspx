<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="Home" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Login Pagina</title>
        <link href="frmHome.aspx" />
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:Menu ID="menuPaginas" runat="server" OnMenuItemClick="menuPaginas_MenuItemClick" Orientation="Horizontal">
                    <Items>
                        <asp:MenuItem Text="Home" Value="Home"></asp:MenuItem>
                        <asp:MenuItem Text="Inloggen" Value="Inloggen"></asp:MenuItem>
                        <asp:MenuItem Text="Registreren" Value="Registreren"></asp:MenuItem>
                        <asp:MenuItem Text="Account" Value="Account"></asp:MenuItem>
                        <asp:MenuItem Text="Uitloggen" Value="Uitloggen"></asp:MenuItem>
                        <asp:MenuItem Text="Afsluiten" Value="Afsluiten"></asp:MenuItem>
                    </Items>
                </asp:Menu>
            </div>
            <asp:Panel ID="pnlPagina" runat="server">
            </asp:Panel>
        </form>
    </body>
</html>