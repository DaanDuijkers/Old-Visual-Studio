<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageProducts.aspx.cs" Inherits="Paginas_Management_ManageProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    Naam:<br />
    <asp:TextBox ID="txbName" runat="server"></asp:TextBox><br />
    Type:<br />
    <asp:DropDownList ID="ddlType" runat="server" DataSourceID="SqlDataSource1" DataTextField="TypeName" DataValueField="Id">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WebshopConnectionString %>" SelectCommand="SELECT * FROM [Type] ORDER BY [TypeName]"></asp:SqlDataSource>
    <br />
    Prijs:<br />
    <asp:TextBox ID="txbPrice" runat="server"></asp:TextBox>
    <br />
    Images:<br />
    <asp:DropDownList ID="ddlImage" runat="server">
    </asp:DropDownList><br />
    Omschrijving:<br />
    <asp:TextBox ID="txbDescription" runat="server" Height="60px" TextMode="MultiLine" Width="250px" /><br />
    <asp:Button ID="btnSubmit" runat="server" Text="Opslaan" OnClick="btnSubmit_Click" /><br />
    <asp:Label ID="lblResult" runat="server" Text="" />
</asp:Content>

