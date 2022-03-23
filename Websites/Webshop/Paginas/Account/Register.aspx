<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Paginas_Account_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
            <tr>
                <td class="auto-style2">Gebruikersnaam<br />
                    <asp:TextBox ID="txbGebruikersnaam" runat="server" Width="260px"></asp:TextBox>
                </td>
                <td>Wachtwoord<br />
                    <asp:TextBox ID="txbWachtwoord" runat="server" Width="260px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td aria-atomic="False" class="auto-style2">Achternaam (niet verplicht)<br />
                    <asp:TextBox ID="txbAchternaam" runat="server" Width="260px"></asp:TextBox>
                </td>
                <td>Tussenvoegsel (niet verplicht)<br />
                    <asp:TextBox ID="txbTussenvoegsel" runat="server" Width="260px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Voornaam (niet verplicht)<br />
                    <asp:TextBox ID="txbVoornaam" runat="server" Width="260px"></asp:TextBox>
                </td>
                <td>Adres<br />
                    <asp:TextBox ID="txbAdres" runat="server" Width="260px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Email<br />
                    <asp:TextBox ID="txbEmail" runat="server" Width="260px"></asp:TextBox>
                </td>
            </tr>
        </table>
    <asp:Button ID="btnRegistreer" runat="server" Text="Registreer" OnClick="btnRegistreer_Click" />
<asp:Label ID="lblRegistreren" runat="server"></asp:Label>
</asp:Content>

