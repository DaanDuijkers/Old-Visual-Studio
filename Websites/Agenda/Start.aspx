<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Start.aspx.cs" Inherits="Start" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Opmaak.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
     <div id="kalender">
            <h2>Agenda</h2>
            <p>
                <asp:Calendar ID="calAgenda" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" OnSelectionChanged="calAgenda_SelectionChanged" ShowGridLines="True" Width="220px">
                    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                    <OtherMonthDayStyle ForeColor="#CC9966" />
                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                    <SelectorStyle BackColor="#FFCC66" />
                    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                </asp:Calendar>
            </p>
        </div>
        <div id="tijdstip">
            <h2>Tijdstip</h2>
            <p>
                <asp:ListBox ID="lbTijd" runat="server" Height="95px" Width="135px" OnSelectedIndexChanged="lbTijd_SelectedIndexChanged"></asp:ListBox>
            </p>
        </div>
        <div id="bericht">
            <h2>Bericht</h2>
            <p>
                <asp:TextBox ID="txbBericht" runat="server" Height="77px" MaxLength="512" TextMode="MultiLine" Width="270px"></asp:TextBox>
            </p>
        </div>
        <div id="overzicht">
            <h2>Afspraken</h2>
            <p>
                <asp:ListBox ID="lbAfspraken" runat="server" Height="168px" Width="690px" OnSelectedIndexChanged="lbAfspraken_SelectedIndexChanged"></asp:ListBox>
            </p>
        </div>
        <div id="knoppen">
            <asp:ImageButton ID="btnBewaren" runat="server" Height="60px" ImageUrl="images/Toevoegen.png" Width="60px" />
            <asp:ImageButton ID="btnAnnuleren" runat="server" Height="60px" ImageUrl="images/Annuleren.png" Width="60px" />
        </div>
    </form>
</body>
</html>
