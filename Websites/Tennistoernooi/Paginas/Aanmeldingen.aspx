<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Aanmeldingen.aspx.cs" Inherits="Paginas_Aanmeldingen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 773px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>
                <asp:Label ID="lblToernooi" runat="server" Text="Toernooi:"></asp:Label>
                <br />
                <asp:DropDownList ID="ddlToernooien" runat="server" DataSourceID="sdsToernooiNaam" DataTextField="Toernooi_Naam" DataValueField="Toernooi_Naam">
                </asp:DropDownList>
                <asp:SqlDataSource ID="sdsToernooiNaam" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [Toernooi_Naam] FROM [TOERNOOI]"></asp:SqlDataSource>
            </td>
            <td>
                <asp:Label ID="lblVoornaam" runat="server" Text="Speler Voornaam:"></asp:Label>
                <br />
                <asp:DropDownList ID="ddlVooraam" runat="server" DataSourceID="sdsVoornaam" DataTextField="Speler_Voornaam" DataValueField="Speler_Voornaam">
                </asp:DropDownList>
                <asp:SqlDataSource ID="sdsVoornaam" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [Speler_Voornaam] FROM [SPELER]"></asp:SqlDataSource>
            </td>
        </tr>
    </table>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblTussenvoegsel" runat="server" Text="Tussenvoegsel:"></asp:Label>
                <br />
                <asp:DropDownList ID="ddlTussenvoegsel" runat="server" DataSourceID="sdsTussenvoegsel" DataTextField="Speler_Tussenvoegsel" DataValueField="Speler_Tussenvoegsel">
                </asp:DropDownList>
                <asp:SqlDataSource ID="sdsTussenvoegsel" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [Speler_Tussenvoegsel] FROM [SPELER]"></asp:SqlDataSource>
            </td>
            <td>
                <asp:Label ID="lblAchternaam" runat="server" Text="Achternaam:"></asp:Label>
                <br />
                <asp:DropDownList ID="ddlAchternaam" runat="server" DataSourceID="sdsAchternaam" DataTextField="Speler_Achternaam" DataValueField="Speler_Achternaam">
                </asp:DropDownList>
                <asp:SqlDataSource ID="sdsAchternaam" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [Speler_Achternaam] FROM [SPELER]"></asp:SqlDataSource>
            </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Voer in" />
    <br />
    <asp:Label ID="lblResult" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblToernooien" runat="server" Text="Spelers in:"></asp:Label>
    &nbsp;<asp:DropDownList ID="ddlSchema" runat="server" DataSourceID="sdsSchema" DataTextField="Toernooi_Naam" DataValueField="Toernooi_Naam">
    </asp:DropDownList>
    <asp:SqlDataSource ID="sdsSchema" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [Toernooi_Naam] FROM [TOERNOOI]"></asp:SqlDataSource>
    <asp:Button ID="btnSchema" runat="server" OnClick="btnSchema_Click" Text="Zoek" />
    <br />
    <asp:GridView ID="grdAanmeldingen" runat="server">
    </asp:GridView>
</asp:Content>

