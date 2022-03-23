<%@ Page Title="" Language="C#" MasterPageFile="~/frmMain.Master" AutoEventWireup="true" CodeBehind="frmAanpassen.aspx.cs" Inherits="LoginTest.frmAanpassen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

            .auto-style1 {
                width: 100%;
            }
            .auto-style2 {
                width: 260px;
            }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
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
            <td>Email<br />
                <asp:TextBox ID="txbEmail" runat="server" Width="260px"></asp:TextBox>
            </td>
        </tr>
    </table>
</div>
<asp:Button ID="btnAanpassen" runat="server" OnClick="btnAanpassen_Click" Text="Pas aan" />
<asp:Label ID="lblAccount" runat="server"></asp:Label>
    <br />
    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
</asp:Content>
