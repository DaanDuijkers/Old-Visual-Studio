<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Spelers.aspx.cs" Inherits="Paginas_Spelers" %>

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
            <asp:Label ID="lblVoornaam" runat="server" Text="Voornaam:"></asp:Label>
            <br />
            <asp:TextBox ID="txbVoornaam" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblTussenvoegsel" runat="server" Text="Tussenvoegsel (niet vereist):"></asp:Label>
            <br />
            <asp:TextBox ID="txbTussenvoegsel" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblAchternaam" runat="server" Text="Achternaam:"></asp:Label>
            <br />
            <asp:TextBox ID="txbAchternaam" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblVoornaam2" runat="server" Text="School:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlScholen" runat="server" DataSourceID="sdsSchoolnaam" DataTextField="School_Naam" DataValueField="School_Naam">
            </asp:DropDownList>
            <asp:SqlDataSource ID="sdsSchoolnaam" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [School_Naam] FROM [SCHOOL] ORDER BY [School_Naam]"></asp:SqlDataSource>
        </td>
    </tr>
</table>
<br />
<asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Voer in" />
<br />
<br />
<asp:Label ID="lblResult" runat="server"></asp:Label>
<br />
<asp:GridView ID="grdSpelers" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="sdsScholen">
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
        <asp:BoundField DataField="Speler_Voornaam" HeaderText="Speler_Voornaam" SortExpression="Speler_Voornaam" />
        <asp:BoundField DataField="Speler_Tussenvoegsel" HeaderText="Speler_Tussenvoegsel" SortExpression="Speler_Tussenvoegsel" />
        <asp:BoundField DataField="Speler_Achternaam" HeaderText="Speler_Achternaam" SortExpression="Speler_Achternaam" />
        <asp:BoundField DataField="School_Id" HeaderText="School_Id" SortExpression="School_Id" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="sdsScholen" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" DeleteCommand="DELETE FROM [SPELER] WHERE [Id] = @Id" InsertCommand="INSERT INTO [SPELER] ([Speler_Voornaam], [Speler_Tussenvoegsel], [Speler_Achternaam], [School_Id]) VALUES (@Speler_Voornaam, @Speler_Tussenvoegsel, @Speler_Achternaam, @School_Id)" SelectCommand="SELECT * FROM [SPELER]" UpdateCommand="UPDATE [SPELER] SET [Speler_Voornaam] = @Speler_Voornaam, [Speler_Tussenvoegsel] = @Speler_Tussenvoegsel, [Speler_Achternaam] = @Speler_Achternaam, [School_Id] = @School_Id WHERE [Id] = @Id">
    <DeleteParameters>
        <asp:Parameter Name="Id" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="Speler_Voornaam" Type="String" />
        <asp:Parameter Name="Speler_Tussenvoegsel" Type="String" />
        <asp:Parameter Name="Speler_Achternaam" Type="String" />
        <asp:Parameter Name="School_Id" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Speler_Voornaam" Type="String" />
        <asp:Parameter Name="Speler_Tussenvoegsel" Type="String" />
        <asp:Parameter Name="Speler_Achternaam" Type="String" />
        <asp:Parameter Name="School_Id" Type="Int32" />
        <asp:Parameter Name="Id" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>

