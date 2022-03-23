<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="text-align:center">
    <div>
    
        <h1 style="color:red; background-color:Highlight">Een Rekenmachine in C#</h1>
        <div style ="background-color:green">
        <table style="background-color:silver; margin-left:auto; margin-right:auto";>
            <tr>
                <td>Getal 1</td>
                <td><asp:TextBox ID="txbGetal1" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Button ID="btnPlus" runat="server" Height="36px" OnClick="btnPlus_Click" Text="+" Width="38px" />
                </td>
                <td>
                    <asp:Button ID="btnKeer" runat="server" Height="36px" OnClick="btnKeer_Click" Text="*" Width="38px" />
                </td>
            </tr>
            <tr>
                <td>Getal 2</td>
                <td>
                    <asp:TextBox ID="txbGetal2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnMin" runat="server" Height="34px" OnClick="btnMin_Click" Text="-" Width="38px" />
                </td>
                <td>
                    <asp:Button ID="btnDeel" runat="server" Height="34px" OnClick="btnDeel_Click" Text="/" Width="36px" />
                </td>
            </tr>
            <tr>
                <td>Getal 3</td>
                <td>
                    <asp:TextBox ID="txbGetal3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Uitkomst</td>
                <td>
                    <asp:Label ID="lblUitkomst" runat="server" Style="background-color:yellow"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        </div>
    </div>
    </form>
</body>
</html>
