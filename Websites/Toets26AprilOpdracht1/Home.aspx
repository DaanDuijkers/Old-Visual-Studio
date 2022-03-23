<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 46%;
        }
        .auto-style2 {
            width: 78px;
        }
        .auto-style3 {
            width: 203px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="background">
            
            <h2>Toets ASP.net P3 2018</h2>
            <h3>Input Country Information</h3>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Name</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txbName" runat="server" Width="194px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" Width="119px" OnClick="btnSave_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Capital</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txbCapital" runat="server" Width="195px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnShowData" runat="server" Text="Show Data" OnClick="btnShowData_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Language</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txbLanguage" runat="server" Width="194px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnClear" runat="server" Text="Clear" Width="119px" OnClick="btnClear_Click" />
                    </td>
                </tr>
            </table>

            <div id="label">
                <asp:Label ID="lblOutput" runat="server"></asp:Label>
                <br />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Country]"></asp:SqlDataSource>
            </div>
            <div id="countries">
                <h2>Countries</h2>
                <p>
                    <asp:ListBox ID="lbOutput" runat="server" Width="566px"></asp:ListBox>
                </p>

            </div>
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
