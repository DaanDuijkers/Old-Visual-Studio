<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Paginas_Account_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
    <asp:Button ID="btnLogin" runat="server" Text="Log in" OnClick="btnLogin_Click" />
    <br />
    <asp:Label ID="lblLogin" runat="server"></asp:Label>
</asp:Content>

