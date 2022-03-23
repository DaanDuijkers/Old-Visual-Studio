<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 110%;
        }
        .auto-style2 {
            width: 157px;
        }
        .auto-style3 {
            width: 350px;
        }
        .auto-style4 {
            width: 135px;
        }
    </style>
</head>
<body style="width: 996px">
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <h2 class="auto-style4"></h2>
                </td>
                <td class="auto-style3">
                    <h2>Input Opleiding Informatie</h2>
                </td>
                <td>
                    <h2></h2>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Opleiding naam:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txbOpleidingNaam" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Add" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Opleiding niveau:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txbOpleidingNiveau" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnEditData" runat="server" Text="Edit Data" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Studieduur:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txbStudieduur" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Omschrijving:</td>
                <asp:Button ID="Button3" runat="server" Text="Button" />
                <td class="auto-style3">
                    <asp:TextBox ID="txbOmschrijving" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnSearch" runat="server" Text="Search" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Kosten:</td>
                <asp:Button ID="Button2" runat="server" Text="Button" />
                <td class="auto-style3">
                    <asp:TextBox ID="txbKosten" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnShowData" runat="server" OnClick="btnShowData_Click" Text="Show Data" />
                    <asp:Button ID="btnClear" runat="server" Text="Clear" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Startdatum:</td>
                <td class="auto-style3">
                    <asp:Calendar ID="calKalender" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                        <OtherMonthDayStyle ForeColor="#CC9966" />
                        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                        <SelectorStyle BackColor="#FFCC66" />
                        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                    </asp:Calendar>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Label ID="lblOutput" runat="server"></asp:Label>
        <asp:GridView ID="gvShow" runat="server" DataSourceID="Gildeopleidingen1">
        </asp:GridView>
        <asp:SqlDataSource ID="Gildeopleidingen1" runat="server"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    </form>
</body>
</html>
