<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmAccount.aspx.cs" Inherits="frmAccount" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
        <style type="text/css">
            .auto-style1 {
                width: 100%;
            }
            .auto-style2 {
                width: 260px;
            }
        </style>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2">Gebruikersnaam<br />
                            <asp:TextBox ID="txbGebruikersnaam" runat="server" Width="260px"></asp:TextBox>
                        </td>
                        <td>Wachtwoord<br />
                            <asp:TextBox ID="txbWachtwoord" runat="server" Width="260px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td aria-atomic="False" class="auto-style2">Achternaam<br />
                            <asp:TextBox ID="txbAchternaam" runat="server" Width="260px"></asp:TextBox>
                        </td>
                        <td>Tussenvoegsel<br />
                            <asp:TextBox ID="txbTussenvoegsel" runat="server" Width="260px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">Voornaam<br />
                            <asp:TextBox ID="txbVoornaam" runat="server" Width="260px"></asp:TextBox>
                        </td>
                        <td>Adres<br />
                            <asp:TextBox ID="txbAdres" runat="server" Width="260px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">Woonplaats<br />
                            <asp:TextBox ID="txbWoonplaats" runat="server" Width="260px"></asp:TextBox>
                        </td>
                        <td>Woonplaats<br />
                            <asp:TextBox ID="txbEmail" runat="server" Width="260px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                
            </div>
            <asp:Button ID="btnAanpassen" runat="server" Text="Pas aan" />
        </form>
    </body>
</html>
