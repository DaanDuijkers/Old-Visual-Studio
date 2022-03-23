<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reken.aspx.cs" Inherits="Reken" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 78px;
        }
        .auto-style3 {
            width: 167px;
        }
        .auto-style4 {
            width: 1073px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Getal 1</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txbGetal1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Button ID="btnOptrekken" runat="server" OnClick="btnOptrekken_Click" Text="Optrekken" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Getal 2</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txbGetal2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Button ID="btnAftrekken" runat="server" OnClick="btnAftrekken_Click" Text="Aftrekken" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Uitkomst</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txbUitkomst" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
