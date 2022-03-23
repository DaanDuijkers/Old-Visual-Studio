<%@ Page Title="" Language="C#" MasterPageFile="~/frmMain.Master" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="LoginTest.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

            .auto-style1 {
                width: 100%;
            }
            .auto-style3 {
                height: 48px;
                width: 260px;
            }
            .auto-style2 {
                height: 48px;
                width: 1425px;
            }
            </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Gebruikersnaam<br />
                <asp:TextBox ID="txbGebruikersnaam" runat="server" Width="260px"></asp:TextBox>
            </td>
            <td class="auto-style2">Wachtwoord<br />
                <asp:TextBox ID="txbWachtwoord" runat="server" Width="260px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
    </table>
</div>
<asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Log in" />
<asp:Label ID="lblLogin" runat="server"></asp:Label>
</asp:Content>
