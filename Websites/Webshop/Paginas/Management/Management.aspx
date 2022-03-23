<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Management.aspx.cs" Inherits="Paginas_Management_Management" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:LinkButton ID="lnkbtnProducts" runat="server" PostBackUrl="~/Paginas/Management/ManageProducts.aspx">Voeg product toe</asp:LinkButton>
<asp:GridView ID="grdProducts" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="sdsProducts" OnRowEditing="grdProducts_RowEditing">
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
        <asp:BoundField DataField="TypeId" HeaderText="TypeId" SortExpression="TypeId" />
        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
        <asp:BoundField DataField="Image" HeaderText="Image" SortExpression="Image" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="sdsProducts" runat="server" ConnectionString="<%$ ConnectionStrings:WebshopConnectionString %>" DeleteCommand="DELETE FROM [Product] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Product] ([Name], [Description], [TypeId], [Price], [Image]) VALUES (@Name, @Description, @TypeId, @Price, @Image)" SelectCommand="SELECT * FROM [Product]" UpdateCommand="UPDATE [Product] SET [Name] = @Name, [Description] = @Description, [TypeId] = @TypeId, [Price] = @Price, [Image] = @Image WHERE [Id] = @Id">
    <DeleteParameters>
        <asp:Parameter Name="Id" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="Name" Type="String" />
        <asp:Parameter Name="Description" Type="String" />
        <asp:Parameter Name="TypeId" Type="Int32" />
        <asp:Parameter Name="Price" Type="Decimal" />
        <asp:Parameter Name="Image" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Name" Type="String" />
        <asp:Parameter Name="Description" Type="String" />
        <asp:Parameter Name="TypeId" Type="Int32" />
        <asp:Parameter Name="Price" Type="Decimal" />
        <asp:Parameter Name="Image" Type="String" />
        <asp:Parameter Name="Id" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
<br />
<asp:LinkButton ID="lnkbtnTypes" runat="server" PostBackUrl="~/Paginas/Management/ManageProductTypes.aspx">Voeg type toe</asp:LinkButton>
<asp:GridView ID="grdTypes" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="sdsTypes">
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
        <asp:BoundField DataField="TypeName" HeaderText="TypeName" SortExpression="TypeName" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="sdsTypes" runat="server" ConnectionString="<%$ ConnectionStrings:WebshopConnectionString %>" DeleteCommand="DELETE FROM [Type] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Type] ([TypeName]) VALUES (@TypeName)" SelectCommand="SELECT * FROM [Type]" UpdateCommand="UPDATE [Type] SET [TypeName] = @TypeName WHERE [Id] = @Id">
    <DeleteParameters>
        <asp:Parameter Name="Id" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="TypeName" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="TypeName" Type="String" />
        <asp:Parameter Name="Id" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
<br />
Geregistreerde klanten:<asp:GridView ID="grdClients" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="sdsClients">
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
        <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
        <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
        <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
        <asp:BoundField DataField="Insertion" HeaderText="Insertion" SortExpression="Insertion" />
        <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
        <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
        <asp:BoundField DataField="Mail" HeaderText="Mail" SortExpression="Mail" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="sdsClients" runat="server" ConnectionString="<%$ ConnectionStrings:WebshopConnectionString %>" DeleteCommand="DELETE FROM [Client] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Client] ([UserName], [Password], [FirstName], [Insertion], [LastName], [Address], [Mail]) VALUES (@UserName, @Password, @FirstName, @Insertion, @LastName, @Address, @Mail)" SelectCommand="SELECT * FROM [Client]" UpdateCommand="UPDATE [Client] SET [UserName] = @UserName, [Password] = @Password, [FirstName] = @FirstName, [Insertion] = @Insertion, [LastName] = @LastName, [Address] = @Address, [Mail] = @Mail WHERE [Id] = @Id">
    <DeleteParameters>
        <asp:Parameter Name="Id" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="UserName" Type="String" />
        <asp:Parameter Name="Password" Type="String" />
        <asp:Parameter Name="FirstName" Type="String" />
        <asp:Parameter Name="Insertion" Type="String" />
        <asp:Parameter Name="LastName" Type="String" />
        <asp:Parameter Name="Address" Type="String" />
        <asp:Parameter Name="Mail" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="UserName" Type="String" />
        <asp:Parameter Name="Password" Type="String" />
        <asp:Parameter Name="FirstName" Type="String" />
        <asp:Parameter Name="Insertion" Type="String" />
        <asp:Parameter Name="LastName" Type="String" />
        <asp:Parameter Name="Address" Type="String" />
        <asp:Parameter Name="Mail" Type="String" />
        <asp:Parameter Name="Id" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>

