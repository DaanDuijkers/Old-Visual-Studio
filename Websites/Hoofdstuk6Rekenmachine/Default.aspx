<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 76px;
        }
        .auto-style3 {
            width: 172px;
        }
        .auto-style4 {
            width: 272px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Getal1"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txbGetal1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="rfvGetal1" runat="server" ControlToValidate="txbGetal1" ErrorMessage="Vul getal1 in!   "></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvGetal1" runat="server" ControlToValidate="txbGetal1" ErrorMessage="Tussen de 1 en 100" MaximumValue="100" MinimumValue="1"></asp:RangeValidator>
                </td>
                <td>
                    <asp:Button ID="btnOptellen" runat="server" OnClick="btnOptellen_Click" Text="Optellen" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Getal2"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txbGetal2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="rfvGetal2" runat="server" ControlToValidate="txbGetal2" ErrorMessage="Vul getal2 in!"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Button ID="btnAftrekken" runat="server" OnClick="btnAftrekken_Click" Text="Aftrekken" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Uitkomst"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txbUitkomst" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
