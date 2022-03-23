<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Uitslagen.aspx.cs" Inherits="Paginas_Uitslagen" %>

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
                <asp:Label ID="lblWinnaar" runat="server" Text="Winnaar:"></asp:Label>
                <br />
                <asp:TextBox ID="txbWinnaar" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblSpeler1" runat="server" Text="Speler 1 score:"></asp:Label>
                <br />
                <asp:TextBox ID="txbSpeler1Score" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblSpeler2" runat="server" Text="Speler 2 score:"></asp:Label>
                <br />
                <asp:TextBox ID="txbSpeler2Score" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:Button ID="btnSubmit" runat="server" Enabled="False" OnClick="btnSubmit_Click" Text="Voer in" />
    <br />
    <table class="auto-style1">
        <tr>
            <td>
                <asp:Label ID="lblToernooi" runat="server" Text="Toernooi naam:"></asp:Label>
                <br />
                <asp:TextBox ID="txbToernooi" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblSpeler1Naam" runat="server" Text="Speler 1 naam:"></asp:Label>
                <br />
                <asp:TextBox ID="txbSpeler1Naam" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblSpeler2Naam" runat="server" Text="Speler 2 naam:"></asp:Label>
                <br />
                <asp:TextBox ID="txbSpeler2Naam" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblRonde" runat="server" Text="Ronde:"></asp:Label>
                <br />
                <asp:TextBox ID="txbRonde" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:Button ID="btnZoek" runat="server" OnClick="btnZoek_Click" Text="Zoek" />
    <br />
    <br />
    <asp:Label ID="lblResult" runat="server"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="sdsScore">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" />
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Ronde" HeaderText="Ronde" SortExpression="Ronde" />
            <asp:BoundField DataField="Speler1_Id" HeaderText="Speler1_Id" SortExpression="Speler1_Id" />
            <asp:BoundField DataField="Speler2_Id" HeaderText="Speler2_Id" SortExpression="Speler2_Id" />
            <asp:BoundField DataField="Score1" HeaderText="Score1" SortExpression="Score1" />
            <asp:BoundField DataField="Score2" HeaderText="Score2" SortExpression="Score2" />
            <asp:BoundField DataField="Winnaar_Id" HeaderText="Winnaar_Id" SortExpression="Winnaar_Id" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="sdsScore" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" DeleteCommand="DELETE FROM [WEDSTRIJD] WHERE [Id] = @Id" InsertCommand="INSERT INTO [WEDSTRIJD] ([Ronde], [Speler1_Id], [Speler2_Id], [Score1], [Score2], [Winnaar_Id]) VALUES (@Ronde, @Speler1_Id, @Speler2_Id, @Score1, @Score2, @Winnaar_Id)" SelectCommand="SELECT [Id], [Ronde], [Speler1_Id], [Speler2_Id], [Score1], [Score2], [Winnaar_Id] FROM [WEDSTRIJD]" UpdateCommand="UPDATE [WEDSTRIJD] SET [Ronde] = @Ronde, [Speler1_Id] = @Speler1_Id, [Speler2_Id] = @Speler2_Id, [Score1] = @Score1, [Score2] = @Score2, [Winnaar_Id] = @Winnaar_Id WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Ronde" Type="Int32" />
            <asp:Parameter Name="Speler1_Id" Type="Int32" />
            <asp:Parameter Name="Speler2_Id" Type="Int32" />
            <asp:Parameter Name="Score1" Type="Int32" />
            <asp:Parameter Name="Score2" Type="Int32" />
            <asp:Parameter Name="Winnaar_Id" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Ronde" Type="Int32" />
            <asp:Parameter Name="Speler1_Id" Type="Int32" />
            <asp:Parameter Name="Speler2_Id" Type="Int32" />
            <asp:Parameter Name="Score1" Type="Int32" />
            <asp:Parameter Name="Score2" Type="Int32" />
            <asp:Parameter Name="Winnaar_Id" Type="Int32" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

