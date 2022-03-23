<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Wedstrijden.aspx.cs" Inherits="Paginas_Wedstrijden" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table class="auto-style1">
    <tr>
        <td>
            <asp:Label ID="lblToernooi0" runat="server" Text="Toernooi naam:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlToernooi" runat="server" DataSourceID="sdsToernooi" DataTextField="Toernooi_Naam" DataValueField="Toernooi_Naam">
            </asp:DropDownList>
            <asp:SqlDataSource ID="sdsToernooi" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [Toernooi_Naam] FROM [TOERNOOI]"></asp:SqlDataSource>
        </td>
        <td>
            <asp:Label ID="lblRonde0" runat="server" Text="Ronde:"></asp:Label>
            <br />
            <asp:TextBox ID="txbRonde" runat="server" TextMode="Number"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblSpeler1" runat="server" Text="Speler 1:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlSpeler1" runat="server" DataSourceID="sdsSpeler" DataTextField="Speler_Voornaam" DataValueField="Speler_Voornaam">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlSpeler1Tussenvoegsel" runat="server" DataSourceID="sdsSpeler1Tussenvoegsel" DataTextField="Speler_Tussenvoegsel" DataValueField="Speler_Tussenvoegsel">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlSpeler1Achternaam" runat="server" DataSourceID="sdsSpeler1Achternaam" DataTextField="Speler_Achternaam" DataValueField="Speler_Achternaam">
            </asp:DropDownList>
            <asp:SqlDataSource ID="sdsSpeler1Achternaam" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [Speler_Achternaam] FROM [SPELER]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="sdsSpeler1Tussenvoegsel" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [Speler_Tussenvoegsel] FROM [SPELER]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="sdsSpeler" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [Speler_Voornaam], [Speler_Tussenvoegsel], [Speler_Achternaam] FROM [SPELER] ORDER BY [Speler_Voornaam], [Speler_Achternaam], [Speler_Tussenvoegsel]"></asp:SqlDataSource>
        </td>
        <td>
            <asp:Label ID="lblSpeler2" runat="server" Text="Speler 2:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlSpeler2" runat="server" DataSourceID="sdsSpelers2" DataTextField="Speler_Voornaam" DataValueField="Speler_Voornaam">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlSpeler2Tussenvoegsel" runat="server" DataSourceID="sdsSpeler2Tussenvoegsel" DataTextField="Speler_Tussenvoegsel" DataValueField="Speler_Tussenvoegsel">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlSpeler2Achternaam" runat="server" DataSourceID="sdsSpeler2Achternaam" DataTextField="Speler_Achternaam" DataValueField="Speler_Achternaam">
            </asp:DropDownList>
            <asp:SqlDataSource ID="sdsSpeler2Achternaam" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [Speler_Achternaam] FROM [SPELER]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="sdsSpeler2Tussenvoegsel" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [Speler_Tussenvoegsel] FROM [SPELER]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="sdsSpelers2" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [Speler_Voornaam], [Speler_Tussenvoegsel], [Speler_Achternaam] FROM [SPELER]"></asp:SqlDataSource>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblVeld0" runat="server" Text="Veld:"></asp:Label>
            <br />
            <asp:TextBox ID="txbVeld" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblBeginTijd0" runat="server" Text="Begin Tijd:"></asp:Label>
            <br />
            <asp:TextBox ID="txbBeginTijd" runat="server" TextMode="Time"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblEindTijd" runat="server" Text="Eind Tijd:"></asp:Label>
            <br />
            <asp:TextBox ID="txbEindTijd" runat="server" TextMode="Time"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblScheidsrechter" runat="server" Text="Scheidsrechter:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlScheidsrechter" runat="server" DataSourceID="sdsScheidsrechter" DataTextField="Voornaam" DataValueField="Voornaam">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlScheidsrechterTussenvoegsel" runat="server" DataSourceID="sdsScheidsrechterTussenvoegsel" DataTextField="Tussenvoegsel" DataValueField="Tussenvoegsel">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlScheidsrechterAchternaam" runat="server" DataSourceID="sdsScheidsrechterAchternaam" DataTextField="Achternaam" DataValueField="Achternaam">
            </asp:DropDownList>
            <asp:SqlDataSource ID="sdsScheidsrechterAchternaam" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [Achternaam] FROM [SCHEIDSRECHTER]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="sdsScheidsrechterTussenvoegsel" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [Tussenvoegsel] FROM [SCHEIDSRECHTER]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="sdsScheidsrechter" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [Voornaam] FROM [SCHEIDSRECHTER]"></asp:SqlDataSource>
        </td>
    </tr>
</table>

    <asp:Button ID="btnSubmit" runat="server" Text="Voer in" OnClick="btnSubmit_Click" />
    <br />
    <asp:Label ID="lblResult" runat="server"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="grdWedstrijd" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="sdsWedstrijd">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Toernooi_Id" HeaderText="Toernooi_Id" SortExpression="Toernooi_Id" />
            <asp:BoundField DataField="Ronde" HeaderText="Ronde" SortExpression="Ronde" />
            <asp:BoundField DataField="Speler1_Id" HeaderText="Speler1_Id" SortExpression="Speler1_Id" />
            <asp:BoundField DataField="Speler2_Id" HeaderText="Speler2_Id" SortExpression="Speler2_Id" />
            <asp:BoundField DataField="Veld" HeaderText="Veld" SortExpression="Veld" />
            <asp:BoundField DataField="Begin_Tijd" HeaderText="Begin_Tijd" SortExpression="Begin_Tijd" />
            <asp:BoundField DataField="Eind_Tijd" HeaderText="Eind_Tijd" SortExpression="Eind_Tijd" />
            <asp:BoundField DataField="Scheidsrechter_Id" HeaderText="Scheidsrechter_Id" SortExpression="Scheidsrechter_Id" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="sdsWedstrijd" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [Id], [Toernooi_Id], [Ronde], [Speler1_Id], [Speler2_Id], [Veld], [Begin_Tijd], [Eind_Tijd], [Scheidsrechter_Id] FROM [WEDSTRIJD]"></asp:SqlDataSource>

</asp:Content>