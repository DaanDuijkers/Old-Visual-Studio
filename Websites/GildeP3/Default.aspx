<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="StyleSheet.css" />
    <style type="text/css">
        .auto-style1 {
            width: 27%;
        }
        .auto-style2 {
            width: 120px;
        }
        .auto-style3 {
            width: 219px;
        }
        .auto-style4 {
            width: 120px;
            height: 33px;
        }
        .auto-style5 {
            width: 219px;
            height: 33px;
        }
        .auto-style6 {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="inputformulier">
            <h1>Herkansing Toets ASP.net P3  2018</h1>
            <h3>Input Opleiding Information</h3>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">Naam</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txbNaam" runat="server" Width="265px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btnSave" runat="server" Text="Save" Width="118px" OnClick="btnSave_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Niveau</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txbNiveau" runat="server" Width="262px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btnShowData" runat="server" Text="Show Data" Width="118px" OnClick="btnShowData_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Studieduur</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txbStudieduur" runat="server" Width="260px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnClear" runat="server" Text="Clear" Width="118px" OnClick="btnClear_Click" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="lblOutput" runat="server"></asp:Label>
            <br />
            <asp:ListBox ID="lbDatabase" runat="server" Height="200px" Width="488px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
