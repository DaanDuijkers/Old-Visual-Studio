<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="VoegToeFilm.aspx.cs" Inherits="VoegToeFilm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Voeg toe film</h1>
    Vul de onderstaande velden in om de knop om de film toe te voegen.<br />
    <br />
    Titel<asp:TextBox ID="txbTitel" runat="server" /><br />
    Datum uitgifte<asp:TextBox ID="txbDatum" runat="server" />(jjjj-mm-dd)<br />
    <br />
    <asp:Button ID="btnVoegToe" runat="server" text="Toevoegen" OnClick="btnVoegToe_Click" />
</asp:Content>

