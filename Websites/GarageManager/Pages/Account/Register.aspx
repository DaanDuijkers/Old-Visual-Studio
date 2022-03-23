<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Pages_Account_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Literal ID="litStatus" runat="server"></asp:Literal>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label>
    <br />
    <asp:TextBox ID="txbUsername" runat="server" CssClass="inputs"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
    <br />
    <asp:TextBox ID="txbPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Confirm Password:"></asp:Label>
    <br />
    <asp:TextBox ID="txbConfirmPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
    <br />
    First Name (Not Required):<br />
    <asp:TextBox ID="txbFirstName" runat="server" CssClass="inputs"></asp:TextBox>
    <br />
    Last Name (Not Required):<br />
    <asp:TextBox ID="txbLastName" runat="server" CssClass="inputs"></asp:TextBox>
    <br />
    Address:<br />
    <asp:TextBox ID="txbAddress" runat="server" CssClass="inputs"></asp:TextBox>
    <br />
    Postal Code:<br />
    <asp:TextBox ID="txbPostalCode" runat="server" CssClass="inputs"></asp:TextBox>
    <br />
    <asp:Button ID="btnRegister" runat="server" CssClass="button" OnClick="btnRegister_Click" Text="Button" />
</asp:Content>

