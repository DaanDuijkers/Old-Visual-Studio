<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Scholen.aspx.cs" Inherits="Paginas_Scholen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
        <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <div id="products">
            <asp:Label ID="lblSchoolNaam" runat="server" Text="Naam van de school:"></asp:Label>
            <br />
            <asp:TextBox ID="txbSchool" runat="server"></asp:TextBox><br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Voer in" OnClick="btnSubmit_Click" />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label><br />
            <br />
            <asp:GridView ID="grdScholen" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="sdsScholen" AllowPaging="True" AllowSorting="True">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="School_Naam" HeaderText="School_Naam" SortExpression="School_Naam" />
                </Columns>
        </asp:GridView>
            <asp:SqlDataSource ID="sdsScholen" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" DeleteCommand="DELETE FROM [SCHOOL] WHERE [Id] = @Id" InsertCommand="INSERT INTO [SCHOOL] ([School_Naam]) VALUES (@School_Naam)" SelectCommand="SELECT * FROM [SCHOOL]" UpdateCommand="UPDATE [SCHOOL] SET [School_Naam] = @School_Naam WHERE [Id] = @Id">
                <DeleteParameters>
                    <asp:Parameter Name="Id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="School_Naam" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="School_Naam" Type="String" />
                    <asp:Parameter Name="Id" Type="Int32" />
                </UpdateParameters>
        </asp:SqlDataSource>
        </div>
    </asp:Content>