<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Producten.aspx.cs" Inherits="Paginas_Artikelen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="clear: both">
    <asp:DropDownList ID="ddlType" runat="server" DataSourceID="SqlDataSource1" DataTextField="TypeName" DataValueField="TypeName" OnSelectedIndexChanged="ddlType_SelectedIndexChanged" AppendDataBoundItems="True" AutoPostBack="True">
        <asp:ListItem Text="Selecteer categlorie" Value="0"></asp:ListItem>
    </asp:DropDownList>
        <asp:DropDownList ID="ddlOrder" runat="server" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="ddlOrder_SelectedIndexChanged">
            <asp:ListItem>Lage naar hoge prijs</asp:ListItem>
            <asp:ListItem>Hoge naar lage prijs</asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WebshopConnectionString %>" SelectCommand="SELECT DISTINCT [TypeName] FROM [Type] ORDER BY [TypeName]"></asp:SqlDataSource>
        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </div>
    <asp:Panel ID="pnlProducts" runat="server">
    </asp:Panel>
</asp:Content>