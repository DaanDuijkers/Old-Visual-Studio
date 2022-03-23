<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .table {
            width: 22%;
            background-color: lightgrey;
            border: 1px solid black;
            margin-left: auto;
            margin-right: auto;
        }

        .auto-style2 {
            width: 71px;
        }

        .auto-style3 {
            width: 173px;
        }

        .auto-style4 {
            width: 52px;
        }

        .header{
            background-color: #42f4ee;
            text-align: center;
        }

        .body{
            background-color: #86f442;
            height: 200px;
        }

        .label{
            width: 80px;
            background-color: yellow;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <font color="red">
                <h1>Een rekenmachine in C#</h1>
            </font>
        </div>
        <div class="body">
            <table class="table">
                <tr>
                    <td class="auto-style2">Getal 1</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txbGetal1" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="btnPlus" runat="server" Height="47px" OnClick="btnPlus_Click" Text="+" Width="51px" />
                    </td>
                    <td>
                        <asp:Button ID="btnKeer" runat="server" Height="48px" OnClick="btnKeer_Click" Text="*" Width="51px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Getal 2</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txbGetal2" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="btnMin" runat="server" Height="47px" OnClick="btnMin_Click" Text="-" Width="52px" />
                    </td>
                    <td>
                        <asp:Button ID="btnDelen" runat="server" Height="47px" OnClick="btnDelen_Click" Text="/" Width="51px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Getal 3</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txbGetal3" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Uitkomst</td>
                    <td class="auto-style3">
                        <div class="label">
                            <asp:Label ID="lblOutput" runat="server" Width="80px"></asp:Label>
                        </div>
                        </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
