<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="StyleSheet.css" />
    <style type="text/css">
        .auto-style1 {
            width: 34%;
        }
        .auto-style3 {
            width: 275px;
        }
        .auto-style4 {
            height: 26px;
            width: 275px;
        }
        .auto-style5 {
            width: 715px;
        }
        .auto-style6 {
            height: 26px;
            width: 715px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Toets ASP.net P4 2018</h1>
        <h2>Player Dashbaord</h2>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txbName" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label2" runat="server" Text="Gender:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:RadioButton ID="rbMale" runat="server" Text="Male" GroupName="rbGender" />
                    <asp:RadioButton ID="rbFemale" runat="server" Text="Female" GroupName="rbGender" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txbAddress" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label4" runat="server" Text="Email address"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txbEmailAddress" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label5" runat="server" Text="Mobiele no"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txbMobileNumber" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label6" runat="server" Text="Team"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txbTeam" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
        </table>

        <asp:Label ID="lblOutput" runat="server"></asp:Label>

        <div id="buttons">
            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <asp:Button ID="btnShowData" runat="server" Text="Show Data" OnClick="btnShowData_Click" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        </div>
        <div class="gridview">
            <asp:GridView ID="gvPlayers" runat="server">
            </asp:GridView>
        </div>
    </div>
    </form>
</body>
</html>
