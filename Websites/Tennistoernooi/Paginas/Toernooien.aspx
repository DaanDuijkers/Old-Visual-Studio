<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Toernooien.aspx.cs" Inherits="Paginas_Toernooien" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 205px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblToernooi" runat="server" Text="Toernooinaam:"></asp:Label>
                <br />
                <asp:TextBox ID="txbToernooi" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblDatum" runat="server" Text="Datum:"></asp:Label>
                <br />
                <asp:TextBox ID="txbDatum" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Voer in" />
    <br />
    <br />
    <asp:Label ID="lblResult" runat="server"></asp:Label>
    <asp:GridView ID="grdToernooien" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="sdsToernooi">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Toernooi_Naam" HeaderText="Toernooi_Naam" SortExpression="Toernooi_Naam" />
            <asp:BoundField DataField="Datum" HeaderText="Datum" SortExpression="Datum" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="sdsToernooi" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" DeleteCommand="DELETE FROM [TOERNOOI] WHERE [Id] = @Id" InsertCommand="INSERT INTO [TOERNOOI] ([Toernooi_Naam], [Datum]) VALUES (@Toernooi_Naam, @Datum)" SelectCommand="SELECT * FROM [TOERNOOI]" UpdateCommand="UPDATE [TOERNOOI] SET [Toernooi_Naam] = @Toernooi_Naam, [Datum] = @Datum WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Toernooi_Naam" Type="String" />
            <asp:Parameter DbType="Date" Name="Datum" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Toernooi_Naam" Type="String" />
            <asp:Parameter DbType="Date" Name="Datum" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>

</asp:Content>