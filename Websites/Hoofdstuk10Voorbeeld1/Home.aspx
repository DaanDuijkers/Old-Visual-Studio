<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Welkom</h1>
    Welkom bij mijn website over films.<br />
    <br />
    Op deze site staat informatie over$nbsp;
    <asp:Literal ID="litAantal" runat="server" />
    $nbsp;films.
</asp:Content>

