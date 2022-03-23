<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
        <style type="text/css">
            .auto-style1 {
                width: 100%;
            }
        </style>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <table class="auto-style1">
                    <tr>
                        <td>
                            <asp:Label ID="lblGebruikersnaam" runat="server" Text="Gebruikersnaam:"></asp:Label>
                            <br />
                            <asp:TextBox ID="txbGebruikersnaam" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblWachtwoord" runat="server" Text="Wachtwoord:"></asp:Label>
                            <br />
                            <asp:TextBox ID="txbWachtwoord" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Log in" />
                <br />
                <br />
                <asp:Label ID="lblLogin" runat="server"></asp:Label>
            </div>
        </form>
    </body>
</html>