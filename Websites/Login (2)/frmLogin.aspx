<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmLogin.aspx.cs" Inherits="Login" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
        <style type="text/css">
            .auto-style1 {
                width: 100%;
            }
            .auto-style2 {
                height: 48px;
                width: 1425px;
            }
            .auto-style3 {
                height: 48px;
                width: 260px;
            }
        </style>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style3">Gebruikersnaam<br />
                            <asp:TextBox ID="txbGebruikersnaam" runat="server" Width="260px"></asp:TextBox>
                        </td>
                        <td class="auto-style2">Wachtwoord<br />
                            <asp:TextBox ID="txbWachtwoord" runat="server" Width="260px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                
            </div>
            <asp:Button ID="btnLogin" runat="server" Text="Log in" />
        </form>
    </body>
</html>